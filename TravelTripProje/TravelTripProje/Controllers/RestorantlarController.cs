using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class RestorantlarController : Controller
    {
        // GET: Restorantlar
        Context c = new Context();

        public ActionResult Index()
        {
            var deger = c.Restorantlars.ToList();
            return View(deger);
        }

        public ActionResult RestorantDetay(int id)
        {
            var deger = c.Restorantlars.Where(x => x.ID == id).ToList();
            return View(deger);
        }
        public PartialViewResult Partial1()
        {
            var deger = c.Restorantlars.ToList();
            return PartialView(deger);
        }
    }
}