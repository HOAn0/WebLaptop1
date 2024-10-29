using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLaptop.Models;

namespace WebLaptop.Controllers
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
            return View();
        }
        public IActionResult Charts()
        {
            return View(); 
        }
        public IActionResult Tables() 
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        
    }
}
