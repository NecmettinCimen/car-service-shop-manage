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
    public class KullanicilarController(IKullaniciService kullaniciService) : Controller, IGenericController<Kullanici>
    {
        [MenuFilter]
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public async Task<IActionResult> List()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await kullaniciService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var result = await kullaniciService.Find(id);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] Kullanici kullanici)
        {
            try
            {
                kullanici.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                kullanici.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                if (kullanici.Id == 0)
                {
                    await kullaniciService.Save(kullanici);
                }
                else
                {
                    await kullaniciService.Update(kullanici);
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
                await kullaniciService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}