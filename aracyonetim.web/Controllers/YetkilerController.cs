using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using aracyonetim.web.Filters;
using aracyonetim.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace aracyonetim.web.Controllers
{
    [UserFilter]
    public class YetkilerController : Controller, IGenericController<YetkilerSaveDto>
    {
        private readonly IRolService _rolService;

        public YetkilerController(IRolService rolService)
        {
            _rolService = rolService;
        }

        public async Task<IActionResult> Select()
        {
            var firmaid =
                HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result =await _rolService.Select(firmaid);
            return Json(result);
        }
        
        public IActionResult RolMenuler()
        {
            var menustr = HttpContext.Session.GetString(Metrics.SessionKeys.Menuler);
            var result = JsonConvert.DeserializeObject<List<Menu>>(menustr);
            return Json(result);
        }

        public async Task<IActionResult> List()
        {
            var firmaid =
                HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _rolService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
                var firmaid =
                    HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                var result = await _rolService.Get(id, firmaid);
                return Json(result);
        }

        public async Task<IActionResult> Save(YetkilerSaveDto yetkilerSaveDto)
        {
            try
            {
                var rol = new Rol
                {
                    FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value,
                    CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value,
                    Isim = yetkilerSaveDto.Isim,
                    Id = yetkilerSaveDto.Id
                };
                if (yetkilerSaveDto.Id == 0)
                    await _rolService.Save(rol, yetkilerSaveDto.Menuler);
                else
                {
                    var model = await _rolService.Find(rol.Id, rol.FirmaId.Value);
                    model.Isim = rol.Isim;
                    await _rolService.Update(model, yetkilerSaveDto.Menuler);
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
                var firmaid =
                    HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                await _rolService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }

        [MenuFilter]
        public IActionResult Index()
        {
            return View("GenericCrud");
        }

        public IActionResult Menuler()
        {
            var result = new DataGridDto<DxSelectDto>
            {
                data = MenuManager.MenuList.Select(s=>new DxSelectDto
                {
                    id = s.No,
                     text = s.Isim
                }).ToList()
            };
            return Json(result);
        }
    }
}