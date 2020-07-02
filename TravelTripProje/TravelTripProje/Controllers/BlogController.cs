using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            by.Deger2 = c.yorumlars.Take(3).ToList();
            return View(by);
        }
        BlogYorum by = new BlogYorum();

        public ActionResult  BlogDetay(int id)
        {
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.yorumlars.Where(x=>x.Blogid==id).ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            ViewBag.ad = id;
            return View(by);
        }
        [HttpPost]
        public ActionResult YorumYaz(string Kad, string yorum, string mail, int id, string rating)
        {
            Yorumlar y = new Yorumlar();
             y.KullaniciAdi=Kad;
            y.Mail=mail;
             y.Blogid= id;
            y.Yorum = yorum;
            
            c.yorumlars.Add(y);
            c.SaveChanges();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.yorumlars.Where(x => x.Blogid == id).ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();

            ViewBag.star = rating;
            ViewBag.mail = mail;
            ViewBag.id = id;
            ViewBag.Kull = Kad;
            return View("BlogDetay",id);
        }
    }
}