#pragma checksum "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85fbf4dc070e20903bb04c5b3ee5e3cf1821ff9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Details), @"mvc.1.0.view", @"/Views/Request/Details.cshtml")]
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
#line 1 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85fbf4dc070e20903bb04c5b3ee5e3cf1821ff9d", @"/Views/Request/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Corona_B.I.E.R_V1.Models.RequestModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
  
    ViewData["Title"] = "RequestDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>RequestDetails</h1>\r\n\r\n<div>\r\n    <h4>RequestModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employeename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employeename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeAcceptedbyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeAcceptedbyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\Details.cshtml"
       Write(Html.DisplayFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a href=\"../../request/viewrequests\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Corona_B.I.E.R_V1.Models.RequestModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
