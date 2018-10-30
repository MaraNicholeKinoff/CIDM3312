using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;

namespace UnitConverter.Controllers
{
    public class ConverterController : Controller
    {
        public string Index(string conversion, double value)
        {
            double newvalue = 0.0;
            switch (conversion) {
                //TEMPATURE CONVERSIONS
                case "CtoF":
                    //test url: https://localhost:5001/Converter/Index?conversion=CtoF&value=32
                    newvalue = (value * 1.8) + 32.0;
                    return $"{conversion}: {value:.##} degrees Celcius is {newvalue:.##} Fahrenheit.";
                    break;
                case "CtoK":
                    //test url: https://localhost:5001/Converter/Index?conversion=CtoK&value=32
                    newvalue = value + 273.15;
                    return $"{conversion}: {value:.##} degrees Celcius is {newvalue:.##} Kelvin.";
                    break;
                case "FtoC":
                    //test url: https://localhost:5001/Converter/Index?conversion=FtoC&value=32
                    newvalue = (value - 32.0) / 1.8;
                    return $"{conversion}: {value:.##} degrees Fahrenheit is {newvalue:.##} Celcius.";
                    break;
                case "FtoK": 
                    //test url: https://localhost:5001/Converter/Index?conversion=FtoK&value=32
                    newvalue = (value + 459.67) * (5.0/9.0);
                    return $"{conversion}: {value:.##} degrees Fahrenheit is {newvalue:.##} Kelvin.";
                    break;
                case "KtoC":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoC&value=32
                    newvalue = value - 273.15;
                    return $"{conversion}: {value:.##} degrees Kelvin is {newvalue:.##} Celcius.";
                    break;
                case "KtoF":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoF&value=32
                    newvalue = (value * 1.8) - 459.67;
                    return $"{conversion}: {value:.##} degrees Kelvin is {newvalue:.##} Fahrenheit.";
                    break;
                //LENGTH CONVERSIONS
                case "MtoF":
                    //test url: https://localhost:5001/Converter/Index?conversion=MtoF&value=3
                    newvalue = value / 0.3048;
                    return $"{conversion}: {value:.##} meters is {newvalue:.##} feet.";
                    break;
                case "MtoY":
                    //test url: https://localhost:5001/Converter/Index?conversion=MtoY&value=3
                    newvalue = value * 1.0936;
                    return $"{conversion}: {value:.##} meters is {newvalue:.##} yards.";
                    break;
                case "FtoM":
                    //test url: https://localhost:5001/Converter/Index?conversion=FtoM&value=3
                    newvalue = value * 0.3048;
                    return $"{conversion}: {value:.##} feet is {newvalue:.##} meters.";
                    break;
                case "FtoY":
                    //test url: https://localhost:5001/Converter/Index?conversion=FtoY&value=3
                    newvalue = value * 0.3333;
                    return $"{conversion}: {value:.##} feet is {newvalue:.##} yards.";
                    break;
                case "YtoM":
                    //test url: https://localhost:5001/Converter/Index?conversion=YtoM&value=3
                    newvalue = value / 1.0936;
                    return $"{conversion}: {value:.##} yards is {newvalue:.##} meters.";
                    break;
                case "YtoF":
                    //test url: https://localhost:5001/Converter/Index?conversion=YtoF&value=3
                    newvalue = value * 3;
                    return $"{conversion}: {value:.##} yards is {newvalue:.##} feet.";
                    break;
                //MASS CONVERSIONS
                case "OtoP":
                    //test url: https://localhost:5001/Converter/Index?conversion=OtoP&value=15
                    newvalue = value * 0.0625;
                    return $"{conversion}: {value:.##} ounces is {newvalue:.##} pounds.";
                    break;
                case "OtoG":
                    //test url: https://localhost:5001/Converter/Index?conversion=OtoG&value=15
                    newvalue = value / 0.035274;
                    return $"{conversion}: {value:.##} ounces is {newvalue:.##} grams.";
                    break;
                case "OtoK":
                    //test url: https://localhost:5001/Converter/Index?conversion=OtoK&value=15
                    newvalue = value / 35.274;
                    return $"{conversion}: {value:.##} ounces is {newvalue:.##} kilograms.";
                    break;
                case "PtoO":
                    //test url: https://localhost:5001/Converter/Index?conversion=PtoO&value=30
                    newvalue = value * 16.00;
                    return $"{conversion}: {value:.##} pounds is {newvalue:.##} ounces.";
                    break;
                case "PtoG":
                    //test url: https://localhost:5001/Converter/Index?conversion=PtoG&value=30
                    newvalue = value / 0.0022046;
                    return $"{conversion}: {value:.##} pounds is {newvalue:.##} grams.";
                    break;
                case "PtoK":
                    //test url: https://localhost:5001/Converter/Index?conversion=PtoK&value=30
                    newvalue = value / 2.2046;
                    return $"{conversion}: {value:.##} pounds is {newvalue:.##} kilograms.";
                    break;
                case "GtoO":
                    //test url: https://localhost:5001/Converter/Index?conversion=GtoO&value=5000
                    newvalue = value / 28.34952;
                    return $"{conversion}: {value:.##} grams is {newvalue:.##} ounces.";
                    break;
                case "GtoP":
                    //test url: https://localhost:5001/Converter/Index?conversion=GtoP&value=5000
                    newvalue = value / 453.59237;
                    return $"{conversion}: {value:.##} grams is {newvalue:.##} pounds.";
                    break;
                case "GtoK":
                    //test url: https://localhost:5001/Converter/Index?conversion=GtoK&value=5000
                    newvalue = value / 1000.00;
                    return $"{conversion}: {value:.##} grams is {newvalue:.##} kilograms.";
                    break;
                case "KtoO":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoO&value=10
                    newvalue = value / 0.02834952;
                    return $"{conversion}: {value:.##} kilograms is {newvalue:.##} ounces.";
                    break;
                case "KtoP":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoP&value=10
                    newvalue = value / 0.45359237;
                    return $"{conversion}: {value:.##} kilograms is {newvalue:.##} pounds.";
                    break;
                case "KtoG":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoG&value=10
                    newvalue = value * 1000.00;
                    return $"{conversion}: {value:.##} kilograms is {newvalue:.##} grams.";
                    break;
                default:
                    return $"Something went wrong";
                    break;
            }
        }
    }
}