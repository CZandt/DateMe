using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DateMe.Models;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DateApplicationContext _daContext { get; set; }
        

        public HomeController(DateApplicationContext dac)
        {
            _daContext = dac;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WaitList()
        {
            var applications = _daContext.responses
                .Include(x => x.Major)
                .Where(x => x.CreeperStalker == false)
                .OrderBy(x => x.LastName)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult DatingApplication() {

            ViewBag.Majors = _daContext.Majors.ToList();

            return View();
            return View();

        }

        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse ar) {

            _daContext.Add(ar);
            _daContext.SaveChanges();

            return View("Confirmation", ar);
        }


        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] Why tf is this here

    }
}

