using EnerStreamWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EnerStreamWeb.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }



        public IActionResult CompanyBackground()
        {
            return View();
        }
        public IActionResult OurPeople()
        {
            return View();
        }

        public IActionResult RockpointInfo()
        {
            return View();
        }



        public IActionResult PortfolioManagement()
        {
            return View();
        }


        public IActionResult PricingProducts()
        {
            return View();
        }
 




        public IActionResult Testimonials()
        {
            return View();
        }

        public IActionResult Assocciations()
        {
            return View();
        }







        public IActionResult Renewables()
        {
            return View();
        }


        public IActionResult Fundamentals()
        {
            return View();
        }
        public IActionResult EnerstreamNews()
        {
            return View();
        }

        public IActionResult IndustryLinks()
        {
            return View();
        }


        public IActionResult NewsFeedArchives()
        {
            return View();
        }



        public IActionResult EnergyConverter()
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