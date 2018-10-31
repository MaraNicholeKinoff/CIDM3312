using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
using UnitConverter.ConvertLib;

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
                    newvalue = UnitConverter.ConvertLib.CtoF.CtoFConvertTemp(value);
                    return $"{conversion}: {value:.##} degrees Celcius is {newvalue:.##} Fahrenheit.";
                    break;
                case "CtoK":
                    //test url: https://localhost:5001/Converter/Index?conversion=CtoK&value=32
                    newvalue = UnitConverter.ConvertLib.CtoK.CtoKConvertTemp(value);
                    return $"{conversion}: {value:.##} degrees Celcius is {newvalue:.##} Kelvin.";
                    break;
                case "FtoC":
                    //test url: https://localhost:5001/Converter/Index?conversion=FtoC&value=32
                    newvalue = UnitConverter.ConvertLib.FtoC.FtoCConvertTemp(value);
                    return $"{conversion}: {value:.##} degrees Fahrenheit is {newvalue:.##} Celcius.";
                    break;
                case "FtoK": 
                    //test url: https://localhost:5001/Converter/Index?conversion=FtoK&value=32
                    newvalue = UnitConverter.ConvertLib.FtoK.FtoKConvertTemp(value);
                    return $"{conversion}: {value:.##} degrees Fahrenheit is {newvalue:.##} Kelvin.";
                    break;
                case "KtoC":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoC&value=32
                    newvalue = UnitConverter.ConvertLib.KtoC.KtoCConvertTemp(value);
                    return $"{conversion}: {value:.##} degrees Kelvin is {newvalue:.##} Celcius.";
                    break;
                case "KtoF":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoF&value=32
                    newvalue = UnitConverter.ConvertLib.KtoF.KtoFConvertTemp(value);
                    return $"{conversion}: {value:.##} degrees Kelvin is {newvalue:.##} Fahrenheit.";
                    break;
                //LENGTH CONVERSIONS
                case "MtoF":
                    //test url: https://localhost:5001/Converter/Index?conversion=MtoF&value=3
                    newvalue = UnitConverter.ConvertLib.MtoF.MtoFConvertLength(value);
                    return $"{conversion}: {value:.##} meters is {newvalue:.##} feet.";
                    break;
                case "MtoY":
                    //test url: https://localhost:5001/Converter/Index?conversion=MtoY&value=3
                    newvalue = UnitConverter.ConvertLib.MtoY.MtoYConvertLength(value);
                    return $"{conversion}: {value:.##} meters is {newvalue:.##} yards.";
                    break;
                case "FtoM":
                    //test url: https://localhost:5001/Converter/Index?conversion=FtoM&value=3
                    newvalue = UnitConverter.ConvertLib.FtoM.FtoMConvertLength(value);
                    return $"{conversion}: {value:.##} feet is {newvalue:.##} meters.";
                    break;
                case "FtoY":
                    //test url: https://localhost:5001/Converter/Index?conversion=FtoY&value=3
                    newvalue = UnitConverter.ConvertLib.FtoY.FtoYConvertLength(value);
                    return $"{conversion}: {value:.##} feet is {newvalue:.##} yards.";
                    break;
                case "YtoM":
                    //test url: https://localhost:5001/Converter/Index?conversion=YtoM&value=3
                    newvalue = UnitConverter.ConvertLib.YtoM.YtoMConvertLength(value);
                    return $"{conversion}: {value:.##} yards is {newvalue:.##} meters.";
                    break;
                case "YtoF":
                    //test url: https://localhost:5001/Converter/Index?conversion=YtoF&value=3
                    newvalue = UnitConverter.ConvertLib.YtoF.YtoFConvertLength(value);
                    return $"{conversion}: {value:.##} yards is {newvalue:.##} feet.";
                    break;
                //MASS CONVERSIONS
                case "OtoP":
                    //test url: https://localhost:5001/Converter/Index?conversion=OtoP&value=15
                    newvalue = UnitConverter.ConvertLib.OtoP.OtoPConvertMass(value);
                    return $"{conversion}: {value:.##} ounces is {newvalue:.##} pounds.";
                    break;
                case "OtoG":
                    //test url: https://localhost:5001/Converter/Index?conversion=OtoG&value=15
                    newvalue = UnitConverter.ConvertLib.OtoG.OtoGConvertMass(value);
                    return $"{conversion}: {value:.##} ounces is {newvalue:.##} grams.";
                    break;
                case "OtoK":
                    //test url: https://localhost:5001/Converter/Index?conversion=OtoK&value=15
                    newvalue = UnitConverter.ConvertLib.OtoK.OtoKConvertMass(value);
                    return $"{conversion}: {value:.##} ounces is {newvalue:.##} kilograms.";
                    break;
                case "PtoO":
                    //test url: https://localhost:5001/Converter/Index?conversion=PtoO&value=30
                    newvalue = UnitConverter.ConvertLib.PtoO.PtoOConvertMass(value);
                    return $"{conversion}: {value:.##} pounds is {newvalue:.##} ounces.";
                    break;
                case "PtoG":
                    //test url: https://localhost:5001/Converter/Index?conversion=PtoG&value=30
                    newvalue = UnitConverter.ConvertLib.PtoG.PtoGConvertMass(value);
                    return $"{conversion}: {value:.##} pounds is {newvalue:.##} grams.";
                    break;
                case "PtoK":
                    //test url: https://localhost:5001/Converter/Index?conversion=PtoK&value=30
                    newvalue = UnitConverter.ConvertLib.PtoK.PtoKConvertMass(value);
                    return $"{conversion}: {value:.##} pounds is {newvalue:.##} kilograms.";
                    break;
                case "GtoO":
                    //test url: https://localhost:5001/Converter/Index?conversion=GtoO&value=5000
                    newvalue = UnitConverter.ConvertLib.GtoO.GtoOConvertMass(value);
                    return $"{conversion}: {value:.##} grams is {newvalue:.##} ounces.";
                    break;
                case "GtoP":
                    //test url: https://localhost:5001/Converter/Index?conversion=GtoP&value=5000
                    newvalue = UnitConverter.ConvertLib.GtoP.GtoPConvertMass(value);
                    return $"{conversion}: {value:.##} grams is {newvalue:.##} pounds.";
                    break;
                case "GtoK":
                    //test url: https://localhost:5001/Converter/Index?conversion=GtoK&value=5000
                    newvalue = UnitConverter.ConvertLib.GtoK.GtoKConvertMass(value);
                    return $"{conversion}: {value:.##} grams is {newvalue:.##} kilograms.";
                    break;
                case "KtoO":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoO&value=10
                    newvalue = UnitConverter.ConvertLib.KtoO.KtoOConvertMass(value);
                    return $"{conversion}: {value:.##} kilograms is {newvalue:.##} ounces.";
                    break;
                case "KtoP":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoP&value=10
                    newvalue = UnitConverter.ConvertLib.KtoP.KtoPConvertMass(value);
                    return $"{conversion}: {value:.##} kilograms is {newvalue:.##} pounds.";
                    break;
                case "KtoG":
                    //test url: https://localhost:5001/Converter/Index?conversion=KtoG&value=10
                    newvalue = UnitConverter.ConvertLib.KtoG.KtoGConvertMass(value);
                    return $"{conversion}: {value:.##} kilograms is {newvalue:.##} grams.";
                    break;
                default:
                    return $"Something went wrong";
                    break;
            }
        }
    }
}