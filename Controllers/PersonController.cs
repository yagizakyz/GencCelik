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
    public class PersonController : Controller
    {
        PersonRepository personR = new PersonRepository();
        Context c = new Context();
        public IActionResult Index(string p, string surname, int page = 1)
        {
            var s = from x in c.PersonTable select x;
            if (!string.IsNullOrEmpty(p) || !string.IsNullOrEmpty(surname))
                s = s.Where(x => x.PName.StartsWith(p) || x.PSurname.StartsWith(surname));
            return View(s.Include("Job").ToList().ToPagedList(page, 50));
        }

        [Authorize(Roles = "Full")]
        [HttpGet]
        public IActionResult NewPerson()
        {
            List<SelectListItem> p1 = new List<SelectListItem>();
            p1.Add(new SelectListItem { Text = "Hazırlanmadı", Value = Convert.ToString(false) });
            p1.Add(new SelectListItem { Text = "Hazırlandı", Value = Convert.ToString(true) });
            ViewBag.p1 = p1;

            List<SelectListItem> p2 = new List<SelectListItem>();
            p2.Add(new SelectListItem { Text = "Kullanmadı", Value = Convert.ToString(false) });
            p2.Add(new SelectListItem { Text = "Kullandı", Value = Convert.ToString(true) });
            ViewBag.p2 = p2;

            List<SelectListItem> roles = new List<SelectListItem>();
            roles.Add(new SelectListItem { Text = "Yetkisiz", Value = "YKS" });
            roles.Add(new SelectListItem { Text = "Araç", Value = "A" });
            roles.Add(new SelectListItem { Text = "Sevkiyat", Value = "S" });
            roles.Add(new SelectListItem { Text = "Gider", Value = "G" });
            roles.Add(new SelectListItem { Text = "Araç - Gider", Value = "AG" });
            roles.Add(new SelectListItem { Text = "Sevkiyat - Gider", Value = "SG" });
            roles.Add(new SelectListItem { Text = "Araç - Sevkiyat - Gider", Value = "ASG" });
            roles.Add(new SelectListItem { Text = "Full", Value = "Full" });
            ViewBag.roles = roles;

            List<SelectListItem> values = (from x in c.JobTable.Where(x => x.JName != "PATRON").ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.JName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.per = values;
            ViewBag.dt = Convert.ToString(DateTime.Now.ToShortDateString());

            List<SelectListItem> ldt = new List<SelectListItem>();
            ldt.Add(new SelectListItem { Text = "01.01.2000", Value = "01.01.2000" });
            ViewBag.ldt = ldt;

            var user = HttpContext.Request.Cookies["user"];
            List<SelectListItem> lu = new List<SelectListItem>();
            lu.Add(new SelectListItem { Text = user, Value = user });
            ViewBag.lu = lu;
            return View();
        }

        [HttpPost]
        public IActionResult NewPerson(PersonClass p)
        {
            if (!ModelState.IsValid)
                return View("NewPerson");
            personR.TAdd(p);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Full")]
        public IActionResult GetPerson(int id)
        {
            List<SelectListItem> p1 = new List<SelectListItem>();
            p1.Add(new SelectListItem { Text = "Hazırlanmadı", Value = Convert.ToString(false) });
            p1.Add(new SelectListItem { Text = "Hazırlandı", Value = Convert.ToString(true) });
            ViewBag.p1 = p1;

            List<SelectListItem> p2 = new List<SelectListItem>();
            p2.Add(new SelectListItem { Text = "Kullanmadı", Value = Convert.ToString(false) });
            p2.Add(new SelectListItem { Text = "Kullandı", Value = Convert.ToString(true) });
            ViewBag.p2 = p2;

            List<SelectListItem> values = (from x in c.JobTable.Where(x => x.JName != "PATRON").ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.JName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.per = values;
            var user = HttpContext.Request.Cookies["user"];
            List<SelectListItem> lu = new List<SelectListItem>();
            lu.Add(new SelectListItem { Text = user, Value = user });
            ViewBag.lu = lu;

            var p = personR.TGet(id);
            PersonClass pers = new PersonClass
            {
                Id = p.Id,
                PName = p.PName,
                PSurname = p.PSurname,
                Nickname = p.Nickname,
                Password = p.Password,
                StartDateOfWork = p.StartDateOfWork,
                DismissalDate = p.DismissalDate,
                Safety = p.Safety,
                Ozlük = p.Ozlük,
                AnnualPermit = p.AnnualPermit,
                JobID = p.JobID
            };
            return View(pers);
        }

        [HttpPost]
        public IActionResult UpdatePerson(PersonClass p)
        {
            var x = personR.TGet(p.Id);
            x.Id = p.Id;
            x.PName = p.PName;
            x.PSurname = p.PSurname;
            x.Nickname = p.Nickname;
            x.Password = p.Password;
            x.StartDateOfWork = p.StartDateOfWork;
            x.DismissalDate = p.DismissalDate;
            x.Safety = p.Safety;
            x.Ozlük = p.Ozlük;
            x.AnnualPermit = p.AnnualPermit;
            x.JobID = p.JobID;
            x.LogUser = p.LogUser;
            personR.TUpdate(x);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Full")]
        public IActionResult DeletePerson(PersonClass p)
        {
            var user = HttpContext.Request.Cookies["user"];
            var x = personR.TGet(p.Id);
            x.Deletes = true;
            x.LogUser = user;
            personR.TUpdate(x);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Full")]
        public IActionResult DetailPerson(int id)
        {
            var shipping = c.ShippingTable.Where(x => x.PersonID == id).Include("Vehicle").ToList();

            var x = new PersonClass
            {
                ShippingC = shipping
            };

            var n = c.PersonTable.Where(x => x.Id == id).Select(y => y.PName + " " + y.PSurname).FirstOrDefault();
            ViewBag.nm = n;

            return View(x);
        }

        public IActionResult ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                List<PersonClass> s = c.PersonTable.Select(p => new PersonClass
                {
                    PName = p.PName,
                    PSurname = p.PSurname,
                    Job = p.Job,
                    StartDateOfWork = p.StartDateOfWork,
                    DismissalDate = p.DismissalDate,
                    Safety = p.Safety,
                    Ozlük = p.Ozlük,
                    AnnualPermit = p.AnnualPermit
                }).ToList();

                ExcelWorksheet ew = package.Workbook.Worksheets.Add("Report");

                ew.Cells["A1"].Value = "Personel Adı";
                ew.Cells["B1"].Value = "Personel Soyadı";
                ew.Cells["C1"].Value = "İşi";
                ew.Cells["D1"].Value = "İşe Başladığı Tarih";
                ew.Cells["E1"].Value = "İşten Çıkış Tarihi";
                ew.Cells["F1"].Value = "İş Güvenliği Belgesi";
                ew.Cells["G1"].Value = "Özlük Belgesi";
                ew.Cells["H1"].Value = "Yıllık İzin Aldımı";

                int rowStart = 1;
                foreach (var item in s)
                {
                    rowStart++;
                    ew.Cells[string.Format("A{0}", rowStart)].Value = item.PName;
                    ew.Cells[string.Format("B{0}", rowStart)].Value = item.PSurname;
                    ew.Cells[string.Format("C{0}", rowStart)].Value = item.Job.JName;
                    ew.Cells[string.Format("D{0}", rowStart)].Value = string.Format("{0:dd.MM.yyyy}", item.StartDateOfWork);
                    ew.Cells[string.Format("E{0}", rowStart)].Value = string.Format("{0:dd.MM.yyyy}", item.DismissalDate);
                    ew.Cells[string.Format("F{0}", rowStart)].Value = item.Safety;
                    ew.Cells[string.Format("G{0}", rowStart)].Value = item.Ozlük;
                    ew.Cells[string.Format("H{0}", rowStart)].Value = item.AnnualPermit;
                }

                ew.Cells["A:AZ"].AutoFitColumns();
                Response.Clear();
                var excelData = package.GetAsByteArray();
                var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                var fileName = "Personel.xlsx";
                return File(excelData, contentType, fileName);
            }
        }
    }
}
