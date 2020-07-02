using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; } // Blog tablosunu kullanarak değer1 isminde koleksiyon formatında  bir property oluşturarak
        public IEnumerable<Yorumlar> Deger2 { get; set; } //IEnumarable aracılığı ile bir view içerisinde birden fazla tablo çekebiliyoruz
        public IEnumerable<Blog> Deger3 { get; set; }  // Deger1 ile aynı fakat bu kısımda son blogları listelemek için kullanılacak 
        public IEnumerable<Yorumlar> Deger4 { get; set; }
    }
}