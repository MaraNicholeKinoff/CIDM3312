using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment7.Models;

namespace Assignment7.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Index()
        {
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
