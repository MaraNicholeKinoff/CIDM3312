using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter1152018.Models;

namespace UnitConverter1152018.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Hello(string name) {
            return $"Hello there {name}.";
        }
        public string AnotherHello(int age) {
            return $"Hello again, you are {++age} years old.";
        }
        public string CelciusToFahrenheit(int temp) {
            decimal output = (temp * (9m/5m)) + 32;
            return $"{temp} degrees Celcius is {output} degrees Fahrenheit";
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
