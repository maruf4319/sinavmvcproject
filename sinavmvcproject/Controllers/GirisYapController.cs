using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sinavmvcproject.Models.Entity;

namespace sinavmvcproject.Controllers
{
    public class GirisYapController : Controller
    {
        mvcprojectEntities db = new mvcprojectEntities();
        // GET: GirisYap
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(admin t)
        {
            var bilgiler = db.admin.FirstOrDefault(x => x.kadı == t.kadı && x.şifre == t.şifre);
            if (bilgiler != null)
            {
                return RedirectToAction("Index", "Ogrenci");
            }
            else
            {
                return View();
            }
        }
    }
}