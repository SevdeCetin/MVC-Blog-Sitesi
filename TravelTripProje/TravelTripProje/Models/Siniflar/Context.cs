using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    public class Context : DbContext //DbContext sınıfından miras aldı
    {
        public DbSet<Admin> Admins { get; set; } //<> içerisine alacağımız sınıfı yazıyoruz
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> yorumlars { get; set; }
        public DbSet<yorum> yorums{ get; set; }
        public DbSet<Muzeler> Muzelers { get; set; }
        public DbSet<Myorum> Myorums { get; set; }
        public DbSet<Oteller> Otellers { get; set; }
        public DbSet<Restorantlar> Restorantlars { get; set; }
        public DbSet<Lunaparklar> Lunaparklars { get; set; }
        public DbSet<Kayak> Kayaks { get; set; }
    }
}