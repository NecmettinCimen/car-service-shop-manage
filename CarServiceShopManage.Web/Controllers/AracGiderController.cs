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
    public class AracGiderController(
        IAracGiderService aracGiderService,
        IKullaniciService kullaniciService,
        IRolService rolService)
        : Controller, IGenericController<AracGider>
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
            var result = await aracGiderService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await aracGiderService.Get(id, firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] AracGider aracGider)
        {
            try
            {
                aracGider.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                aracGider.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                if (aracGider.Id == 0)
                {
                    await aracGiderService.Save(aracGider);
                }
                else
                {
                    var model = await aracGiderService.Get(aracGider.Id, aracGider.FirmaId.Value);
                    await aracGiderService.Update(aracGider);
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
                await aracGiderService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}