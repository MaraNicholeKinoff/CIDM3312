using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter11142018.Models;

namespace UnitConverter11142018.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "This is the message";
            return View();
        }
        
    }
}
