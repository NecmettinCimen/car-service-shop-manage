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
    public class AracOrtaklarController(
        IAracOrtakService aracOrtakService,
        IKullaniciService kullaniciService,
        IRolService rolService)
        : Controller, IGenericController<AracOrtak>
    {
        private readonly IKullaniciService _kullaniciService = kullaniciService;
        private readonly IRolService _rolService = rolService;

        [MenuFilter]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await aracOrtakService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await aracOrtakService.Get(id, firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] AracOrtak aracOrtak)
        {
            try
            {
                aracOrtak.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                aracOrtak.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                if (aracOrtak.Id == 0)
                {
                    await aracOrtakService.Save(aracOrtak);
                }
                else
                {
                    var model = await aracOrtakService.Get(aracOrtak.Id, aracOrtak.FirmaId.Value);
                    await aracOrtakService.Update(aracOrtak);
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
                await aracOrtakService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}