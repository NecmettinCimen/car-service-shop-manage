using System;
using System.Threading.Tasks;
using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using aracyonetim.web.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aracyonetim.web.Controllers
{

    [UserFilter]
    public class MusterilerController : Controller, IGenericController<Musteri>
    {
        private readonly  IMusteriService _musteriService;
        private readonly  IKullaniciService _kullaniciService;

        public MusterilerController(IMusteriService musteriService,
            IKullaniciService kullaniciService)
        {
            _musteriService = musteriService;
            _kullaniciService = kullaniciService;
        }
        
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public async Task<IActionResult> List()
        {
            var result =await _musteriService.List();
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var result = await _musteriService.Get(id);
            result.Kullanici = await _kullaniciService.Find(result.KullaniciId);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm]Musteri musteri)
        {
            try
            {
                musteri.CreatorId = HttpContext.Session.GetInt32("userid").Value;
                if (musteri.Id == 0)
                {
                    musteri.KullaniciId = await _kullaniciService.Save(musteri.Kullanici);
                    musteri.Kullanici = null;
                    await _musteriService.Save(musteri);
                }
                else
                {
                    var model = await _musteriService.Get(musteri.Id);
                    musteri.Kullanici.Id = model.KullaniciId;
                    musteri.KullaniciId = model.KullaniciId;
                    await _kullaniciService.Update(musteri.Kullanici);
                    
                    await _musteriService.Update(musteri);
                }

                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }

        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                await _musteriService.Delete(id);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}