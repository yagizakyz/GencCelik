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
    public class HomeController : Controller
    {
        VehicleRepository vehicleR = new VehicleRepository();
        Context c = new Context();
        public IActionResult Index(string p, int page = 1)
        {
            var v = c.VehicleTable.OrderBy(x => x.VizeDate).ToList();

            var s = from x in c.VehicleTable select x;
            if (!string.IsNullOrEmpty(p))
            {
                s = s.OrderBy(x => x.VizeDate).Where(x => x.Plate.StartsWith(p));
                return View(s.ToList().ToPagedList(page, 50));
            }
            return View(v.ToList().ToPagedList(page, 50));
        }

        [Authorize(Roles = "A, ASG, Full, AG")]
        [HttpGet]
        public IActionResult NewVehicle()
        {
            List<SelectListItem> rent1 = new List<SelectListItem>();
            rent1.Add(new SelectListItem { Text = "Kiralık Değil", Value = "Kiralık Değil" });
            rent1.Add(new SelectListItem { Text = "Kiralık", Value = "Kiralık" });
            ViewBag.r1 = rent1;

            List<SelectListItem> rent2 = new List<SelectListItem>();
            rent2.Add(new SelectListItem { Text = "Kiralık Değil", Value = "Kiralık Değil" });
            rent2.Add(new SelectListItem { Text = "Fatura Gönderildi", Value = "Fatura Gönderildi" });
            rent2.Add(new SelectListItem { Text = "Fatura Gönderilmedi", Value = "Fatura Gönderilmedi" });
            ViewBag.r2 = rent2;

            var user = HttpContext.Request.Cookies["user"];
            List<SelectListItem> lu = new List<SelectListItem>();
            lu.Add(new SelectListItem { Text = user, Value = user });
            ViewBag.lu = lu;

            return View();
        }

        [HttpPost]
        public IActionResult NewVehicle(VehicleClass p)
        {
            if (!ModelState.IsValid)
                return View("NewVehicle");
            vehicleR.TAdd(p);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "A, ASG, Full, AG")]
        public IActionResult GetVehicle(int id)
        {
            List<SelectListItem> rent1 = new List<SelectListItem>();
            rent1.Add(new SelectListItem { Text = "Kiralık", Value = "Kiralık" });
            rent1.Add(new SelectListItem { Text = "Kiralık Değil", Value = "Kiralık Değil" });
            ViewBag.r1 = rent1;

            List<SelectListItem> rent2 = new List<SelectListItem>();
            rent2.Add(new SelectListItem { Text = "Fatura Gönderildi", Value = "Fatura Gönderildi" });
            rent2.Add(new SelectListItem { Text = "Fatura Gönderilmedi", Value = "Fatura Gönderilmedi" });
            rent2.Add(new SelectListItem { Text = "Kiralık Değil", Value = "Kiralık Değil" });
            ViewBag.r2 = rent2;

            var user = HttpContext.Request.Cookies["user"];
            List<SelectListItem> lu = new List<SelectListItem>();
            lu.Add(new SelectListItem { Text = user, Value = user });
            ViewBag.lu = lu;

            var x = vehicleR.TGet(id);
            VehicleClass vc = new VehicleClass()
            {
                Id = x.Id,
                Plate = x.Plate,
                VehicleBrand = x.VehicleBrand,
                VehicleModel = x.VehicleModel,
                VizeDate = x.VizeDate,
                Rent = x.Rent,
                RentInvoice = x.RentInvoice
            };
            return View(vc);
        }

        [HttpPost]
        public IActionResult UpdateVehicle(VehicleClass p)
        {
            var x = vehicleR.TGet(p.Id);
            x.Plate = p.Plate;
            x.VehicleBrand = p.VehicleBrand;
            x.VehicleModel = p.VehicleModel;
            x.VizeDate = p.VizeDate;
            x.Rent = p.Rent;
            x.RentInvoice = p.RentInvoice;
            x.LogUser = p.LogUser;
            vehicleR.TUpdate(x);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "A, ASG, Full, AG")]
        public IActionResult DeleteVehicle(VehicleClass p)
        {
            var user = HttpContext.Request.Cookies["user"];
            var x = vehicleR.TGet(p.Id);
            x.Deletes = true;
            x.LogUser = user;
            vehicleR.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult DetailVehicle(int id)
        {
            var diesel = c.DieselTable.Where(x => x.VehicleID == id).ToList();
            var shipping = c.ShippingTable.Where(x => x.VehicleID == id).Include("Person").ToList();
            var inds = c.IndustryTable.Where(x => x.VehicleID == id).ToList();

            var v = c.VehicleTable.Where(x => x.Id == id).Select(y => y.Plate).FirstOrDefault();
            ViewBag.ve = v;

            var x = new PersonClass
            {
                DieselC = diesel,
                ShippingC = shipping,
                IndustryC = inds
            };

            return View(x);
        }

        public IActionResult ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                List<VehicleClass> s = c.VehicleTable.Select(p => new VehicleClass
                {
                    Plate = p.Plate,
                    VehicleBrand = p.VehicleBrand,
                    VehicleModel = p.VehicleModel,
                    VizeDate = p.VizeDate,
                    Rent = p.Rent,
                    RentInvoice = p.RentInvoice,
                }).ToList();

                ExcelWorksheet ew = package.Workbook.Worksheets.Add("Report");

                ew.Cells["A1"].Value = "Plaka";
                ew.Cells["B1"].Value = "Markası";
                ew.Cells["C1"].Value = "Modeli";
                ew.Cells["D1"].Value = "Vize Tarihi";
                ew.Cells["E1"].Value = "Kiralık Durumu";
                ew.Cells["F1"].Value = "Kiralı Faturası";

                int rowStart = 1;
                foreach (var item in s)
                {
                    rowStart++;
                    ew.Cells[string.Format("A{0}", rowStart)].Value = item.Plate;
                    ew.Cells[string.Format("B{0}", rowStart)].Value = item.VehicleBrand;
                    ew.Cells[string.Format("C{0}", rowStart)].Value = item.VehicleModel;
                    ew.Cells[string.Format("D{0}", rowStart)].Value = string.Format("{0:dd.MM.yyyy}", item.VizeDate);
                    ew.Cells[string.Format("E{0}", rowStart)].Value = item.Rent;
                    ew.Cells[string.Format("F{0}", rowStart)].Value = item.RentInvoice;
                }

                ew.Cells["A:AZ"].AutoFitColumns();
                Response.Clear();
                var excelData = package.GetAsByteArray();
                var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                var fileName = "Araç.xlsx";
                return File(excelData, contentType, fileName);
            }
        }
    }
}
