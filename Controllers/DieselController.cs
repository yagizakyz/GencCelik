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
    public class DieselController : Controller
    {
        DieselRepository dieselR = new DieselRepository();
        Context c = new Context();
        public IActionResult Index(string p, int page = 1)
        {
            var s = from x in c.DieselTable select x;
            if (!string.IsNullOrEmpty(p))
                s = s.Where(x => x.Vehicle.Plate.StartsWith(p));
            return View(s.Include("Vehicle").ToList().ToPagedList(page, 50));
        }

        [Authorize(Roles = "Full, G, SG, ASG, AG")]
        [HttpGet]
        public IActionResult NewDiesel()
        {
            List<SelectListItem> vec = (from x in c.VehicleTable.Where(x => x.Deletes == false).ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Plate,
                                            Value = x.Id.ToString()
                                        }).ToList();
            ViewBag.vec = vec;

            var user = HttpContext.Request.Cookies["user"];
            List<SelectListItem> lu = new List<SelectListItem>();
            lu.Add(new SelectListItem { Text = user, Value = user });
            ViewBag.lu = lu;
            return View();
        }

        [HttpPost]
        public IActionResult NewDiesel(DieselClass p)
        {
            if (!ModelState.IsValid)
                return View("NewDiesel");
            dieselR.TAdd(p);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Full, G, SG, ASG, AG")]
        public IActionResult GetDiesel(int id)
        {
            List<SelectListItem> vec = (from x in c.VehicleTable.Where(x => x.Deletes == false).ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Plate,
                                            Value = x.Id.ToString()
                                        }).ToList();
            ViewBag.vec = vec;
            var user = HttpContext.Request.Cookies["user"];
            List<SelectListItem> lu = new List<SelectListItem>();
            lu.Add(new SelectListItem { Text = user, Value = user });
            ViewBag.lu = lu;

            var p = dieselR.TGet(id);
            DieselClass die = new DieselClass
            {
                Id = p.Id,
                VehicleID = p.VehicleID,
                Liter = p.Liter,
                Km = p.Km,
                Expense = p.Expense,
                Date = p.Date
            };
            return View(die);
        }

        [HttpPost]
        public IActionResult UpdateDiesel(DieselClass p)
        {
            var x = dieselR.TGet(p.Id);
            x.Id = p.Id;
            x.VehicleID = p.VehicleID;
            x.Liter = p.Liter;
            x.Km = p.Km;
            x.Expense = p.Expense;
            x.Date = p.Date;
            x.LogUser = p.LogUser;
            dieselR.TUpdate(x);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Full, G, SG, ASG, AG")]
        public IActionResult DeleteDiesel(DieselClass p)
        {
            var x = dieselR.TGet(p.Id);
            dieselR.TDelete(x);
            return RedirectToAction("Index");
        }

        public IActionResult ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                List<DieselClass> s = c.DieselTable.Select(p => new DieselClass
                {
                    Vehicle = p.Vehicle,
                    Liter = p.Liter,
                    Km = p.Km,
                    Expense = p.Expense,
                    Date = p.Date
                }).ToList();

                ExcelWorksheet ew = package.Workbook.Worksheets.Add("Report");

                ew.Cells["A1"].Value = "Plaka";
                ew.Cells["B1"].Value = "Alınan Yakıt";
                ew.Cells["C1"].Value = "Km";
                ew.Cells["D1"].Value = "Tutar";
                ew.Cells["E1"].Value = "Tarih";

                int rowStart = 1;
                foreach (var item in s)
                {
                    rowStart++;
                    ew.Cells[string.Format("A{0}", rowStart)].Value = item.Vehicle.Plate;
                    ew.Cells[string.Format("B{0}", rowStart)].Value = item.Liter;
                    ew.Cells[string.Format("C{0}", rowStart)].Value = item.Km;
                    ew.Cells[string.Format("D{0}", rowStart)].Value = item.Expense;
                    ew.Cells[string.Format("E{0}", rowStart)].Value = string.Format("{0:dd.MM.yyyy}", item.Date);
                }

                ew.Cells["A:AZ"].AutoFitColumns();
                Response.Clear();
                var excelData = package.GetAsByteArray();
                var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                var fileName = "Mazot.xlsx";
                return File(excelData, contentType, fileName);
            }
        }
    }
}
