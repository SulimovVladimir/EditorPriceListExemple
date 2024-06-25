using EditorPriceListExemple.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EditorPriceListExemple.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext _appDB;

        public HomeController(ILogger<HomeController> logger, AppDBContext appDB)
        {
            _logger = logger;
            _appDB = appDB;
        }

        public IActionResult Index()
        {
            PriceList priceList = _appDB.PriceLists.First();
            return View(priceList);
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
