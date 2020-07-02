using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class LunaparkController : Controller
    {
        // GET: Lunapark
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Lunaparklars.ToList();
            return View(deger);
        }
        public ActionResult LunaparkDetay(int id)
        {
            var bul = c.Lunaparklars.Where(x => x.ID == id).ToList();
            return View(bul);
        }
    }
}