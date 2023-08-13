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
    public class AracGiderController : Controller, IGenericController<AracGider>
    {
        private readonly IAracGiderService _aracGiderService;
        private readonly IKullaniciService _kullaniciService;
        private readonly IRolService _rolService;

        public AracGiderController(IAracGiderService aracGiderService,
            IKullaniciService kullaniciService,
            IRolService rolService)
        {
            _aracGiderService = aracGiderService;
            _kullaniciService = kullaniciService;
            _rolService = rolService;
        }

        [MenuFilter]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _aracGiderService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _aracGiderService.Get(id, firmaid);
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
                    await _aracGiderService.Save(aracGider);
                }
                else
                {
                    var model = await _aracGiderService.Get(aracGider.Id, aracGider.FirmaId.Value);
                    await _aracGiderService.Update(aracGider);
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
                await _aracGiderService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}