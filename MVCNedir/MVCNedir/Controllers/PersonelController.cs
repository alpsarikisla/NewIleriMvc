using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCNedir.Models;

namespace MVCNedir.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult Index()
        {
            List<Personel> personeller = new List<Personel>();
            personeller.Add(new Personel() { ID= 1, Isim="Ogün", Soyad="Güngör"});
            personeller.Add(new Personel() { ID= 2, Isim = "Göksel", Soyad = "Doğan" });
            personeller.Add(new Personel() { ID= 3, Isim = "Doğukan", Soyad = "Kıraslan" });
            ViewBag.title = "Personel Listesi";
            return View(personeller);
        }

        [HttpGet]
        public ActionResult Kaydet()
        {
            //ViewBag.veri = "Selam Dostlar";
            return View();
        }

        [HttpPost]
        public ActionResult Kaydet(Personel p)
        {
            return View();
        }
    }
}