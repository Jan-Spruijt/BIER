#pragma checksum "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c65c4b7c84113fa50b816958fec82f6fc9e07366"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBar/Default.cshtml")]
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
#line 1 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65c4b7c84113fa50b816958fec82f6fc9e07366", @"/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Corona_B.I.E.R_V1.Models.EmployeeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "schedule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agenda", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link_style"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOutEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"logout\">\r\n    <li class=\"margin\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65c4b7c84113fa50b816958fec82f6fc9e073664947", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-calendar nav-icon\"></i>\r\n            <span class=\"nav-text\">\r\n                Planning maken\r\n            </span>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </li>
    <div class=""line""></div>
    <li class=""margin"">
        <a href=""../Employee/ViewEmployees"">
            <i class=""fa fa-users nav-icon""></i>
            <span class=""nav-text"">
                Gebruikers beheer
            </span>
        </a>
    </li>
    <div class=""line""></div>

    <div class=""table paddingtop"">
        <div class=""size_width user_img_container"">
            
");
#nullable restore
#line 26 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\SideBar\Default.cshtml"
                  
                    var photoPath = "../img/ProfilePictures/" + (Model.ProfilePicturePath ?? "DefaultUserPicture.png");
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"user_img\"");
            BeginWriteAttribute("src", " src=\"", 923, "\"", 939, 1);
#nullable restore
#line 29 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 929, photoPath, 929, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <p class=\"cell\">");
#nullable restore
#line 31 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\SideBar\Default.cshtml"
                   Write(Model.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\SideBar\Default.cshtml"
                                    Write(Model.Prefix);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Shared\Components\SideBar\Default.cshtml"
                                                  Write(Model.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <div class=\"table\">\r\n        <div class=\"size_width cell\"></div>\r\n        <div class=\"cell\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65c4b7c84113fa50b816958fec82f6fc9e073668852", async() => {
                WriteLiteral("\r\n                Uitloggen\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <p class=\"d-inline\"> | </p>\r\n            <a class=\"link_style\" href=\"#\">\r\n                Contact\r\n            </a>\r\n        </div>\r\n    </div>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Corona_B.I.E.R_V1.Models.EmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
