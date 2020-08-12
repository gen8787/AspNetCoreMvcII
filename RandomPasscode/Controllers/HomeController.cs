using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
// v~~ M A I N   V I E W S ~~v //
        [HttpGet("")]
        public IActionResult Index()
        {
            string RandomString(int len)
            {
                Random rando = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, len)
                .Select(s => s[rando.Next(s.Length)]).ToArray());
            }

            if(HttpContext.Session.GetInt32("PassCount") == null)
            {
                HttpContext.Session.SetInt32("PassCount", 1);
            }

            ViewBag.passCount = HttpContext.Session.GetInt32("PassCount");
            ViewBag.RandoPass = RandomString(14);
            return View("Index");
        }
// Generate
        [HttpPost("generate")]
        public IActionResult Generate()
        {
            int? GetSession = HttpContext.Session.GetInt32("PassCount") + 1;
            int UpdateSession = (int)GetSession;

            HttpContext.Session.SetInt32("PassCount", UpdateSession);

            return RedirectToAction("Index");
        }
// Clear Session
        [HttpPost("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
//<~~ E N D   O F   M A I N   V I E W S ~~> //
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
