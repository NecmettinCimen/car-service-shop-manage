using System.Threading.Tasks;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Services;
using CarServiceShopManage.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceShopManage.Web.Controllers
{

    [UserFilter]
    public class LookupListController(ILookupListService lookupListService) : Controller
    {
        public async Task<IActionResult> Marka()
        {
            var result = await lookupListService.List(Lookup.Marka);
            return Json(result);
        }

        public async Task<IActionResult> Yakit()
        {
            var result = await lookupListService.List(Lookup.Yakit);
            return Json(result);
        }
        public async Task<IActionResult> Il()
        {
            var result = await lookupListService.List(Lookup.Il);
            return Json(result);
        }
        public async Task<IActionResult> Ilce(int parentId)
        {
            var result = await lookupListService.List(Lookup.Ilce, parentId);
            return Json(result);
        }
        public async Task<IActionResult> Bakim()
        {
            var result = await lookupListService.List(Lookup.Bakim);
            return Json(result);
        }
        public async Task<IActionResult> IlIlce(int ilceid)
        {
            var ilid = await lookupListService.GetParentId(ilceid);
            var items = await lookupListService.List(Lookup.Ilce, ilid);
            return Json(new
            {
                ilid,
                items
            });
        }

    }
}