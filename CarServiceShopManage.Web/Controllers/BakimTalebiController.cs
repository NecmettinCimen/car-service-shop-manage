using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using aracyonetim.web.Filters;
using aracyonetim.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace aracyonetim.web.Controllers
{
    [UserFilter]
    public class BakimTalebiController : Controller, IGenericController<BakimTalebi>
    {
        private readonly IBakimTalebiService _bakimTalebiService;
        private readonly ILookupListService _lookupListService;

        public BakimTalebiController(IBakimTalebiService bakimTalebiService,
            ILookupListService lookupListService)
        {
            _bakimTalebiService = bakimTalebiService;
            _lookupListService = lookupListService;
        }

        [MenuFilter]
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public async Task<IActionResult> List()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _bakimTalebiService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _bakimTalebiService.Get(id, firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] BakimTalebi bakimTalebi)
        {
            try
            {
                bakimTalebi.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                bakimTalebi.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                bakimTalebi.KullaniciId = bakimTalebi.CreatorId;
                bakimTalebi.DurumId = await _lookupListService.First(Lookup.Bakim);
                if (bakimTalebi.Id == 0)
                {
                    await _bakimTalebiService.Save(bakimTalebi);
                }
                else
                {
                    await _bakimTalebiService.Update(bakimTalebi);
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

                await _bakimTalebiService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}