using GencCelik.Models;
using GencCelik.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace GencCelik.Controllers
{
    [Authorize(Roles = "S, ASG, SG, Full")]
    public class ShippingController : Controller
    {
        Context c = new Context();
        ShippingRepository shippingR = new ShippingRepository();
        public IActionResult Index(string p, string co, string i, string dt, int page = 1)
        {
            var s = from x in c.ShippingTable select x;
            if (!string.IsNullOrEmpty(p) || !string.IsNullOrEmpty(i) || !string.IsNullOrEmpty(co) || !string.IsNullOrEmpty(dt))
                s = s.Where(x => x.Vehicle.Plate.StartsWith(p) || x.Company.StartsWith(co) || x.Invoice.EndsWith(i) || x.Date.StartsWith(dt));
            return View(s.Include("Person").Include("Vehicle").ToList().ToPagedList(page, 50));
        }

        public IActionResult ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                List<ShippingClass> s = c.ShippingTable.Select(p => new ShippingClass
                {
                    Person = p.Person,
                    Vehicle = p.Vehicle,
                    Company = p.Company,
                    Location = p.Location,
                    Destination = p.Destination,
                    Navlun = p.Navlun,
                    Kind = p.Kind,
                    Invoice = p.Invoice,
                    BookingNo = p.BookingNo,
                    Container = p.Container,
                    Description = p.Description,
                    Date = p.Date
                }).ToList();

                ExcelWorksheet ew = package.Workbook.Worksheets.Add("Report");

                ew.Cells["A1"].Value = "Şöför";
                ew.Cells["B1"].Value = "Araç Plakası";
                ew.Cells["C1"].Value = "Firma";
                ew.Cells["D1"].Value = "Yükleme Yeri";
                ew.Cells["E1"].Value = "Gideceği Yer";
                ew.Cells["F1"].Value = "Navlun";
                ew.Cells["G1"].Value = "Türü";
                ew.Cells["H1"].Value = "Fatura";
                ew.Cells["I1"].Value = "Booking No";
                ew.Cells["J1"].Value = "Konteyner";
                ew.Cells["K1"].Value = "Açıklama";
                ew.Cells["L1"].Value = "Tarih";

                int rowStart = 1;
                foreach (var item in s)
                {
                    rowStart++;
                    ew.Cells[string.Format("A{0}", rowStart)].Value = item.Person.PName + " " + item.Person.PSurname;
                    ew.Cells[string.Format("B{0}", rowStart)].Value = item.Vehicle.Plate;
                    ew.Cells[string.Format("C{0}", rowStart)].Value = item.Company;
                    ew.Cells[string.Format("D{0}", rowStart)].Value = item.Location;
                    ew.Cells[string.Format("E{0}", rowStart)].Value = item.Destination;
                    ew.Cells[string.Format("F{0}", rowStart)].Value = item.Navlun;
                    ew.Cells[string.Format("G{0}", rowStart)].Value = item.Kind;
                    ew.Cells[string.Format("H{0}", rowStart)].Value = item.Invoice;
                    ew.Cells[string.Format("I{0}", rowStart)].Value = item.BookingNo;
                    ew.Cells[string.Format("J{0}", rowStart)].Value = item.Container;
                    ew.Cells[string.Format("K{0}", rowStart)].Value = item.Description;
                    ew.Cells[string.Format("L{0}", rowStart)].Value = string.Format("{0:dd.MM.yyyy}", item.Date);
                }

                ew.Cells["A:AZ"].AutoFitColumns();
                Response.Clear();
                var excelData = package.GetAsByteArray();
                var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                var fileName = "Nakliye.xlsx";
                return File(excelData, contentType, fileName);
            }
        }

        public void List()
        {
            List<SelectListItem> p1 = new List<SelectListItem>();
            p1.Add(new SelectListItem { Text = "20 '", Value = "20 '" });
            p1.Add(new SelectListItem { Text = "40 '", Value = "40 '" });
            p1.Add(new SelectListItem { Text = "Boş", Value = "Boş" });
            p1.Add(new SelectListItem { Text = "Dolu", Value = "Dolu" });
            p1.Add(new SelectListItem { Text = "Salkasa", Value = "Salkasa" });
            p1.Add(new SelectListItem { Text = "Damper", Value = "Damper" });
            ViewBag.p1 = p1;

            List<SelectListItem> rent2 = new List<SelectListItem>();
            rent2.Add(new SelectListItem { Text = "Fatura Kesildimedi", Value = "Fatura Kesilmedi" });
            rent2.Add(new SelectListItem { Text = "Fatura Kesildi", Value = "Fatura Kesildi" });            
            ViewBag.r2 = rent2;

            var user = HttpContext.Request.Cookies["user"];
            List<SelectListItem> lu = new List<SelectListItem>();
            lu.Add(new SelectListItem { Text = user, Value = user });
            ViewBag.lu = lu;

            List<SelectListItem> per = (from x in c.PersonTable.Where(x => x.Job.JName == "ŞÖFÖR" && x.Deletes == false).ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.PName + " " + x.PSurname,
                                            Value = x.Id.ToString()
                                        }).ToList();
            List<SelectListItem> vec = (from x in c.VehicleTable.Where(x => x.Deletes == false).ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Plate,
                                            Value = x.Id.ToString()
                                        }).ToList();
            ViewBag.per = per;
            ViewBag.vec = vec;
        }

        [HttpGet]
        public IActionResult NewShip()
        {
            List();
            return View();
        }

        [HttpPost]
        public IActionResult NewShip(ShippingClass p)
        {
            if (!ModelState.IsValid)
                return View("NewShip");
            shippingR.TAdd(p);
            return RedirectToAction("NewShip");
        }

        public IActionResult GetShipping(int id)
        {
            List<SelectListItem> p1 = new List<SelectListItem>();
            p1.Add(new SelectListItem { Text = "20 '", Value = "20 '" });
            p1.Add(new SelectListItem { Text = "40 '", Value = "40 '" });
            p1.Add(new SelectListItem { Text = "Boş", Value = "Boş" });
            p1.Add(new SelectListItem { Text = "Dolu", Value = "Dolu" });
            p1.Add(new SelectListItem { Text = "Salkasa", Value = "Salkasa" });
            p1.Add(new SelectListItem { Text = "Damper", Value = "Damper" });
            ViewBag.p1 = p1;

            List<SelectListItem> rent2 = new List<SelectListItem>();
            rent2.Add(new SelectListItem { Text = "Fatura Kesildi", Value = "Fatura Kesildi" });
            rent2.Add(new SelectListItem { Text = "Fatura Kesildimedi", Value = "Fatura Kesilmedi" });
            ViewBag.r2 = rent2;

            var user = HttpContext.Request.Cookies["user"];
            List<SelectListItem> lu = new List<SelectListItem>();
            lu.Add(new SelectListItem { Text = user, Value = user });
            ViewBag.lu = lu;

            List<SelectListItem> per = (from x in c.PersonTable.Where(x => x.Job.JName == "ŞÖFÖR" && x.Deletes == false).ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.PName + x.PSurname,
                                            Value = x.Id.ToString()
                                        }).ToList();
            List<SelectListItem> vec = (from x in c.VehicleTable.Where(x => x.Deletes == false).ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Plate,
                                            Value = x.Id.ToString()
                                        }).ToList();
            ViewBag.per = per;
            ViewBag.vec = vec;

            var p = shippingR.TGet(id);
            ShippingClass s = new ShippingClass
            {
                Id = p.Id,
                Company = p.Company,
                Location = p.Location,
                Destination = p.Destination,
                Navlun = p.Navlun,
                Kind = p.Kind,
                PersonID = p.PersonID,
                VehicleID = p.VehicleID,
                Invoice = p.Invoice,
                BookingNo = p.BookingNo,
                Container = p.Container,
                Description = p.Description,
                Date = p.Date
            };
            return View(s);
        }

        [HttpPost]
        public IActionResult UpdateShipping(ShippingClass p)
        {
            var x = shippingR.TGet(p.Id);
            x.Id = p.Id;
            x.Company = p.Company;
            x.Location = p.Location;
            x.Destination = p.Destination;
            x.Navlun = p.Navlun;
            x.Kind = p.Kind;
            x.PersonID = p.PersonID;
            x.VehicleID = p.VehicleID;
            x.Invoice = p.Invoice;
            x.BookingNo = p.BookingNo;
            x.Container = p.Container;
            x.Description = p.Description;
            x.Date = p.Date;
            x.LogUser = p.LogUser;
            shippingR.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteShipping(ShippingClass p)
        {
            var x = shippingR.TGet(p.Id);
            shippingR.TDelete(x);
            return RedirectToAction("Index");
        }
    }
}
