using System.Threading.Tasks;
using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aracyonetim.web.Controllers
{
    public class AccountController:Controller
    {
        private readonly IKullaniciService _kullaniciService;

        public AccountController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            return View(false);
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(Kullanici model)
        {
            var kullanici =await _kullaniciService.Login(model.Eposta, model.Parola);
            if (kullanici == null)
                return View(true);
            HttpContext.Session.SetInt32("userid",kullanici.Id);
            HttpContext.Session.SetString("username",kullanici.AdSoyad);
            return Redirect("/");
        }
        
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Account/Login");
        }
        
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(Kullanici model)
        {
            var userid =await _kullaniciService.Save(model);
            HttpContext.Session.SetInt32("userid",userid);
            HttpContext.Session.SetString("username",model.AdSoyad);
            return Redirect("/");
        }
    }
}