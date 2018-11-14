using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment7.Models;

namespace Assignment7.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Converter()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult DoConversion(ConverterViewModel model)
        {
            switch (model.ConversionType) {
                //This needs to exactly match what happens in the converter.cshtml file
                case "CtoF":
                    model.ConvertedValue = Math.Round(((model.ValueToConvert * 1.8m) + 32.0m),2);
                    model.ConversionType = "Celcius to Fahrenheit";
                    break;
                case "CtoK":
                    model.ConvertedValue = Math.Round((model.ValueToConvert + 273.15m),2);
                    model.ConversionType = "Celcius to Kelvin";
                    break;
                case "FtoC":
                    model.ConvertedValue = Math.Round(((model.ValueToConvert - 32.0m) / 1.8m),2);
                    model.ConversionType = "Fahrenheit to Celcius";
                    break;
                case "FtoK":
                    model.ConvertedValue = Math.Round(((model.ValueToConvert + 459.67m) * (5.0m / 9.0m)),2);
                    model.ConversionType = "Fahrenheit to Kelvin";
                    break;
                case "KtoF":
                    model.ConvertedValue = Math.Round(((model.ValueToConvert * 1.8m) -459.67m),2);
                    model.ConversionType = "Kelvin to Fahrenheit";
                    break;
                case "KtoC":
                    model.ConvertedValue = Math.Round((model.ValueToConvert - 273.15m),2);
                    model.ConversionType = "Kelvin to Celcius";
                    break;
                case "MtoF":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 0.3048m),2);
                    model.ConversionType = "Meters to Feet";
                    break;
                case "MtoY":
                    model.ConvertedValue = Math.Round((model.ValueToConvert * 1.0936m),2);
                    model.ConversionType = "Meters to Yards";
                    break;
                case "FtoM":
                    model.ConvertedValue = Math.Round((model.ValueToConvert * 0.3048m),2);
                    model.ConversionType = "Feet to Meters";
                    break;
                case "FtoY":
                    model.ConvertedValue = Math.Round((model.ValueToConvert * 0.3333m),2);
                    model.ConversionType = "Feet to Yards";
                    break;
                case "YtoM":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 1.0936m),2);
                    model.ConversionType = "Yards to Meters";
                    break;
                case "YtoF":
                    model.ConvertedValue = Math.Round((model.ValueToConvert * 3.0m),2);
                    model.ConversionType = "Yards to Feet";
                    break;
                case "OtoP":
                    model.ConvertedValue = Math.Round((model.ValueToConvert * 0.0625m),2);
                    model.ConversionType = "Ounces to Pounds";
                    break;
                case "OtoG":   
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 0.035274m),2);
                    model.ConversionType = "Ounces to Grams";
                    break;
                case "OtoKG":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 35.274m),2);
                    model.ConversionType = "Ounces to Kilograms";
                    break;
                case "PtoO":
                    model.ConvertedValue = Math.Round((model.ValueToConvert * 16.00m),2);
                    model.ConversionType = "Pounds to Ounces";
                    break;
                case "PtoG":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 0.0022046m),2);
                    model.ConversionType = "Pounds to Grams";
                    break;
                case "PtoKG":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 2.2046m),2);
                    model.ConversionType = "Pounds to Kilograms";
                    break;
                case "GtoO":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 28.3495m),2);
                    model.ConversionType = "Grams to Ounces";
                    break;
                case "GtoP":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 453.59237m),2);
                    model.ConversionType = "Grams to Pounds";
                    break;
                case "GtoKG":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 1000.0m),2);
                    model.ConversionType = "Grams to Kilograms";
                    break;
                case "KGtoO":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 0.02834952m),2);
                    model.ConversionType = "Kilograms to Ounces";
                    break;
                case "KGtoP":
                    model.ConvertedValue = Math.Round((model.ValueToConvert / 0.45359237m),2);
                    model.ConversionType = "Kilograms to Pounds";
                    break;
                case "KGtoG":
                    model.ConvertedValue = Math.Round((model.ValueToConvert * 1000.0m),2);
                    model.ConversionType = "Kilograms to Grams";
                    break;
                default:
                    Console.WriteLine("There was an error.");
                    break;
            }
            return View(model);
        }
    }
}
