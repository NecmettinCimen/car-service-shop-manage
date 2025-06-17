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
    public class YetkiliServisController : Controller
    {
        private readonly IBakimTalebiService _bakimTalebiService;
        private readonly IAracService _aracService;

        public YetkiliServisController(IBakimTalebiService bakimTalebiService,
            IAracService aracService)
        {
            _bakimTalebiService = bakimTalebiService;
            _aracService = aracService;
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
            result.Arac = await _aracService.Get(result.AracId, firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] BakimTalebi bakimTalebi)
        {
            try
            {
                bakimTalebi.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;

                bakimTalebi.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                var model = await _bakimTalebiService.Get(bakimTalebi.Id, bakimTalebi.FirmaId.Value);
                model.DurumId = bakimTalebi.DurumId;
                model.YetkiliServisAciklama = bakimTalebi.YetkiliServisAciklama;

                await _bakimTalebiService.Update(model);

                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }

    }
}