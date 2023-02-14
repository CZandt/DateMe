using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DateMe.Models;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DateApplicationContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, DateApplicationContext dac)
        {
            _logger = logger;
            _blahContext = dac;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet]
        public IActionResult DatingApplication() {

            return View();

        }

        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse ar) {

            _blahContext.Add(ar);
            _blahContext.SaveChanges();

            return View("Confirmation", ar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

