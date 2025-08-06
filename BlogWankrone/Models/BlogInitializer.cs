using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogWankrone.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>
            {
                new Category { KategoriAdi = "C#" },
                new Category { KategoriAdi = "Asp.Net MVC" },
                new Category { KategoriAdi = "Asp.Net WebForm" },
                new Category { KategoriAdi = "Sağlık" }
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();


            List<Blog> bloglar = new List<Blog>
            {
                new Blog() { Baslik = "C# Nedir?", Aciklama = "C# programlama dili hakkında bilgi.", Icerik = "C# (C Sharp),", EklenmeTarihi = DateTime.Now, Anasayfa = false, Onay = false, Resim = "1.jpg", CategoryId = 1},
                new Blog() { Baslik = "C# Nedir?", Aciklama = "C# programlama dili hakkında bilgi.", Icerik = "C# (C Sharp),", EklenmeTarihi = DateTime.Now, Anasayfa = true, Onay = true, Resim = "2.jpg", CategoryId = 1},
                new Blog() { Baslik = "C# Nedir?", Aciklama = "C# programlama dili hakkında bilgi.", Icerik = "C# (C Sharp),", EklenmeTarihi = DateTime.Now, Anasayfa = false, Onay = true, Resim = "1.jpg", CategoryId = 2},
                new Blog() { Baslik = "C# Nedir?", Aciklama = "C# programlama dili hakkında bilgi.", Icerik = "C# (C Sharp),", EklenmeTarihi = DateTime.Now, Anasayfa = true, Onay = false, Resim = "2.jpg", CategoryId = 2},
                new Blog() { Baslik = "C# Nedir?", Aciklama = "C# programlama dili hakkında bilgi.", Icerik = "C# (C Sharp),", EklenmeTarihi = DateTime.Now, Anasayfa = true, Onay = true, Resim = "2.jpg", CategoryId = 2},
                new Blog() { Baslik = "C# Nedir?", Aciklama = "C# programlama dili hakkında bilgi.", Icerik = "C# (C Sharp),", EklenmeTarihi = DateTime.Now, Anasayfa = true, Onay = false, Resim = "1.jpg", CategoryId = 1},
                new Blog() { Baslik = "C# Nedir?", Aciklama = "C# programlama dili hakkında bilgi.", Icerik = "C# (C Sharp),", EklenmeTarihi = DateTime.Now, Anasayfa = false, Onay = true, Resim = "1.jpg", CategoryId = 3},
                new Blog() { Baslik = "C# Nedir?", Aciklama = "C# programlama dili hakkında bilgi.", Icerik = "C# (C Sharp),", EklenmeTarihi = DateTime.Now, Anasayfa = true, Onay = true, Resim = "2.jpg", CategoryId = 3}

            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();
        }


    }
}