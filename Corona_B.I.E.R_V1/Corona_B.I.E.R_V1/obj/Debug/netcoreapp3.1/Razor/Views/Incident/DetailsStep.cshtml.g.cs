#pragma checksum "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f142f8a8061b1af5bea1ee294068d5c2ec8daea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incident_DetailsStep), @"mvc.1.0.view", @"/Views/Incident/DetailsStep.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f142f8a8061b1af5bea1ee294068d5c2ec8daea8", @"/Views/Incident/DetailsStep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Incident_DetailsStep : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Corona_B.I.E.R_V1.Models.IncidentStepDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
  
    ViewData["Title"] = "DetailsStep";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DetailsStep</h1>\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.employee_id_createdby));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.employee_id_createdby));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.employee_id_endedby));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.employee_id_endedby));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.incident_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.incident_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.stepnumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.stepnumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.datetimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.datetimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.datetimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.datetimeEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Voornaam
            </th>
            <th>
                Achternaam
            </th>
            <th>
                Foto
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 82 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
         foreach (var item in Model.employee)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
               Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 92 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProfilePicturePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 95 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
               Write(Html.ActionLink("Remove", "Delete", new {/* id=item.PrimaryKey */}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 98 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
#nullable restore
#line 102 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
Write(Html.ActionLink("Close", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 103 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsStep.cshtml"
Write(Html.ActionLink("Voeg medewerker toe", "AddEmployeeToStep", new {id = Model.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f142f8a8061b1af5bea1ee294068d5c2ec8daea812520", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Corona_B.I.E.R_V1.Models.IncidentStepDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591