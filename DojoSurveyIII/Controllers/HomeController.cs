using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurveyIII.Models;

namespace DojoSurveyIII.Controllers
{
    public class HomeController : Controller
    {
// v~~ V I E W S ~~v //
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
//
        [HttpPost("submit")]
        public IActionResult Submit(SurveyResults newSurveyResult)
        {
            return View("result", newSurveyResult);
        }
//
        [HttpGet("result")]
        public ViewResult Result()
        {
            return View("Result");
        }
//<~~ E N D   O F   C O N T R O L L E R ~~> //

// v~~ O T H E R ~~v //
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
