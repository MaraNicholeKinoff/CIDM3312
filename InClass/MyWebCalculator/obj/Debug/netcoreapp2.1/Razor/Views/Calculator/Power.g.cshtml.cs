#pragma checksum "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\Calculator\Power.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d98859cb79224048dce69e31d249d0df8e191f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Power), @"mvc.1.0.view", @"/Views/Calculator/Power.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Power.cshtml", typeof(AspNetCore.Views_Calculator_Power))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d98859cb79224048dce69e31d249d0df8e191f40", @"/Views/Calculator/Power.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c93cf8501ee692a6dcd53c1cb5152db45382f", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Power : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\Calculator\Power.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 28, true);
            WriteLiteral("\r\n<h1>Power Result</h1>\r\n<p>");
            EndContext();
            BeginContext(56, 23, false);
#line 6 "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\Calculator\Power.cshtml"
Write(ViewData["PowerResult"]);

#line default
#line hidden
            EndContext();
            BeginContext(79, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\maram\Desktop\Fall2018\CIDM3312\InClass\MyWebCalculator\Views\Calculator\Power.cshtml"
  
    double num = Convert.ToDouble(ViewData["Num"]);
    double power = Convert.ToDouble(ViewData["Power"]);
    double result = Math.Round((Math.Pow(num, power)),2);

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