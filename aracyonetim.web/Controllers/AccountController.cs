using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using aracyonetim.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace aracyonetim.web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IKullaniciService _kullaniciService;
        private readonly IFirmaService _firmaService;
        private readonly IMailService _mailService;
        private readonly IRolService _rolService;

        public AccountController(IKullaniciService kullaniciService,
            IFirmaService firmaService,
            IMailService mailService,
            IRolService rolService)
        {
            _kullaniciService = kullaniciService;
            _firmaService = firmaService;
            _mailService = mailService;
            _rolService = rolService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(false);
        }

        [HttpPost]
        public async Task<IActionResult> Login(Kullanici model)
        {
            var kullanici = await _kullaniciService.Login(model.Eposta, model.Parola);
            if (kullanici == null)
                return View(true);

            kullanici.Firma = await _firmaService.Get(kullanici.FirmaId.Value);

            HttpContext.Session.SetInt32(Metrics.SessionKeys.FirmaId, kullanici.FirmaId.Value);
            HttpContext.Session.SetInt32(Metrics.SessionKeys.UserId, kullanici.Id);
            HttpContext.Session.SetString(Metrics.SessionKeys.UserName, kullanici.AdSoyad);
            HttpContext.Session.SetString(Metrics.SessionKeys.FirmaName, kullanici.Firma.Isim);
            var url = await PrepareUser(kullanici.RolId);

            return RedirectToAction("Index", $"{url}");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(false);
        }

        [HttpPost]
        public async Task<IActionResult> Register(Kullanici model)
        {
            var emailcheck = await _kullaniciService.EpostaCheck(model.Eposta);
            if (emailcheck)
            {
                return View(true);
            }
            model.FirmaId = await _firmaService.Save(model.Firma);
            model.RolId = await _rolService.First();
            var userid = await _kullaniciService.Save(model);

            HttpContext.Session.SetInt32(Metrics.SessionKeys.FirmaId, model.FirmaId.Value);
            HttpContext.Session.SetInt32(Metrics.SessionKeys.UserId, userid);
            HttpContext.Session.SetString(Metrics.SessionKeys.UserName, model.AdSoyad);
            HttpContext.Session.SetString(Metrics.SessionKeys.FirmaName, model.Firma.Isim);
            var url = await PrepareUser(model.RolId);
            await _mailService.Send(model.Eposta, "Araç Yönetim Sistemine Hoşgeldiniz.",
                "Sistem üzerindeki kayıtlarınız güvende, işe başka kullanıcılar ekleyip onları yetkilendirerek başlayabilirsiniz.")
                .ConfigureAwait(false);

            return RedirectToAction("Index", $"{url}");
        }

        private async Task<string> PrepareUser(int rolId)
        {
            var result = await _rolService.Menuler(rolId);
            HttpContext.Session.SetString(Metrics.SessionKeys.Menuler, JsonConvert.SerializeObject(result));
            HttpContext.Session.SetString(Metrics.SessionKeys.MenuAdresler,
                JsonConvert.SerializeObject(result.Select(s => s.Adres.Replace("/", "").ToLower()).ToList()));
            return result.First().Adres;
        }
    }
}