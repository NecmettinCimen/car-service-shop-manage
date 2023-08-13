using aracyonetim.services.Services;
using aracyonetim.web.Filters;
using aracyonetim.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace aracyonetim.web.Controllers
{
    [UserFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRaporService _raporService;

        public HomeController(ILogger<HomeController> logger,
            IRaporService raporService)
        {
            _logger = logger;
            _raporService = raporService;
        }

        [MenuFilter]
        public async Task<IActionResult> Index()
        {
            var firmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _raporService.Sayilar(firmaId);
            return View(result);
        }

        public async Task<IActionResult> TarihlereGoreBakimTalepleri()
        {
            var firmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _raporService.TarihlereGoreBakimTalepleri(firmaId);
            return Json(result);
        }
        public async Task<IActionResult> AracMarkalari()
        {
            var firmaId = HttpContext.Session.GetInt32(Metrics.SessionKeys.FirmaId).Value;
            var result = await _raporService.AracMarkalari(firmaId);
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
