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
    public class AracOrtaklarController : Controller, IGenericController<AracOrtak>
    {
        private readonly IAracOrtakService _aracOrtakService;
        private readonly IKullaniciService _kullaniciService;
        private readonly IRolService _rolService;

        public AracOrtaklarController(IAracOrtakService aracOrtakService,
            IKullaniciService kullaniciService,
            IRolService rolService)
        {
            _aracOrtakService = aracOrtakService;
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
            var result = await _aracOrtakService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _aracOrtakService.Get(id, firmaid);
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
                    await _aracOrtakService.Save(aracOrtak);
                }
                else
                {
                    var model = await _aracOrtakService.Get(aracOrtak.Id, aracOrtak.FirmaId.Value);
                    await _aracOrtakService.Update(aracOrtak);
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
                await _aracOrtakService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}