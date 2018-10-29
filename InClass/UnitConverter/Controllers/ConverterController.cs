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
        public string Index(string type, string unitvalue)
        {
            return $"{type} and {unitvalue}";
        }
    }
}