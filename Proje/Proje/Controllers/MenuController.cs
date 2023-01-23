using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;
using Proje.Models.Entities;

namespace Proje.Controllers
{
    public class MenuController : Controller
    {
        ProjeContext db = new ProjeContext();
        public IActionResult Index()
        {
            var model = new IndexViewModel()
            {
                Kategoris=db.Kategoris.AsQueryable().Include(x=>x.Uruns).ToList(),
            };


            return View(model);
        }
    }
}
