using System;
using System.Threading.Tasks;
using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using aracyonetim.web.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aracyonetim.web.Controllers
{

    [UserFilter]
    public class YetkiliServisController : Controller
    {
        private readonly  IBakimTalebiService _bakimTalebiService;
        private readonly  IAracService _aracService;

        public YetkiliServisController(IBakimTalebiService bakimTalebiService,
            IAracService aracService)
        {
            _bakimTalebiService = bakimTalebiService;
            _aracService = aracService;
        }
        
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public async Task<IActionResult> List()
        {
            var result =await _bakimTalebiService.List();
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var result = await _bakimTalebiService.Get(id);
            result.Arac = await _aracService.Get(result.AracId);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm]BakimTalebi bakimTalebi)
        {
            try
            {
                bakimTalebi.CreatorId = HttpContext.Session.GetInt32("userid").Value;
                var model = await _bakimTalebiService.Get(bakimTalebi.Id);
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