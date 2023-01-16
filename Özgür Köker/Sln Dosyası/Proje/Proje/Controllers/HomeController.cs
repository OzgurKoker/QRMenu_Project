using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;
using Proje.Models.Entities;
using System.Diagnostics;
using System.Xml.Linq;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        ProjeContext db = new ProjeContext();


        public IActionResult Index()
        {
            var model = new IndexViewModel()
            {
                Testimonials = db.Testimonials.ToList(),
                Sliders = db.Sliders.ToList(),
                Abouts = db.Abouts.ToList(),
                Titles = db.Titles.ToList(),
                Specials = db.Specials.ToList(),
                WhyUs = db.WhyUs.ToList(),
                Events = db.Events.ToList(),
                SpecialsNavs = db.SpecialsNavs.ToList(),
                Gallerys = db.Galleries.ToList(),
                Chefs = db.Chefs.ToList(),
                Footers = db.Footers.ToList(),
                ContactForms = db.ContactForms.ToList(),
                Topbars= db.Topbars.ToList(),

            };

            return View(model);
        }


        [HttpPost]
        public IActionResult Index(ContactForm contact)
        {
           



            ContactForm cnt = new ContactForm();
            cnt.Name = contact.Name;
            cnt.Email = contact.Email;
            cnt.Konu = contact.Konu;
            cnt.Mesaj = contact.Mesaj;
            db.Add(cnt);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}