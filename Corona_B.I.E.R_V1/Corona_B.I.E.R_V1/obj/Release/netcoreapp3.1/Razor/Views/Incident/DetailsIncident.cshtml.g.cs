#pragma checksum "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d65ae6bc81637e69943a21d0c4e2eb6403550bb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incident_DetailsIncident), @"mvc.1.0.view", @"/Views/Incident/DetailsIncident.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
using System.Transactions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
using Corona_B.I.E.R_V1.ExtensionMethods;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d65ae6bc81637e69943a21d0c4e2eb6403550bb1", @"/Views/Incident/DetailsIncident.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Incident_DetailsIncident : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Corona_B.I.E.R_V1.Models.IncidentDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewIncidents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "DetailsIncident";
    bool status = true;
    bool isworkingon = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
 foreach (var step in Model.steps)
{
    if (step.status != "done")
    {
        status = false;
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
 foreach (var employee in Model.employees)
{
    if (Context.GetCurrentEmployeeModel().Id == employee.Id)
    {
        isworkingon = true;
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>DetailsIncident</h1>\r\n\r\n\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayNameFor(model => model.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayFor(model => model.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
       Write(Html.DisplayFor(model => model.Status));

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
                Titel
            </th>
            <th>
                Stapnummer
            </th>
            <th>
                Status
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 79 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
         foreach (var item in Model.steps)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
               Write(Html.DisplayFor(modelItem => item.context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
               Write(Html.DisplayFor(modelItem => item.stepnumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
               Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 92 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
               Write(Html.ActionLink("Details", "DetailsStep","IncidentStep", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 93 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
               Write(Html.ActionLink("Delete", "DeleteStep", "IncidentStep" ,new {id = item.id, incident_Id = Model.id}, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 96 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n");
#nullable restore
#line 100 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
     if (Model.Status == "open")
    {
        if (status == false)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                ");
#nullable restore
#line 105 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
           Write(Html.ActionLink("Voeg stap toe", "CreateStep","IncidentStep", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d65ae6bc81637e69943a21d0c4e2eb6403550bb112223", async() => {
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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 108 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                ");
#nullable restore
#line 112 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
           Write(Html.ActionLink("Close", "CloseIncident", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 113 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
           Write(Html.ActionLink("Voeg stap toe", "CreateStep","IncidentStep", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d65ae6bc81637e69943a21d0c4e2eb6403550bb114383", async() => {
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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 116 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
     if (Model.Status == "closed")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d65ae6bc81637e69943a21d0c4e2eb6403550bb116072", async() => {
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
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 123 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<h5>Werknemers</h5>\r\n<div>\r\n");
#nullable restore
#line 128 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
     foreach (var item in Model.employees)
    {
        var photoPath = "img/ProfilePictures/" + (item.ProfilePicturePath ?? "DefaultUserPicture.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <span>");
#nullable restore
#line 132 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
             Write(item.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 132 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
                             Write(item.Prefix);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 132 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
                                          Write(item.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d65ae6bc81637e69943a21d0c4e2eb6403550bb118788", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3767, "~/", 3767, 2, true);
#nullable restore
#line 133 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
AddHtmlAttributeValue("", 3769, photoPath, 3769, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 135 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 137 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
 if (isworkingon == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 140 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
   Write(Html.ActionLink("Begin werken aan incident", "AddEmployeeToIncident", new {id = Model.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 142 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 146 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
   Write(Html.ActionLink("Stop werken aan incident", "RemoveEmployeeFromIncident", new {id = Model.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 148 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\Incident\DetailsIncident.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Corona_B.I.E.R_V1.Models.IncidentDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
