#pragma checksum "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d937403eb51369bda21fe8cca04a853970d3d730"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incident_ViewIncidents), @"mvc.1.0.view", @"/Views/Incident/ViewIncidents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d937403eb51369bda21fe8cca04a853970d3d730", @"/Views/Incident/ViewIncidents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Incident_ViewIncidents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Corona_B.I.E.R_V1.Models.IncidentModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateIncident", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
  
    ViewData["Title"] = "ViewIncidents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewIncidents</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d937403eb51369bda21fe8cca04a853970d3d7303768", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.Employee_ID_CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.Employee_ID_EndedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.DateTimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.DateTimeEnded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Employee_ID_CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Employee_ID_EndedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateTimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateTimeEnded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.ID}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |<br/>\r\n                ");
#nullable restore
#line 83 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n                ");
#nullable restore
#line 84 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 87 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\ViewIncidents.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Corona_B.I.E.R_V1.Models.IncidentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
