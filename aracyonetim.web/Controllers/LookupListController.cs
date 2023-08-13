using aracyonetim.entities.Tables;
using aracyonetim.services.Services;
using aracyonetim.web.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace aracyonetim.web.Controllers
{

    [UserFilter]
    public class LookupListController : Controller
    {
        private readonly ILookupListService _lookupListService;

        public LookupListController(ILookupListService lookupListService)
        {
            _lookupListService = lookupListService;
        }

        public async Task<IActionResult> Marka()
        {
            var result = await _lookupListService.List(Lookup.Marka);
            return Json(result);
        }

        public async Task<IActionResult> Yakit()
        {
            var result = await _lookupListService.List(Lookup.Yakit);
            return Json(result);
        }
        public async Task<IActionResult> Il()
        {
            var result = await _lookupListService.List(Lookup.Il);
            return Json(result);
        }
        public async Task<IActionResult> Ilce(int parentId)
        {
            var result = await _lookupListService.List(Lookup.Ilce, parentId);
            return Json(result);
        }
        public async Task<IActionResult> Bakim()
        {
            var result = await _lookupListService.List(Lookup.Bakim);
            return Json(result);
        }
        public async Task<IActionResult> IlIlce(int ilceid)
        {
            var ilid = await _lookupListService.GetParentId(ilceid);
            var items = await _lookupListService.List(Lookup.Ilce, ilid);
            return Json(new
            {
                ilid,
                items
            });
        }

    }
}