#pragma checksum "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61832e37f469aa5f247fdb105956c292d53911dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RequestDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RequestDashboard/Default.cshtml")]
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
#nullable restore
#line 1 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61832e37f469aa5f247fdb105956c292d53911dc", @"/Views/Shared/Components/RequestDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RequestDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Corona_B.I.E.R_V1.Models.RequestModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 8 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.stringDateStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 11 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 14 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeAcceptedbyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.stringDateStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeAcceptedbyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
           Write(Html.ActionLink("Details", "Details", "Request", new { id = item.RequestId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\RequestDashboard\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Corona_B.I.E.R_V1.Models.RequestModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
