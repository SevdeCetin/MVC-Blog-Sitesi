using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class MuzelerController : Controller
    {
        // GET: Muzeler
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Muzelers.ToList();
            return View(deger);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.OrderByDescending(x => x.ID).Take(5).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.yorumlars.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {

            var deger = c.yorumlars.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(deger);
        }

        public ActionResult MuzeDetay(int id)
        {
            var deger = c.Muzelers.Where(x => x.ID == id).ToList();
            return View(deger);
        }
    }
}