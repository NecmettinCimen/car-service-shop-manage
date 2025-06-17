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
    public class YetkiliServisController(
        IBakimTalebiService bakimTalebiService,
        IAracService aracService)
        : Controller
    {
        [MenuFilter]
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public async Task<IActionResult> List()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;

            var result = await bakimTalebiService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;

            var result = await bakimTalebiService.Get(id, firmaid);
            result.Arac = await aracService.Get(result.AracId, firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] BakimTalebi bakimTalebi)
        {
            try
            {
                bakimTalebi.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;

                bakimTalebi.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                var model = await bakimTalebiService.Get(bakimTalebi.Id, bakimTalebi.FirmaId.Value);
                model.DurumId = bakimTalebi.DurumId;
                model.YetkiliServisAciklama = bakimTalebi.YetkiliServisAciklama;

                await bakimTalebiService.Update(model);

                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }

    }
}