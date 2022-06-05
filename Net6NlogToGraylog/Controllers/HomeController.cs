using Microsoft.AspNetCore.Mvc;
using Net6NlogToGraylog.Models;
using System.Diagnostics;

namespace Net6NlogToGraylog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index LogInformation");
            _logger.LogError("Index LogError");
            _logger.LogTrace("Index LogTrace");
            _logger.LogWarning("Index LogWarning");
            return View();
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