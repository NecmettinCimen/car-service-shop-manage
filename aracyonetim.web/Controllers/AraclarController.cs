using System;
using System.Threading.Tasks;
using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using aracyonetim.web.Filters;
using aracyonetim.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aracyonetim.web.Controllers
{

    [UserFilter]
    public class AraclarController : Controller, IGenericController<Arac>
    {
        private readonly  IAracService _aracService;

        public AraclarController(IAracService aracService)
        {
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
            var result =await _aracService.List(firmaid);
            return Json(result);
        }
        
        public async Task<IActionResult> Select()
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result =await _aracService.Select(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _aracService.Get(id,firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm]Arac arac)
        {
            try
            {
                arac.FirmaId= HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                arac.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                if (arac.Id == 0)
                {
                    await _aracService.Save(arac);
                }
                else
                {
                    await _aracService.Update(arac);
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
                await _aracService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}