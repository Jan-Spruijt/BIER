#pragma checksum "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8edf55035c9fd6fa3d84eb85ca4c7767a9544830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incident_DetailsIncidentold), @"mvc.1.0.view", @"/Views/Incident/DetailsIncidentold.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8edf55035c9fd6fa3d84eb85ca4c7767a9544830", @"/Views/Incident/DetailsIncidentold.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Incident_DetailsIncidentold : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Corona_B.I.E.R_V1.Models.IncidentModel>
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
#line 3 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
  
    ViewData["Title"] = "DetailsIncident";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DetailsIncident</h1>\r\n\r\n<div>\r\n    <h4>IncidentModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee_ID_CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.Employee_ID_CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee_ID_EndedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.Employee_ID_EndedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.DateTimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.DateTimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.DateTimeEnded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.DateTimeEnded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 76 "D:\github\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncidentold.cshtml"
Write(Html.ActionLink("Edit", "CloseIncident", new { id=Model.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8edf55035c9fd6fa3d84eb85ca4c7767a954483010893", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Corona_B.I.E.R_V1.Models.IncidentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
