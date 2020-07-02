using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View("YeniBlog");
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog o)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniBlog");
            }

            c.Blogs.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var bl = c.Blogs.Find(id);
            c.Blogs.Remove(bl);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var x = c.Blogs.Find(id);
            return View("BlogGetir", x);
        }

        public ActionResult BlogGuncelle(Blog o)
        {
            var otel = c.Blogs.Find(o.ID);
            otel.Baslik = o.Baslik;
            otel.Tarih = o.Tarih;
            otel.Aciklama = o.Aciklama;
            otel.BlogImage = o.BlogImage;
            otel.Konum = o.Konum;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogDetay(int id)
        {
            var x = c.Blogs.Find(id);
            return View("BlogDetay", x);
          
        }

        //-----------------------------------------OTELLER-------------------------------------------------
        public ActionResult Oteller()
        {
            var deger = c.Otellers.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniOtel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniOtel(Oteller o)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniOtel");
            }

            c.Otellers.Add(o);
            c.SaveChanges();
            return RedirectToAction("Oteller");
        }
        public ActionResult OtelSil(int id)
        {
            var otel = c.Otellers.Find(id);
            c.Otellers.Remove(otel);
            c.SaveChanges();
            return RedirectToAction("Oteller");
        }
        public  ActionResult OtelGetir(int id)
        {
            var x = c.Otellers.Find(id);
            return View("OtelGetir",x);
        }
        
        public ActionResult OtelGuncelle(Oteller o)
        {
            var otel = c.Otellers.Find(o.ID);
            otel.Baslik = o.Baslik;
            otel.Tarih = o.Tarih;
            otel.Aciklama = o.Aciklama;
            otel.OtelImage = o.OtelImage;
            otel.Konum = o.Konum;
            c.SaveChanges();
            return RedirectToAction("Oteller");
        }
        
        //-----------------------------------------RESTORANLAR-------------------------------------------------
        public ActionResult Restorantlar()
        {
            var deger = c.Restorantlars.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniRestoran()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniRestoran(Restorantlar r)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniRestoran");
            }

            c.Restorantlars.Add(r);
            c.SaveChanges();
            return RedirectToAction("Restorantlar");
        }
        public ActionResult RestoranSil(int id)
        {
            var res = c.Restorantlars.Find(id);
            c.Restorantlars.Remove(res);
            c.SaveChanges();
            return RedirectToAction("Restorantlar");
        }
        public ActionResult RestoranGetir(int id)
        {
            var getir = c.Restorantlars.Find(id);
            return View("RestoranGetir",getir);
        }
        public ActionResult RestoranGuncelle(Restorantlar r)
        {
            var res = c.Restorantlars.Find(r.ID);
            res.Baslik = r.Baslik;
            res.Tarih = r.Tarih;
            res.Aciklama = r.Aciklama;
            res.RestorantImage = r.RestorantImage;
            res.Konum = r.Konum;
            c.SaveChanges();
            return RedirectToAction("Restorantlar");
        }
        //-----------------------------------------MÜZELER-----------------------------------------------------
        public ActionResult Muzeler()
        {
            var deger = c.Muzelers.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniMuze()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMuze(Muzeler m)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMuze");
            }

            c.Muzelers.Add(m);
            c.SaveChanges();
            return RedirectToAction("Muzeler");
        }
        public ActionResult MuzeSil(int id)
        {
            var muz = c.Muzelers.Find(id);
            c.Muzelers.Remove(muz);
            c.SaveChanges();
            return RedirectToAction("Restorantlar");
        }
        public ActionResult MuzeGetir(int id)
        {
            var getir = c.Muzelers.Find(id);
            return View("MuzeGetir", getir);
        }
        public ActionResult MuzeGuncelle(Muzeler m)
        {
            var res = c.Muzelers.Find(m.ID);
            res.Baslik = m.Baslik;
            res.Tarih = m.Tarih;
            res.Aciklama = m.Aciklama;
            res.MuzeImage = m.MuzeImage;
            res.Konum = m.Konum;
            c.SaveChanges();
            return RedirectToAction("Muzeler");
        }


        //-----------------------------------------LUNAPARKLAR-------------------------------------------------
        public ActionResult Lunaparklar()
        {
            var deger = c.Lunaparklars.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniLunapark()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniLunapark(Lunaparklar L)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniLunapark");
            }

            c.Lunaparklars.Add(L);
            c.SaveChanges();
            return RedirectToAction("Lunaparklar");
        }
        public ActionResult LunaparkSil(int id)
        {
            var park = c.Lunaparklars.Find(id);
            c.Lunaparklars.Remove(park);
            c.SaveChanges();
            return RedirectToAction("Lunaparklar");
        }
        public ActionResult LunaparkGetir(int id)
        {
            var getir = c.Lunaparklars.Find(id);
            return View("LunaparkGetir", getir);
        }
        public ActionResult ParkGuncelle(Lunaparklar m)
        {
            var res = c.Lunaparklars.Find(m.ID);
            res.Baslik = m.Baslik;
            res.Tarih = m.Tarih;
            res.Aciklama = m.Aciklama;
            res.ParkImage = m.ParkImage;
            res.Konum = m.Konum;
            c.SaveChanges();
            return RedirectToAction("Lunaparklar");
        }

        //-----------------------------------------KAYAK MERKEZLERİ--------------------------------------------
        public ActionResult Kayak()
        {
            var deger = c.Kayaks.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniKayak()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKayak(Kayak k)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKayak");
            }

            c.Kayaks.Add(k);
            c.SaveChanges();
            return RedirectToAction("Kayak");
        }
        public ActionResult KayakSil(int id)
        {
            var kay = c.Kayaks.Find(id);
            c.Kayaks.Remove(kay);
            c.SaveChanges();
            return RedirectToAction("Kayak");
        }
        public ActionResult KayakGetir(int id)
        {
            var getir = c.Kayaks.Find(id);
            return View("KayakGetir", getir);
        }
        public ActionResult KayakGuncelle(Kayak m)
        {
            var res = c.Kayaks.Find(m.ID);
            res.Baslik = m.Baslik;
            res.Tarih = m.Tarih;
            res.Aciklama = m.Aciklama;
            res.KayakImage = m.KayakImage;
            res.Konum = m.Konum;
            c.SaveChanges();
            return RedirectToAction("Kayak");
        }
        //-----------------------------------------YORUMLAR--------------------------------------------
        public ActionResult Yorumlar()
        {
            var deger = c.yorumlars.ToList();
            return View(deger);
        }
        public ActionResult YorumSil(int id)
        {
            var yor = c.yorumlars.Find(id);
            c.yorumlars.Remove(yor);
            c.SaveChanges();
            return RedirectToAction("Yorumlar");
        }
        public ActionResult YorumGetir(int id)
        {
            var getir = c.yorumlars.Find(id);
            return View("YorumGetir", getir);
        }
        public ActionResult YorumGuncelle(Yorumlar m)
        {
            var yor = c.yorumlars.Find(m.ID);
            yor.KullaniciAdi = m.KullaniciAdi;
            yor.Mail = m.Mail;
            yor.Yorum = m.Yorum;
            yor.Blogid = m.Blogid;
            c.SaveChanges();
            return RedirectToAction("Yorumlar");
        }
        //-----------------------------------------İLETİŞİM------------------------------------

         public ActionResult iletisim()
        {
            var deger = c.iletisims.ToList();
            return View(deger);
        }
        public ActionResult MesajSil(int id)
        {
            var yor = c.iletisims.Find(id);
            c.iletisims.Remove(yor);
            c.SaveChanges();
            return RedirectToAction("iletisim");
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------
        public ActionResult Yorum()
        {
            var deger = c.yorums.ToList();
            

            return View(deger);
        }
        
        [HttpGet]
        public ActionResult YeniYorum()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYorum(yorum y)
        {

            if (!ModelState.IsValid)
            {
                return View("YeniYorum");
            }

            c.yorums.Add(y);
            c.SaveChanges();
            return RedirectToAction("Yorum");
        }
        public ActionResult DYorumGetir(int id)
        {
            var getir = c.yorums.Find(id);
            return View("DYorumGetir", getir);
        }
        public ActionResult DYorumGuncelle(yorum m)
        {
            var yor = c.yorums.Find(m.ID);
            yor.KullaniciAdi = m.KullaniciAdi;
            yor.Mail = m.Mail;
            yor.Yorum = m.Yorum;
            yor.star = m.star;
            c.SaveChanges();
            return RedirectToAction("Yorum");
        }



    }
}