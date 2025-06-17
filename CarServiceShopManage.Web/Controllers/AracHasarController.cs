using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using aracyonetim.web.Filters;
using aracyonetim.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aracyonetim.web.Controllers
{

    [UserFilter]
    public class AracHasarController : Controller, IGenericController<AracHasar>
    {
        private readonly IAracHasarService _aracHasarService;
        private readonly IKullaniciService _kullaniciService;
        private readonly IRolService _rolService;

        public AracHasarController(IAracHasarService aracHasarService,
            IKullaniciService kullaniciService,
            IRolService rolService)
        {
            _aracHasarService = aracHasarService;
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
            var result = await _aracHasarService.List(firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Get(int id)
        {
            var firmaid = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _aracHasarService.Get(id, firmaid);
            return Json(result);
        }

        public async Task<IActionResult> Save([FromForm] AracHasar aracHasar)
        {
            try
            {
                aracHasar.FirmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
                aracHasar.CreatorId = HttpContext.Session.GetInt32(Metrics.SessionKeys.UserId).Value;
                if (aracHasar.Id == 0)
                {
                    await _aracHasarService.Save(aracHasar);
                }
                else
                {
                    var model = await _aracHasarService.Get(aracHasar.Id, aracHasar.FirmaId.Value);
                    await _aracHasarService.Update(aracHasar);
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
                await _aracHasarService.Delete(id, firmaid);
                return Json(true);
            }
            catch (Exception e)
            {
                return Json(false);
            }
        }
        public IActionResult Select()
        {
            var result = new DataGridDto<DxSelectDto>()
            {
                data = new List<DxSelectDto>
                {
        new DxSelectDto{ id = 0, text = EAracHasar.Belirtilmemis.ToString(), },
        new DxSelectDto{ id = 1, text = EAracHasar.Orijinal.ToString(), },
        new DxSelectDto{ id = 2, text = EAracHasar.Boyali.ToString(), },
        new DxSelectDto{ id = 3, text = EAracHasar.LokalBoyali.ToString(), },
        new DxSelectDto{ id = 4, text = EAracHasar. Degismis .ToString()},
                },
                totalCount = 5
            };
            return Json(result);
        }
    }
}