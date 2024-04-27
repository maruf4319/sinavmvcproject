using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sinavmvcproject.Models.Entity;

namespace sinavmvcproject.Controllers
{
    public class AkademikController : Controller
    {
        mvcprojectEntities db = new mvcprojectEntities();
        // GET: Akademik
        public ActionResult Index()
        {
            var akd = db.akademikp.ToList();
            return View(akd);
        }
        [HttpGet]
        public ActionResult NewPersonel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewPersonel(akademikp p3)
        {
            db.akademikp.Add(p3);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PersonelGuncelle(int id)
        {
            var akd = db.akademikp.Find(id);

            return View("PersonelGuncelle", akd);
        }
        public ActionResult Guncelle(akademikp p)
        {
            var akd = db.akademikp.Find(p.id);
            akd.isim = p.isim;
            akd.soyisim = p.soyisim;
            akd.kadı = p.kadı;
            akd.sifre = p.sifre;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var akd = db.akademikp.Find(id);
            db.akademikp.Remove(akd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}