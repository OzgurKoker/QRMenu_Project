using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Proje.Models;
using Proje.Models.Entities;
using System.Collections.Generic;
using System.Data.Common;

namespace Proje.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ProjeContext db = new ProjeContext();

        public IActionResult ContactForm()
        {
            var model = new IndexViewModel()
            {
                ContactForms = db.ContactForms.ToList(),

            };
            return View(model);
        }
        public IActionResult Titles(int id)
        {
            var title = db.Titles.FirstOrDefault(x => x.Id == id);
            return View(title);
        }

        [HttpPost]
        public IActionResult Titles(Title p)
        {
            var title = db.Titles.FirstOrDefault(x => x.Id == p.Id);

            title.SpecialsBaslik = p.SpecialsBaslik;
            title.SpecialsAciklama = p.SpecialsAciklama;
            title.WhyUsAciklama = p.WhyUsAciklama;
            title.ChefsAciklama = p.ChefsAciklama;
            title.ChefsBaslik = p.ChefsBaslik;
            title.WhyUsBaslik = p.WhyUsBaslik;
            title.BooktableAciklama = p.BooktableAciklama;
            title.BooktableBaslik = p.BooktableBaslik;
            title.ContactAciklama = p.ContactAciklama;
            title.ContactBaslik = p.ContactBaslik;
            title.GalleryAciklama = p.GalleryAciklama;
            title.GalleryBaslik = p.GalleryBaslik;
            title.EventsBaslik = p.EventsBaslik;
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(title);
            db.SaveChanges();
            //TempData["mesaj"] = "Başarıyla Güncellendi";
            return RedirectToAction("Titles");
        }

        public IActionResult Hero()
        {
            var model = new IndexViewModel()
            {
                Sliders = db.Sliders.ToList(),

            };
            return View(model);
        }

        public IActionResult HeroEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HeroEkle(Slider p, IFormFile Foto)
        {
            Slider s = new Slider()
            {
                Baslik = p.Baslik,
                Id = p.Id,
                Aciklama = p.Aciklama,
                Image = p.Image
            };

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\slide", fileName)))
                {
                    Foto?.CopyTo(fs);
                }
                s.Image = fileName;
            }

            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Add(s);
            db.SaveChanges();


            return RedirectToAction("Hero");
        }

        public IActionResult HeroDuzenle(int id)
        {

            Slider s = db.Sliders.FirstOrDefault(x => x.Id == id);


            return View(s);

        }
        [HttpPost]
        public IActionResult HeroDuzenle(Slider p, IFormFile Foto)
        {

            var _s = db.Sliders.FirstOrDefault(x => x.Id == p.Id);
            _s.Baslik = p.Baslik;
            _s.Aciklama = p.Aciklama;


            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\slide", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                _s.Image = fileName;
            }
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(_s);
            db.SaveChanges();

            return RedirectToAction("Hero");

        }

        public IActionResult HeroSil(int id)
        {
            Slider s = db.Sliders.FirstOrDefault(x => x.Id == id);


            return View(s);


        }
        [HttpPost]
        public IActionResult HeroSil(Slider p)
        {
            Slider s = db.Sliders.FirstOrDefault(x => x.Id == p.Id);
            db.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Hero");
        }

        public IActionResult About(int id)
        {
            About a = db.Abouts.FirstOrDefault(x => x.Id == id);
            return View(a);
        }
        [HttpPost]
        public IActionResult About(About p, IFormFile Foto)
        {
            var a = db.Abouts.FirstOrDefault(x => x.Id == p.Id);

            a.YoutubeLink = p.YoutubeLink;
            a.Aciklama1 = p.Aciklama1;
            a.Aciklama2 = p.Aciklama2;
            a.Aciklama3 = p.Aciklama3;
            a.Madde1 = p.Madde1;
            a.Madde2 = p.Madde2;
            a.Madde3 = p.Madde3;
            a.Baslik = p.Baslik;

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                a.Image = fileName;
            }
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(a);
            db.SaveChanges();

            return RedirectToAction("About");
        }
        public IActionResult WhyUs()
        {
            var model = new IndexViewModel()
            {
                WhyUs = db.WhyUs.ToList(),

            };
            return View(model);

        }


        public IActionResult WhyUsDuzenle(int id)
        {
            WhyU s = db.WhyUs.FirstOrDefault(x => x.Id == id);
            return View(s);

        }
        [HttpPost]
        public IActionResult WhyUsDuzenle(WhyU p)
        {
            WhyU s = db.WhyUs.FirstOrDefault(x => x.Id == p.Id);
            s.Sayi = p.Sayi;
            s.Baslik = p.Baslik;
            s.Aciklama = p.Aciklama;
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(s);
            db.SaveChanges();


            return RedirectToAction("WhyUs");

        }


        public IActionResult Specials()
        {

            var model = new IndexViewModel()
            {
                Specials = db.Specials.ToList(),
                SpecialsNavs = db.SpecialsNavs.ToList(),
            };

            return View(model);
        }
        public IActionResult SpecialsDuzenle(int id)
        {
            Special s = db.Specials.AsQueryable().Include(x => x.SpecialsNav).FirstOrDefault(x => x.Id == id);
            return View(s);



        }

        [HttpPost]
        public IActionResult SpecialsDuzenle(Special p, IFormFile Foto)
        {
            Special s = db.Specials.AsQueryable().Include(x => x.SpecialsNav).FirstOrDefault(x => x.Id == p.Id);

            s.SpecialsNav.Baslik = p.SpecialsNav.Baslik;
            s.Baslik = p.Baslik;
            s.Aciklama1 = p.Aciklama1;
            s.Aciklama2 = p.Aciklama2;

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                s.Image = fileName;
            }
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(s);
            db.SaveChanges();
            return RedirectToAction("Specials");
        }

        public IActionResult Events()
        {

            var model = new IndexViewModel()
            {
                Events = db.Events.ToList(),
            };

            return View(model);
        }

        public IActionResult EventsDuzenle(int id)
        {

            Event e = db.Events.FirstOrDefault(x => x.Id == id);
            return View(e);
        }
        [HttpPost]
        public IActionResult EventsDuzenle(Event p, IFormFile Foto)
        {

            Event e = db.Events.FirstOrDefault(x => x.Id == p.Id);
            e.Baslik = p.Baslik;
            e.Aciklama1 = p.Aciklama1;
            e.Madde1 = p.Madde1;
            e.Madde2 = p.Madde2;
            e.Madde3 = p.Madde3;
            e.Fiyat = p.Fiyat;
            e.Aciklama2 = p.Aciklama2;
            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                e.Image = fileName;
            }
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(e);
            db.SaveChanges();




            return RedirectToAction("Events");
        }



        public IActionResult EventsEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EventsEkle(Event p, IFormFile Foto)
        {
            Event e = new Event();
            e.Baslik = p.Baslik;
            e.Aciklama1 = p.Aciklama1;
            e.Aciklama2 = p.Aciklama2;
            e.Madde1 = p.Madde1;
            e.Madde2 = p.Madde2;
            e.Madde3 = p.Madde3;
            e.Fiyat = p.Fiyat;

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                e.Image = fileName;
            }
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Add(e);
            db.SaveChanges();



            return RedirectToAction("Events");
        }


        public IActionResult EventsSil(int id)
        {
            Event e = db.Events.FirstOrDefault(x => x.Id == id);

            return View(e);

        }
        [HttpPost]
        public IActionResult EventsSil(Event p)
        {
            Event e = db.Events.FirstOrDefault(x => x.Id == p.Id);
            db.Remove(e);
            db.SaveChanges();
            return RedirectToAction("Events");
        }

        public IActionResult Gallery()
        {
            var model = new IndexViewModel()
            {

                Gallerys = db.Galleries.ToList(),

            };


            return View(model);
        }
        public IActionResult GalleryEkle()
        {

            return View();

        }

        [HttpPost]
        public IActionResult GalleryEkle(Gallery p, IFormFile Foto)
        {
            Gallery g = new Gallery();




            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\gallery", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                g.Image = fileName;
            }
            else
            {
                return RedirectToAction("GalleryEkle");

            }
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Add(g);
            db.SaveChanges();

            return RedirectToAction("Gallery");


        }
        public IActionResult GalleryDuzenle(int id)
        {
            Gallery g = db.Galleries.FirstOrDefault(x => x.Id == id);



            return View(g);

        }

        [HttpPost]
        public IActionResult GalleryDuzenle(Gallery p, IFormFile Foto)
        {

            Gallery g = db.Galleries.FirstOrDefault(x => x.Id == p.Id);

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\gallery", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                g.Image = fileName;
            }
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(g);
            db.SaveChanges();

            return RedirectToAction("Gallery");
        }

        public IActionResult GallerySil(int id)
        {
            Gallery g = db.Galleries.FirstOrDefault(x => x.Id == id);



            return View(g);
        }


        [HttpPost]
        public IActionResult GallerySil(Gallery p)
        {
            Gallery g = db.Galleries.FirstOrDefault(x => x.Id == p.Id);

            db.Remove(g);
            db.SaveChanges();


            return RedirectToAction("Gallery");
        }

        public IActionResult Chefs()
        {
            var model = new IndexViewModel()
            {
                Chefs = db.Chefs.ToList(),
            };


            return View(model);
        }


        public IActionResult ChefsDuzenle(int id)
        {
            Chef c = db.Chefs.FirstOrDefault(x => x.Id == id);



            return View(c);
        }

        [HttpPost]
        public IActionResult ChefsDuzenle(Chef p, IFormFile Foto)
        {
            Chef c = db.Chefs.FirstOrDefault(x => x.Id == p.Id);
            c.Facebook = p.Facebook;
            c.Twitter = p.Twitter;
            c.Linkedin = p.Linkedin;
            c.Instagram = p.Instagram;
            c.Title = p.Title;
            c.Name = p.Name;
            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\chefs", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                c.Image = fileName;
            }

            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(c);
            db.SaveChanges();


            return RedirectToAction("Chefs");
        }

        public IActionResult Testimonials()
        {
            var model = new IndexViewModel()
            {
                Testimonials = db.Testimonials.ToList(),
            };

            return View(model);
        }


        public IActionResult TestimonialsDuzenle(int id)
        {
            Testimonial t = db.Testimonials.FirstOrDefault(x => x.Id == id);


            return View(t);
        }
        [HttpPost]
        public IActionResult TestimonialsDuzenle(Testimonial p, IFormFile Foto)
        {
            Testimonial t = db.Testimonials.FirstOrDefault(x => x.Id == p.Id);

            t.Name = p.Name;
            t.Title = p.Title;
            t.Text = p.Text;
            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\testimonials", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                t.Image = fileName;
            }
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(t);
            db.SaveChanges();


            return RedirectToAction("Testimonials");
        }



        public IActionResult TestimonialsEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult TestimonialsEkle(Testimonial p, IFormFile Foto)
        {
            Testimonial t = new Testimonial();
            t.Name = p.Name;
            t.Title = p.Title;
            t.Text = p.Text;

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\testimonials", fileName)))
                {

                    Foto?.CopyTo(fs);
                }
                t.Image = fileName;
            }
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Add(t);
            db.SaveChanges();

            return RedirectToAction("Testimonials");
        }
















        public IActionResult TestimonialsSil(int id)
        {
            Testimonial t = db.Testimonials.FirstOrDefault(x => x.Id == id);


            return View(t);
        }
        [HttpPost]

        public IActionResult TestimonialsSil(Testimonial p)
        {
            Testimonial t = db.Testimonials.FirstOrDefault(x => x.Id == p.Id);

            db.Remove(t);
            db.SaveChanges();


            return RedirectToAction("Testimonials");

        }



        public IActionResult Footer(int id)
        {
            Footer f = db.Footers.FirstOrDefault(x => x.Id == id);
            return View(f);
        }

        [HttpPost]
        public IActionResult Footer(Footer p)
        {
            Footer f = db.Footers.FirstOrDefault(x => x.Id == p.Id);
            f.Baslik = p.Baslik;
            f.Aciklama = p.Aciklama;
            f.Icon1Link = p.Icon1Link;
            f.Icon2Link = p.Icon2Link;
            f.Icon3Link = p.Icon3Link;
            f.Icon4Link = p.Icon4Link;
            f.Icon5Link = p.Icon5Link;

            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(f);
            db.SaveChanges();

            return RedirectToAction("Footer");
        }


        public IActionResult IletisimBilgileri(int id)
        {
            Topbar t = db.Topbars.FirstOrDefault(x => x.Id == id);
            return View(t);
        }

        [HttpPost]
        public IActionResult IletisimBilgileri(Topbar p)
        {
            Topbar t = db.Topbars.FirstOrDefault(x => x.Id == p.Id);
            t.Telefon = p.Telefon;
            t.Adres = p.Adres;
            t.Email = p.Email;
            t.Saat = p.Saat;
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(t);
            db.SaveChanges();

            return RedirectToAction("IletisimBilgileri");



        }

        public IActionResult Kategoriler()
        {
            var model = new IndexViewModel()
            {
                Kategoris = db.Kategoris.ToList(),
            };

            return View(model);
        }
        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(Kategori p)
        {
            Kategori k = new Kategori();
            k.KategoriAdi = p.KategoriAdi;
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Add(k);
            db.SaveChanges();


            return RedirectToAction("Kategoriler");

        }

        public IActionResult KategoriDuzenle(int id)
        {
            Kategori k = db.Kategoris.FirstOrDefault(x => x.Id == id);


            return View(k);
        }
        [HttpPost]
        public IActionResult KategoriDuzenle(Kategori p)
        {
            Kategori k = db.Kategoris.FirstOrDefault(x => x.Id == p.Id);
            k.KategoriAdi = p.KategoriAdi;
            TempData["Alert"] = "Başarıyla Güncellendi";
            db.Update(k);
            db.SaveChanges();

            return RedirectToAction("Kategoriler");
        }

        public IActionResult KategoriSil(int id)
        {
            Kategori k=db.Kategoris.FirstOrDefault(x => x.Id == id);
            ViewBag.urunler = db.Uruns.Where(x => x.UrunKategoriId == id).ToList();


            return View(k);
        }
        [HttpPost]
        public IActionResult KategoriSil(Kategori p)
        {
            Kategori k = db.Kategoris.AsQueryable().Include(x => x.Uruns).FirstOrDefault(x => x.Id == p.Id);
       
            db.Remove(k);
            db.SaveChanges(); 


            return RedirectToAction("Kategoriler");
        }





        public IActionResult Urunler()
        {
            var model = new IndexViewModel()
            {
                Uruns = db.Uruns.ToList(),
                Kategoris = db.Kategoris.ToList(),

            };

            return View(model);
        }
        public IActionResult UrunEkle()
        {
            var model = new IndexViewModel()
            {
                Kategoris = db.Kategoris.ToList(),
            };


            return View(model);
        }

        [HttpPost]
        public IActionResult UrunEkle(Urun p)
        {
            Urun u = new Urun();
            u.UrunKategoriId = p.UrunKategoriId;


            db.Add(p);
            db.SaveChanges();
            TempData["Alert"] = "Başarıyla Güncellendi";



            return RedirectToAction("Urunler");

        }

        public IActionResult UrunDuzenle(int id)
        {
            Urun u = db.Uruns.AsQueryable().Include(x => x.UrunKategori).FirstOrDefault(x => x.Id == id);

            ViewBag.kategoriler = db.Kategoris.ToList();
            return View(u);
        }

        [HttpPost]
        public IActionResult UrunDuzenle(Urun p)
        {
            Urun u = db.Uruns.AsQueryable().Include(x => x.UrunKategori).FirstOrDefault(x => x.Id == p.Id);
            u.UrunAdi = p.UrunAdi;
            u.UrunAciklama = p.UrunAciklama;
            u.UrunFiyat = p.UrunFiyat;
            u.UrunKategoriId = p.UrunKategoriId;

            db.Update(u);
            db.SaveChanges();
            TempData["Alert"] = "Başarıyla Güncellendi";





            return RedirectToAction("Urunler");
        }

        public IActionResult UrunSil(int id)
        {
            Urun u = db.Uruns.AsQueryable().Include(x => x.UrunKategori).FirstOrDefault(x => x.Id == id);


            return View(u);
        }
        [HttpPost]
        public IActionResult UrunSil(Urun p)
        {
            Urun u =db.Uruns.FirstOrDefault(x=>x.Id==p.Id);
            db.Remove(u);
            db.SaveChanges();
            TempData["Alert"] = "Başarıyla Güncellendi";



            return RedirectToAction("Urunler");
        }

    }
}