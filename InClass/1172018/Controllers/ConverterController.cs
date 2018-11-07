using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _1172018.Models;

namespace _1172018.Controllers
{
    public class ConverterController : Controller
    {
        public string Add(decimal left, decimal right) {
            return $"The sum of {left} and {right} is {left+right}.";
        }
        public string Subtract(decimal left, decimal right) {
            return $"The subtraction of {right} from {left} is {left-right}.";
        }
        public string Multiply(decimal left, decimal right) {
            return $"The multiplication of {right} and {left} is {left*right}.";
        }
        public string Divide(decimal left, decimal right) {
            return $"The division of {right} from {left} is {left/right}.";
        }
        public string Power(double num, double power) {
            return $"{num} to the power of {power} is {Math.Pow(num, power)}.";
        }
        public string Ceiling(decimal num) {
            return $"The celing of {num} is {Math.Ceiling(num)}.";
        }
        public string Floor(decimal num) {
            return $"The celing of {num} is {Math.Floor(num)}.";
        }
    }
}
