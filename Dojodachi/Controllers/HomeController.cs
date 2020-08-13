using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
// v~~ M A I N   V I E W S ~~v //
// New Doggo
        [HttpGet("new-doggo")]
        public IActionResult NewDoggo()
        {
            Dog newDoggo = new Dog();
            HttpContext.Session.SetInt32("Fullness", newDoggo.Fullness);
            HttpContext.Session.SetInt32("Happiness", newDoggo.Happiness);
            HttpContext.Session.SetInt32("Meals", newDoggo.Meals);
            HttpContext.Session.SetInt32("Energy", newDoggo.Energy);
            HttpContext.Session.SetString("Message", "Who's a good boy?");
            return RedirectToAction("Index");
        }
// Index
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Fullness") == null)
            {
                NewDoggo();
            }
            int? GetFullness = HttpContext.Session.GetInt32("Fullness");
            int? GetHappiness = HttpContext.Session.GetInt32("Happiness");
            int? GetMeals = HttpContext.Session.GetInt32("Meals");
            int? GetEnergy = HttpContext.Session.GetInt32("Energy");
            string GetMessage = HttpContext.Session.GetString("Message");

            if (GetFullness == 0 || GetHappiness == 0)
            {
                HttpContext.Session.SetString("Message", "Your doggo has ran away.");
                
            }

            ViewBag.Fullness = GetFullness;
            ViewBag.Happiness = GetHappiness;
            ViewBag.Meals = GetMeals;
            ViewBag.Energy = GetEnergy;
            ViewBag.Message = GetMessage;

            return View("Index");
        }
// Feed
        [HttpPost("Feed")]
        public IActionResult Feed()
        {
            int? GetFullness = HttpContext.Session.GetInt32("Fullness");
            int? GetMeals = HttpContext.Session.GetInt32("Meals");
            string GetMessage = HttpContext.Session.GetString("Message");

            if (GetMeals == 0)
            {
                HttpContext.Session.SetString("Message", "No Meals, go to work!");
                return RedirectToAction("Index");
            }

            Random rando = new Random();
            int FeedMe = rando.Next(5, 11);
            double DontWantTo = rando.NextDouble();
            Console.WriteLine(DontWantTo * 100);

            if (DontWantTo * 100 < 25)
            {
                int UpdateMeals = (int)GetMeals - 1;
                string UpdateMessage = $"Doggo threw up meal. Fullness +0";

                HttpContext.Session.SetInt32("Meals", UpdateMeals);
                HttpContext.Session.SetString("Message", UpdateMessage);
            }
            else
            {
                int UpdateFullness = (int)GetFullness + FeedMe;
                int UpdateMeals = (int)GetMeals - 1;
                string UpdateMessage = $"Doggo has been fed. Fullness +{FeedMe}";

                HttpContext.Session.SetInt32("Fullness", UpdateFullness);
                HttpContext.Session.SetInt32("Meals", UpdateMeals);
                HttpContext.Session.SetString("Message", UpdateMessage);
            }
            return RedirectToAction("Index");
        }
// Play
        [HttpPost("Play")]
        public IActionResult Play()
        {
            int? GetHappiness = HttpContext.Session.GetInt32("Happiness");
            int? GetEnergy = HttpContext.Session.GetInt32("Energy");
            string GetMessage = HttpContext.Session.GetString("Message");

            Random rando = new Random();
            int PlayWithMe = rando.Next(5, 11);
            double DontWantTo = rando.NextDouble();

            if (DontWantTo * 100 < 25)
            {
                int UpdateEnergy = (int)(GetEnergy) - 5;
                string UpdateMessage = $"Doggo didn't want to play. Happiness +0";

                HttpContext.Session.SetInt32("Energy", UpdateEnergy);
                HttpContext.Session.SetString("Message", UpdateMessage);
            }
            else
            {
            int UpdateHappiness = (int)GetHappiness + PlayWithMe;
            int UpdateEnergy = (int)(GetEnergy) - 5;
            string UpdateMessage = $"Doggo has played. Happiness +{PlayWithMe}";

            HttpContext.Session.SetInt32("Happiness", UpdateHappiness);
            HttpContext.Session.SetInt32("Energy", UpdateEnergy);
            HttpContext.Session.SetString("Message", UpdateMessage);
            }
            return RedirectToAction("Index");
        }
// Work
        [HttpPost("Work")]
        public IActionResult Work()
        {
            int? GetMeals = HttpContext.Session.GetInt32("Meals");
            int? GetEnergy = HttpContext.Session.GetInt32("Energy");
            string GetMessage = HttpContext.Session.GetString("Message");

            Random rando = new Random();
            int WorkMe = rando.Next(1, 4);

            int UpdateMeals = (int)GetMeals + WorkMe;
            int UpdateEnergy = (int)GetEnergy - 5;
            string UpdateMessage = $"Doggo has worked. Meals +{WorkMe}";

            HttpContext.Session.SetInt32("Meals", UpdateMeals);
            HttpContext.Session.SetInt32("Energy", UpdateEnergy);
            HttpContext.Session.SetString("Message", UpdateMessage);

            return RedirectToAction("Index");
        }
// Sleep
        [HttpPost("Sleep")]
        public IActionResult Sleep()
        {
            int? GetFullness = HttpContext.Session.GetInt32("Fullness");
            int? GetHappiness = HttpContext.Session.GetInt32("Happiness");
            int? GetEnergy = HttpContext.Session.GetInt32("Energy");
            string GetMessage = HttpContext.Session.GetString("Message");

            int UpdateFullness = (int)GetFullness - 5;
            int UpdateHappiness = (int)GetHappiness - 5;
            int UpdateEnergy = (int)GetEnergy + 15;
            string UpdateMessage = "Doggo has slept. Sleep +15";

            HttpContext.Session.SetInt32("Fullness", UpdateFullness);
            HttpContext.Session.SetInt32("Happiness", UpdateHappiness);
            HttpContext.Session.SetInt32("Energy", UpdateEnergy);
            HttpContext.Session.SetString("Message", UpdateMessage);

            return RedirectToAction("Index");
        }
// Restart
            [HttpPost("again")]
            public IActionResult Again()
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
