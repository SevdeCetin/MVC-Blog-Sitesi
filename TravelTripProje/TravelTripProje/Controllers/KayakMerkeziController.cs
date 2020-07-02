using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class KayakMerkeziController : Controller
    {
        // GET: KayakMerkezi
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Kayaks.ToList();
            return View(deger);
        }
        public ActionResult KayakDetay(int id)
        {
            var bul = c.Kayaks.Where(x => x.ID == id).ToList();
            return View(bul);
        }
    }
}