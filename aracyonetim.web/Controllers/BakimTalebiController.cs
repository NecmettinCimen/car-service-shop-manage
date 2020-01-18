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
    public class BakimTalebiController : Controller, IGenericController<BakimTalebi>
    {
        private readonly  IBakimTalebiService _bakimTalebiService;
        private readonly  ILookupListService _lookupListService;

        public BakimTalebiController(IBakimTalebiService bakimTalebiService,
            ILookupListService lookupListService)
        {
            _bakimTalebiService = bakimTalebiService;
            _lookupListService = lookupListService;
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
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm]BakimTalebi bakimTalebi)
        {
            try
            {
                bakimTalebi.CreatorId = HttpContext.Session.GetInt32("userid").Value;
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
                await _bakimTalebiService.Delete(id);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}