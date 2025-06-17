using System.Linq;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Services;
using CarServiceShopManage.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarServiceShopManage.Web.Controllers
{
    public class AccountController(
        IKullaniciService kullaniciService,
        IFirmaService firmaService,
        IMailService mailService,
        IRolService rolService)
        : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View(false);
        }

        [HttpPost]
        public async Task<IActionResult> Login(Kullanici model)
        {
            var kullanici = await kullaniciService.Login(model.Eposta, model.Parola);
            if (kullanici == null)
                return View(true);

            kullanici.Firma = await firmaService.Get(kullanici.FirmaId.Value);

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
            var emailcheck = await kullaniciService.EpostaCheck(model.Eposta);
            if (emailcheck)
            {
                return View(true);
            }
            model.FirmaId = await firmaService.Save(model.Firma);
            model.RolId = await rolService.First();
            var userid = await kullaniciService.Save(model);

            HttpContext.Session.SetInt32(Metrics.SessionKeys.FirmaId, model.FirmaId.Value);
            HttpContext.Session.SetInt32(Metrics.SessionKeys.UserId, userid);
            HttpContext.Session.SetString(Metrics.SessionKeys.UserName, model.AdSoyad);
            HttpContext.Session.SetString(Metrics.SessionKeys.FirmaName, model.Firma.Isim);
            var url = await PrepareUser(model.RolId);
            await mailService.Send(model.Eposta, "Araç Yönetim Sistemine Hoşgeldiniz.",
                "Sistem üzerindeki kayıtlarınız güvende, işe başka kullanıcılar ekleyip onları yetkilendirerek başlayabilirsiniz.")
                .ConfigureAwait(false);

            return RedirectToAction("Index", $"{url}");
        }

        private async Task<string> PrepareUser(int rolId)
        {
            var result = await rolService.Menuler(rolId);
            HttpContext.Session.SetString(Metrics.SessionKeys.Menuler, JsonConvert.SerializeObject(result));
            HttpContext.Session.SetString(Metrics.SessionKeys.MenuAdresler,
                JsonConvert.SerializeObject(result.Select(s => s.Adres.Replace("/", "").ToLower()).ToList()));
            return result.First().Adres;
        }
    }
}