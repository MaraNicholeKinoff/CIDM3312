#pragma checksum "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\Calculator\Divide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b6e4ba3616d044d9932b2c5ec86cb2d137860d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Divide), @"mvc.1.0.view", @"/Views/Calculator/Divide.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Divide.cshtml", typeof(AspNetCore.Views_Calculator_Divide))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator;

#line default
#line hidden
#line 2 "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b6e4ba3616d044d9932b2c5ec86cb2d137860d", @"/Views/Calculator/Divide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c93cf8501ee692a6dcd53c1cb5152db45382f", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Divide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\Calculator\Divide.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 31, true);
            WriteLiteral("\r\n<h1>Division Result</h1>\r\n<p>");
            EndContext();
            BeginContext(59, 26, false);
#line 6 "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\Calculator\Divide.cshtml"
Write(ViewData["DivisionResult"]);

#line default
#line hidden
            EndContext();
            BeginContext(85, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\Calculator\Divide.cshtml"
  
    double left = Convert.ToDouble(ViewData["Left"]);
    double right = Convert.ToDouble(ViewData["Right"]);
    double result = Math.Round((left / right),2);

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
