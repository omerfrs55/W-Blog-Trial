using System;
using System.Data.Entity.Infrastructure;
using System.Web;

namespace BlogWankrone.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
        public string Icerik { get; set; }
        public DateTime EklenmeTarihi { get; set; }

        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
