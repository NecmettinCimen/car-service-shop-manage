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
    public class BakimTalebiController(
        IBakimTalebiService bakimTalebiService,
        ILookupListService lookupListService)
        : Controller, IGenericController<BakimTalebi>
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
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] BakimTalebi bakimTalebi)
        {
            try
            {
                bakimTalebi.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                bakimTalebi.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                bakimTalebi.KullaniciId = bakimTalebi.CreatorId;
                bakimTalebi.DurumId = await lookupListService.First(Lookup.Bakim);
                if (bakimTalebi.Id == 0)
                {
                    await bakimTalebiService.Save(bakimTalebi);
                }
                else
                {
                    await bakimTalebiService.Update(bakimTalebi);
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

                await bakimTalebiService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}