using System;
using System.Threading.Tasks;
using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using aracyonetim.web.Filters;
using aracyonetim.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aracyonetim.web.Controllers
{

    [UserFilter]
    public class MusterilerController : Controller, IGenericController<Musteri>
    {
        private readonly  IMusteriService _musteriService;
        private readonly  IKullaniciService _kullaniciService;
        private readonly  IRolService _rolService;

        public MusterilerController(IMusteriService musteriService,
            IKullaniciService kullaniciService,
            IRolService rolService)
        {
            _musteriService = musteriService;
            _kullaniciService = kullaniciService;
            _rolService = rolService;
        }
        
        [MenuFilter]
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public async Task<IActionResult> List()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result =await _musteriService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _musteriService.Get(id, firmaid);
            result.Kullanici = await _kullaniciService.Find(result.KullaniciId);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm]Musteri musteri)
        {
            try
            {
                musteri.FirmaId= HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                musteri.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                musteri.Kullanici.RolId =await _rolService.MusteriRolId();
                if (musteri.Id == 0)
                {
                    musteri.KullaniciId = await _kullaniciService.Save(musteri.Kullanici);
                    musteri.Kullanici = null;
                    await _musteriService.Save(musteri);
                }
                else
                {
                    var model = await _musteriService.Get(musteri.Id, musteri.FirmaId.Value);
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
                var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                await _musteriService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}