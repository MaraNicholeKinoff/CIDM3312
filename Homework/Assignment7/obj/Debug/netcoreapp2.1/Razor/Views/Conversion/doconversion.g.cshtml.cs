#pragma checksum "C:\Users\maram\Desktop\Fall2018\CIDM3312\Homework\Assignment7\Views\Conversion\doconversion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd95fb5baa15c4b58e1900f81d598981dc4d7b01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conversion_doconversion), @"mvc.1.0.view", @"/Views/Conversion/doconversion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conversion/doconversion.cshtml", typeof(AspNetCore.Views_Conversion_doconversion))]
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
#line 1 "C:\Users\maram\Desktop\Fall2018\CIDM3312\Homework\Assignment7\Views\_ViewImports.cshtml"
using Assignment7;

#line default
#line hidden
#line 2 "C:\Users\maram\Desktop\Fall2018\CIDM3312\Homework\Assignment7\Views\_ViewImports.cshtml"
using Assignment7.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd95fb5baa15c4b58e1900f81d598981dc4d7b01", @"/Views/Conversion/doconversion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20166ba8124ef534adc515f8de4b4d236a903b29", @"/Views/_ViewImports.cshtml")]
    public class Views_Conversion_doconversion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConverterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 117, true);
            WriteLiteral("\r\n<h1>Conversion Results</h1>\r\n <div class=\"row\">\r\n  <div class=\"column\"></div>\r\n    <h2>Original Value</h2>\r\n    <p>");
            EndContext();
            BeginContext(145, 20, false);
#line 7 "C:\Users\maram\Desktop\Fall2018\CIDM3312\Homework\Assignment7\Views\Conversion\doconversion.cshtml"
  Write(Model.ValueToConvert);

#line default
#line hidden
            EndContext();
            BeginContext(165, 76, true);
            WriteLiteral("</p>\r\n  <div class=\"column\"></div>\r\n    <h2>Type of Conversion</h2>\r\n    <p>");
            EndContext();
            BeginContext(242, 20, false);
#line 10 "C:\Users\maram\Desktop\Fall2018\CIDM3312\Homework\Assignment7\Views\Conversion\doconversion.cshtml"
  Write(Model.ConversionType);

#line default
#line hidden
            EndContext();
            BeginContext(262, 73, true);
            WriteLiteral("</p>\r\n  <div class=\"column\"></div>\r\n    <h2>Converted Value</h2>\r\n    <p>");
            EndContext();
            BeginContext(336, 20, false);
#line 13 "C:\Users\maram\Desktop\Fall2018\CIDM3312\Homework\Assignment7\Views\Conversion\doconversion.cshtml"
  Write(Model.ConvertedValue);

#line default
#line hidden
            EndContext();
            BeginContext(356, 13, true);
            WriteLiteral("</p>\r\n</div> ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConverterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
