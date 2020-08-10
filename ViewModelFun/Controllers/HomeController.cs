using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

// v~~ V I E W S ~~v //
        [HttpGet("")]
        public IActionResult Index()
        {
            string someString = "Here is some string repeated over and over again. Here is some string repeated over and over again. Here is some string repeated over and over again. Here is some string repeated over and over again. ";

            return View("Index", someString);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] someNums = {1, 3, 5, 7, 9, 11};

            return View("Numbers", someNums);
        }

        
        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> allUsers = new List<User>()
            {
                new User() {FirstName = "Bob", LastName = "Ross"},
                new User() {FirstName = "Dog", LastName = "House"},
                new User() {FirstName = "Santa", LastName = "Clause"}
            };

            return View("Users", allUsers);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User oneUser = new User()
            {
                FirstName = "Your",
                LastName = "Mom"
            };
            return View("User", oneUser);
        }

// v~~ M O D E L S ~~v //
        // public class String
        // {
        //     public string SomeString { get;set; }
        // }

// v~~ O T H E R ~~v //
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
//<~~ E N D   O F   C O N T R O L L E R ~~> //
    }
}
