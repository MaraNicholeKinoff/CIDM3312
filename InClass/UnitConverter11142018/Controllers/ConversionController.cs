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
            ViewData["Message"] = "This is the a message";
            return View();
        }
        public IActionResult Converter()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult DoConversion(ConverterViewModel model)
        {
            model.ConvertedValue = model.ValueToConvert * model.ValueToConvert;
            return View(model);
        }
    }
}
