using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_api.Models;
using web_api2.Models;

namespace web_api2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpGet]
        public ActionResult DavetiyeFormu()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpPost]
        public ActionResult DavetiyeFormu(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabanı.Add(model);
                return View("Thanks", model);
            }
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult Katilanlar()
        {
            var katilanlar = Veritabanı.Liste.Where(i => i.KatılmaDurumu == true);
            return PartialView(katilanlar);
        }
    }
}