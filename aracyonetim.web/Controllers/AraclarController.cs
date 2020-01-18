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
    public class AraclarController : Controller, IGenericController<Arac>
    {
        private readonly  IAracService _aracService;

        public AraclarController(IAracService aracService)
        {
            _aracService = aracService;
        }
        
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public async Task<IActionResult> List()
        {
            var result =await _aracService.List();
            return Json(result);
        }
        
        public async Task<IActionResult> Select()
        {
            var result =await _aracService.Select();
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var result = await _aracService.Get(id);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm]Arac arac)
        {
            try
            {
                arac.CreatorId = HttpContext.Session.GetInt32("userid").Value;
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
                await _aracService.Delete(id);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
    }
}