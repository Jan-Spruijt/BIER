#pragma checksum "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "941311c7bcdb6f56e3f084433064d67b21438055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IncidentStep_DetailsStep), @"mvc.1.0.view", @"/Views/IncidentStep/DetailsStep.cshtml")]
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
#nullable restore
#line 1 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
using Corona_B.I.E.R_V1.ExtensionMethods;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"941311c7bcdb6f56e3f084433064d67b21438055", @"/Views/IncidentStep/DetailsStep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1d5b3fe91d0c9aedbf4c4df65d917f00b093a1", @"/Views/_ViewImports.cshtml")]
    public class Views_IncidentStep_DetailsStep : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Corona_B.I.E.R_V1.Models.IncidentStepDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "DetailsStep";
    bool isWorkingOn = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DRoze\Documents\school\githubBier\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
 foreach (var employee in Model.employee)
{
    if (Context.GetCurrentEmployeeModel().Id == employee.Id)
    {
        isWorkingOn = true;
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details Stap</h1>\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.incident_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.incident_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
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
#line 61 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
         foreach (var item in Model.employee)
        {
            var photoPath = "wwwroot/img/ProfilePictures/" + (item.ProfilePicturePath ?? "DefaultUserPicture.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
               Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2022, "\"", 2038, 1);
#nullable restore
#line 72 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
WriteAttributeValue("", 2028, photoPath, 2028, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 78 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
 if (Model.status == "pending")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 81 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
   Write(Html.ActionLink("Begin stap", "StartStep", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        ");
#nullable restore
#line 82 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
   Write(Html.ActionLink("Terug naar incident", "DetailsIncident", "Incident", new { id = Model.incident_id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 84 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
 if (Model.status == "busy")
{
    if (isWorkingOn)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            ");
#nullable restore
#line 90 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.ActionLink("Sluit stap", "CloseStep", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 91 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.ActionLink("Stop werken", "RemoveEmployeeFromStep", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 92 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.ActionLink("Terug naar incident", "DetailsIncident", "incident", new { id = Model.incident_id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 94 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            ");
#nullable restore
#line 98 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.ActionLink("Close", "CloseStep", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 99 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.ActionLink("Werk mee", "AddEmployeeToStep", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 100 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
       Write(Html.ActionLink("Terug naar incident", "DetailsIncident", "incident", new { id = Model.incident_id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 102 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
    }
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
 if (Model.status == "done")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 107 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
   Write(Html.ActionLink("Terug naar incident", "DetailsIncident", "Incident", new { id = Model.incident_id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 109 "C:\Users\gijs\Documents\GitHub\BIER\Corona_B.I.E.R_V1\Corona_B.I.E.R_V1\Views\IncidentStep\DetailsStep.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
