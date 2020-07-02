using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class OtellerController : Controller
    {
        // GET: Oteller
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Otellers.ToList();
            return View(deger);
        }
        public ActionResult OtelDetay(int id)
        {
            var deger = c.Otellers.Where(x => x.ID == id).ToList();
            ViewBag.iki = "2";
            ViewBag.bir = "1";
  
            return View(deger);
        }
        public PartialViewResult Partial1()
        {
            var deger = c.Otellers.ToList();
            return PartialView(deger);
        }
    }
}