#pragma checksum "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc1e46fc9d7403f1837c1390593eaafb5cdbd3f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hour_ViewHours), @"mvc.1.0.view", @"/Views/Hour/ViewHours.cshtml")]
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
#line 1 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\_ViewImports.cshtml"
using Corona_B.I.E.R_V1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc1e46fc9d7403f1837c1390593eaafb5cdbd3f9", @"/Views/Hour/ViewHours.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Hour_ViewHours : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Corona_B.I.E.R_V1.Models.ViewHourModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegisterHour", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
      
    Layout = "~/Views/Shared/_LayoutEmployeesView.cshtml";
    ViewData["Title"] = "ViewHours";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"content bg_white_block\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <h1>Beheer Uren</h1>\r\n            </div>\r\n            <div class=\"col-md-3 offset-3\">\r\n                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1e46fc9d7403f1837c1390593eaafb5cdbd3f94470", async() => {
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
            WriteLiteral(@"
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
#line 28 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 31 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 34 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayNameFor(model => model.StandbyHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 37 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayNameFor(model => model.IncidentHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 40 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        \r\n                        <th scope=\"col\">Beheer</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                     foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 57 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StandbyHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IncidentHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                         <td>\r\n\r\n                        ");
#nullable restore
#line 67 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Maik\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Hour\ViewHours.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table> \r\n\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Corona_B.I.E.R_V1.Models.ViewHourModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
