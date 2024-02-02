using Microsoft.AspNetCore.Mvc;
using SaglikProje.Models;
using System;
using System.Linq;

namespace SaglikProje.Controllers
{
    public class HomeController : Controller
    {
        SaglikProjesiContext _db = new SaglikProjesiContext();

        public HomeController(SaglikProjesiContext db)
        {
            _db = db;
        }
        public IActionResult Anasayfa()
        {
            return View();
        }
        public IActionResult TumHastaliklar()
        {
            return View();
        }
        public IActionResult HastalikGoster(string belirti)
        {
            var belirtiss = _db.Belirtis.Where(x => x.Belirtiler == belirti).FirstOrDefault();
            return View(belirtiss);
        }
        public IActionResult VKIHesapla()
        {
            return View();
        }
        //#################################################################################################################
        //BELİRTİ EKLEME ALANI 

        public IActionResult BelirtiEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BelirtiEkle(Belirti ekle)
        {
            _db.Belirtis.Add(ekle);
            _db.SaveChanges();
            return View();
        }
    }
}
