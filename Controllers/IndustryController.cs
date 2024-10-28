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
    public class IndustryController : Controller
    {
        IndustryRepository industryR = new IndustryRepository();
        Context c = new Context();
        public IActionResult Index(string p, int page = 1)
        {
            var s = from x in c.IndustryTable select x;
            if (!string.IsNullOrEmpty(p))
                s = s.Where(x => x.Vehicle.Plate.StartsWith(p));
            return View(s.Include("Vehicle").ToList().ToPagedList(page, 50));
        }

        [Authorize(Roles = "Full, G, SG, ASG, AG")]
        [HttpGet]
        public IActionResult NewIndustry()
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
        public IActionResult NewIndustry(IndustryClass p)
        {
            if (!ModelState.IsValid)
                return View("NewDiesel");
            industryR.TAdd(p);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Full, G, SG, ASG, AG")]
        public IActionResult GetIndustry(int id)
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

            var p = industryR.TGet(id);
            IndustryClass ind = new IndustryClass
            {
                Id = p.Id,
                VehicleID = p.VehicleID,
                Expense = p.Expense,
                Description = p.Description,
                Date = p.Date
            };
            return View(ind);
        }

        [HttpPost]
        public IActionResult UpdateIndustry(IndustryClass p)
        {
            var x = industryR.TGet(p.Id);
            x.Id = p.Id;
            x.VehicleID = p.VehicleID;
            x.Expense = p.Expense;
            x.Description = p.Description;
            x.Date = p.Date;
            x.LogUser = p.LogUser;
            industryR.TUpdate(x);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Full, G, SG, ASG, AG")]
        public IActionResult DeleteIndustry(IndustryClass p)
        {
            var x = industryR.TGet(p.Id);
            industryR.TDelete(x);
            return RedirectToAction("Index");
        }

        public IActionResult ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                List<IndustryClass> s = c.IndustryTable.Select(p => new IndustryClass
                {
                    Vehicle = p.Vehicle,
                    Expense = p.Expense,
                    Description = p.Description,
                    Date = p.Date
                }).ToList();

                ExcelWorksheet ew = package.Workbook.Worksheets.Add("Report");

                ew.Cells["A1"].Value = "Plaka";
                ew.Cells["B1"].Value = "Tutar";
                ew.Cells["C1"].Value = "Açıklama";
                ew.Cells["D1"].Value = "Tarih";

                int rowStart = 1;
                foreach (var item in s)
                {
                    rowStart++;
                    ew.Cells[string.Format("A{0}", rowStart)].Value = item.Vehicle.Plate;
                    ew.Cells[string.Format("B{0}", rowStart)].Value = item.Expense;
                    ew.Cells[string.Format("C{0}", rowStart)].Value = item.Description;
                    ew.Cells[string.Format("D{0}", rowStart)].Value = string.Format("{0:dd.MM.yyyy}", item.Date);
                }

                ew.Cells["A:AZ"].AutoFitColumns();
                Response.Clear();
                var excelData = package.GetAsByteArray();
                var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                var fileName = "Sanayi.xlsx";
                return File(excelData, contentType, fileName);
            }
        }
    }
}
