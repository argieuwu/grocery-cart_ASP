using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;
using System.Diagnostics;

namespace SuperMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        } 
        //home page
        public IActionResult Index()
        {
            return View();
        }


        //privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        //login page
        public IActionResult Login()
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
