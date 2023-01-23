using Microsoft.AspNetCore.Mvc;
using Proje.Models;
using Proje.Models.Entities;
using System.Xml.Linq;

namespace Proje.Controllers
{
    public class LoginController : Controller
    {
        ProjeContext db = new ProjeContext();
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Login p)
        {

            var admin = db.Logins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (admin != null)
            {

                return RedirectToAction("Index", "Admin");
            }
            else
            {
                TempData["Alert"] = "Kullanıcı Adı veya Şifre Yanlış";

                return RedirectToAction("Index", "Login");
            }


        }
    }
}
