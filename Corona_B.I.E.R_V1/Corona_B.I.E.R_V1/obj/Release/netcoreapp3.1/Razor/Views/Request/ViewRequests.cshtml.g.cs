#pragma checksum "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f47bbe4723dba4f98ee94146dc61150ad2ef1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_ViewRequests), @"mvc.1.0.view", @"/Views/Request/ViewRequests.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
using Corona_B.I.E.R_V1.ExtensionMethods;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39749f9840d78002f3e59a49bcecb19c9ac03dc1", @"/Views/Request/ViewRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_ViewRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Corona_B.I.E.R_V1.Models.RequestModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
  
    ViewData["Title"] = "ViewRequests";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""content bg_white_block"">
    <div class=""row"">
        <div class=""col-md-6"">
            <h1>ViewRequests</h1>
        </div>
        <div class=""col-md-3 offset-3"">
            <p>
                <a class=""btn btn-lg btn-primary btn-block"" href=""../request/Selectrequest"">Create New</a>
            </p>
        </div>
    </div>
    <div class=""row"">
        <table class=""table table-striped"">
            <thead class=""thead-ligh"">
                <tr>
                    <th>
                        ");
#nullable restore
#line 17 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.Employeename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 20 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeAcceptedbyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.stringDateStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.stringDateEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.stringTimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.stringTimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 35 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 43 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.Employeename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeAcceptedbyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.stringDateStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.stringDateEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.stringTimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.stringTimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 64 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 67 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n\r\n");
#nullable restore
#line 71 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.ActionLink("Accept", "Accept", new { id = item.RequestId }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.RequestId }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.RequestId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            ");
#nullable restore
#line 76 "D:\Git\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Request\ViewRequests.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
