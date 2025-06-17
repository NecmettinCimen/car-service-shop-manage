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
    public class AraclarController(IAracService aracService) : Controller, IGenericController<Arac>
    {
        [MenuFilter]
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public async Task<IActionResult> List()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await aracService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Select()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await aracService.Select(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await aracService.Get(id, firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] Arac arac)
        {
            try
            {
                arac.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                arac.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                if (arac.Id == 0)
                {
                    await aracService.Save(arac);
                }
                else
                {
                    await aracService.Update(arac);
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
                await aracService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}