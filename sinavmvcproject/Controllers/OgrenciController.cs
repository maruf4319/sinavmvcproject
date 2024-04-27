using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sinavmvcproject.Models.Entity;

namespace sinavmvcproject.Controllers
{
    public class OgrenciController : Controller
    {
        mvcprojectEntities db = new mvcprojectEntities();
        // GET: Ogrenci
        public ActionResult Index()
        {
            var ogrenciler = db.ogrenci.ToList();
            return View(ogrenciler);
        }
        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniOgrenci(ogrenci p3)
        {
            db.ogrenci.Add(p3);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OgrenciGuncelle(int id)
        {
            var ogrenci = db.ogrenci.Find(id);

            return View("OgrenciGuncelle", ogrenci);
        }
        public ActionResult Guncelle(ogrenci p)
        {
            var ogr = db.ogrenci.Find(p.ogid);
            ogr.ogad = p.ogad;
            ogr.ogsoyad = p.ogsoyad;
            ogr.ogbolum = p.ogbolum;
            ogr.ogkredi = p.ogkredi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var ogr = db.ogrenci.Find(id);
            db.ogrenci.Remove(ogr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}