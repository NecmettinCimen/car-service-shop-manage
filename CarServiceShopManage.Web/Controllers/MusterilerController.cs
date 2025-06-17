using System;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Services;
using CarServiceShopManage.Web.Filters;
using CarServiceShopManage.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceShopManage.Web.Controllers
{

    [UserFilter]
    public class MusterilerController(
        IMusteriService musteriService,
        IKullaniciService kullaniciService,
        IRolService rolService)
        : Controller, IGenericController<Musteri>
    {
        [MenuFilter]
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public async Task<IActionResult> List()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await musteriService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await musteriService.Get(id, firmaid);
            result.Kullanici = await kullaniciService.Find(result.KullaniciId);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] Musteri musteri)
        {
            try
            {
                musteri.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                musteri.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                musteri.Kullanici.RolId = await rolService.MusteriRolId();
                if (musteri.Id == 0)
                {
                    musteri.KullaniciId = await kullaniciService.Save(musteri.Kullanici);
                    musteri.Kullanici = null;
                    await musteriService.Save(musteri);
                }
                else
                {
                    var model = await musteriService.Get(musteri.Id, musteri.FirmaId.Value);
                    musteri.Kullanici.Id = model.KullaniciId;
                    musteri.KullaniciId = model.KullaniciId;
                    await kullaniciService.Update(musteri.Kullanici);

                    await musteriService.Update(musteri);
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
                await musteriService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}