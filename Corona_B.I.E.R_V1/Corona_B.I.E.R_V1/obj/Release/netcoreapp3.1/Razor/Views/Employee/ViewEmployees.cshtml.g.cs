#pragma checksum "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdea514c14ba584facd94103b1d83ec8a9a3e1fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ViewEmployees), @"mvc.1.0.view", @"/Views/Employee/ViewEmployees.cshtml")]
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
#line 1 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdea514c14ba584facd94103b1d83ec8a9a3e1fb", @"/Views/Employee/ViewEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ViewEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Corona_B.I.E.R_V1.Models.EmployeeModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegisterEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
  
    Layout = "~/Views/Shared/_LayoutEmployeesView.cshtml";
    ViewData["Title"] = "ViewEmployees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content bg_white_block\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <h1>Beheer Werknemers</h1>\r\n        </div>\r\n        <div class=\"col-md-3 offset-3\">\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdea514c14ba584facd94103b1d83ec8a9a3e1fb4490", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        \r\n    </div>\r\n\r\n    <div class=\"row\">\r\n\r\n\r\n        <table class=\"table table-striped\">\r\n            <thead class=\"thead-ligh\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 28 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.Prefix));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 34 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 37 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 40 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.Postalcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 43 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 46 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 49 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 52 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.Profession));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 55 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                   Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">Beheer</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 61 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 68 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prefix));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 77 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Postalcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 80 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 83 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 86 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 89 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Profession));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 92 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 95 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n                            ");
#nullable restore
#line 96 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n                            ");
#nullable restore
#line 97 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 100 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Employee\ViewEmployees.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Corona_B.I.E.R_V1.Models.EmployeeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
