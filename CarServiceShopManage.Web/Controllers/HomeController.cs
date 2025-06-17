using System.Diagnostics;
using System.Threading.Tasks;
using CarServiceShopManage.Services.Services;
using CarServiceShopManage.Web.Filters;
using CarServiceShopManage.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarServiceShopManage.Web.Controllers
{
    [UserFilter]
    public class HomeController(
        ILogger<HomeController> logger,
        IRaporService raporService)
        : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;

        [MenuFilter]
        public async Task<IActionResult> Index()
        {
            var firmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await raporService.Sayilar(firmaId);
            return View(result);
        }

        public async Task<IActionResult> TarihlereGoreBakimTalepleri()
        {
            var firmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await raporService.TarihlereGoreBakimTalepleri(firmaId);
            return Json(result);
        }
        public async Task<IActionResult> AracMarkalari()
        {
            var firmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await raporService.AracMarkalari(firmaId);
            return Json(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
