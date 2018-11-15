using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;
using MathLibrary;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Add(decimal left, decimal right) {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["AddResult"] = $"The sum of {left} and {right} is{ Math.Round(MathLibrary.MyMathLib.Add(left, right),2)}.";
            return View();
        }
        public IActionResult Subtract(decimal left, decimal right) {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["SubtractionResult"] = $"The subtraction of {right} from {left} is {Math.Round(MathLibrary.MyMathLib.Subtract(left, right),2)}.";
            return View();
        }
        public IActionResult Multiply(decimal left, decimal right) {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["MultiplicationResult"] = $"The multiplication of {right} from {left} is {Math.Round(MathLibrary.MyMathLib.Multiply(left, right),2)}.";
            return View();
        }
        public IActionResult Divide(decimal left, decimal right) {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["DivisionResult"] = $"The division of {right} from {left} is {Math.Round(MathLibrary.MyMathLib.Divide(left, right),2)}.";
            return View();
        }
        public IActionResult Power(double num, double power) {
            ViewData["Num"] = num;
            ViewData["Power"] = power;
            ViewData["PowerResult"] = $"{num} to the power of {power} is {Math.Round(MathLibrary.MyMathLib.Power(num, power),2)}.";
            return View();
        }
        public IActionResult Ceiling(decimal num) {
            ViewData["Num"] = num;
            ViewData["CeilingResult"] = $"The celing of {num} is {MathLibrary.MyMathLib.Ceiling(num)}.";
            return View();
        }
        public IActionResult Floor(decimal num) {
            ViewData["Num"] = num;
            ViewData["FloorResult"] = $"The floor of {num} is {MathLibrary.MyMathLib.Floor(num)}.";
            return View();
        }
    }
}
