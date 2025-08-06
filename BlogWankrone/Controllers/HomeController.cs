using BlogWankrone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWankrone.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        public ActionResult Index()
        {
            var bloglar = context.Bloglar
                    .Where(i => i.Onay == true && i.Anasayfa == true)
                    .Select(i => new BlogModel
                    {
                        Id = i.Id,
                        Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                        Aciklama = i.Aciklama.Length > 200 ? i.Aciklama.Substring(0, 200) + "..." : i.Aciklama,
                        EklenmeTarihi = i.EklenmeTarihi,
                        Onay = i.Onay,
                        Anasayfa = i.Anasayfa,
                        Resim = i.Resim,
                    });

            return View(bloglar.ToList());
        }

    }
}