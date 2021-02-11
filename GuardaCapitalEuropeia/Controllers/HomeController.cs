using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GuardaCapitalEuropeia.Models;

namespace GuardaCapitalEuropeia.Controllers
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
        [HttpGet]
        public IActionResult Locations()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Restaurantes()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Evento()
        {
            return View();
        }
        public IActionResult Prato()
        {
            return View();
        }
        public IActionResult Mesas()
        {
            return View();
        }
        public IActionResult Reserva_Mesa()
        {
            return View();
        }

        [HttpGet]

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
