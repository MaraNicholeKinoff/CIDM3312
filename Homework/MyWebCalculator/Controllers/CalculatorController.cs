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
        public string Add(decimal left, decimal right) {
            decimal addResult = MathLibrary.MyMathLib.Add(left, right);
            return $"The sum of {left} and {right} is {addResult}.";
        }
        public string Subtract(decimal left, decimal right) {
            decimal subtractResult = MathLibrary.MyMathLib.Subtract(left, right);
            return $"The subtraction of {right} from {left} is {subtractResult}.";
        }
        public string Multiply(decimal left, decimal right) {
            decimal multiplyResult = MathLibrary.MyMathLib.Multiply(left,right);
            return $"The multiplication of {right} and {left} is {multiplyResult}.";
        }
        public string Divide(decimal left, decimal right) {
            decimal divideResult = MathLibrary.MyMathLib.Divide(left,right);
            return $"The division of {right} from {left} is {divideResult}.";
        }
        public string Power(double num, double power) {
            double powerResult = MathLibrary.MyMathLib.Power(num,power);
            return $"{num} to the power of {power} is {powerResult}.";
        }
        public string Ceiling(decimal num) {
            decimal ceilingResult = MathLibrary.MyMathLib.Ceiling(num);
            return $"The celing of {num} is {ceilingResult}.";
        }
        public string Floor(decimal num) {
            decimal floorResult = MathLibrary.MyMathLib.Floor(num);
            return $"The celing of {num} is {floorResult}.";
        }
    }
}
