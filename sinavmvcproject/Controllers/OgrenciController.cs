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
    }
}