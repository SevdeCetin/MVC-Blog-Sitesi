using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        Context c = new Context();
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult YeniMesaj()
        {
            return View("Index");
        }
        [HttpPost]
        public ActionResult YeniMesaj(iletisim i)
        {

            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            c.iletisims.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
    
}