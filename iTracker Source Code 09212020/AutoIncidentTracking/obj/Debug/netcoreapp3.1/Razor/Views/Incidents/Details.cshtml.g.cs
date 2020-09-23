#pragma checksum "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b5a985b13b8035a6df362a21063949670853603"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incidents_Details), @"mvc.1.0.view", @"/Views/Incidents/Details.cshtml")]
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
#line 1 "H:\AutoIncidentTracking\Views\_ViewImports.cshtml"
using IncidentTracking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\AutoIncidentTracking\Views\_ViewImports.cshtml"
using IncidentTracking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5a985b13b8035a6df362a21063949670853603", @"/Views/Incidents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f795bc73ab22dff54ea51d3e61462dd07486b2b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Incidents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IncidentTracking.Models.Incident>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("duplicate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Duplicate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 32 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
   
    var incDesc = Model.IncidentDescription.Length > 350 ?
        Model.IncidentDescription.Substring(0, 346) + "..." :
        Model.IncidentDescription;
    var actSumm = Model.ActionSummary.Length > 350 ?
        Model.ActionSummary.Substring(0, 346) + "..." :
        Model.ActionSummary;
    var link = "Incident URL: http://" + Context.Request.Host + Context.Request.PathBase + Context.Request.Path;

    var desc = "Incident ID: " + Model.IncidentId + Environment.NewLine +
               "Short Description: " + Model.ShortDescription + Environment.NewLine +
               "Engineer Name: " + Model.EngineerName + Environment.NewLine +
               "Area Contact: " + Model.AreaContact + Environment.NewLine +
               String.Format("Est. Downtime (h): {0:0.00}", Model.EstimatedDownTimeHours) + Environment.NewLine +
               "Classification: " + Model.Classification.Name + Environment.NewLine +
               "Incident Description: " + incDesc + Environment.NewLine +
               "Action Summary: " + actSumm + Environment.NewLine + Environment.NewLine +
               link;
    var log = "Log Number: " + Model.LogNumber + Environment.NewLine;
    var body = ((Model.LogNumber != "N/A") ? log + Environment.NewLine + desc : desc);
    var emailBody = System.Uri.EscapeDataString(body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Incident Details</h2>\r\n\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 col-lg-8\">\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
#nullable restore
#line 66 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IncidentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 69 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.IncidentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Created</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 73 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.FormattedLocalCreatedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Last Modified</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 77 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.FormattedLocalLastModifiedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Activity Performed</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 81 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.FormattedLocalActivityPerformedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 84 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 87 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 90 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 93 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Manufacturing Area</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 97 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.ManufacturingArea.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 100 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ControlSystem.ControlSystemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 103 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.ControlSystem.ControlSystemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 106 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.AreaContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 109 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.AreaContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 112 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.EstimatedDownTimeHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 115 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.EstimatedDownTimeHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Engn. Time (hours)</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 119 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.EngineeringTimeHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Classification</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 123 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.Classification.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 126 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Resolved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 129 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.CheckBox("Resolved", Model.Resolved ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 132 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.HandoffWork));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 135 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.HandoffWork));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 138 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.RequireES11));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 141 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.CheckBox("RequireES11", Model.RequireES11 ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 144 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IncidentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 147 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.IncidentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 150 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ActionSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 153 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.ActionSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>BT Service Request</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 157 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.BTServiceRequestNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>BT Service Summary</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 161 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.BTServiceRequestSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 164 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Escalation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 167 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.Escalation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n");
#nullable restore
#line 171 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
     if (Model.RequireES11.HasValue && Model.RequireES11.Value)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4 col-lg-4\">\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>Log Number</dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 177 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayFor(model => model.LogNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 180 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ActivityTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 183 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.Label("ActivityType.Description", Model.ActivityType == null ? "-" : Model.ActivityType.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 186 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ImpactSafety));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 189 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.CheckBox("ImpactSafety", Model.ImpactSafety ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 192 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ImpactQuality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 195 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.CheckBox("ImpactQuality", Model.ImpactQuality ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 198 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ImpactValidation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 201 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.CheckBox("ImpactValidation", Model.ImpactValidation ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 204 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequirePreApproval));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 207 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.CheckBox("RequirePreApproval", Model.RequirePreApproval ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 210 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequireManagerApproval));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 213 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.CheckBox("RequireManagerApproval", Model.RequireManagerApproval ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 216 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequireTagOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 219 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.CheckBox("RequireTagOut", Model.RequireTagOut ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 222 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PRNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 225 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayFor(model => model.PRNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 228 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TagOutNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 231 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayFor(model => model.TagOutNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 234 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.SystemSpecifications));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 237 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayFor(model => model.SystemSpecifications));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 240 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Drawings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 243 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayFor(model => model.Drawings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 246 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.LotNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 249 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayFor(model => model.LotNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 252 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ProgramComparisonMade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 255 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.CheckBox("ProgramComparisonMade", Model.ProgramComparisonMade ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
#nullable restore
#line 258 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ActivityComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
#nullable restore
#line 261 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
               Write(Html.CheckBox("ActivityComplete", Model.ActivityComplete ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n\r\n        </div>\r\n");
#nullable restore
#line 266 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>\r\n");
#nullable restore
#line 270 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
     if(User.Identity.Name.Equals(Model.UserId, StringComparison.CurrentCultureIgnoreCase) || (await AuthorizationService.AuthorizeAsync(User, "RequireAdministratorRole")).Succeeded)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b5a985b13b8035a6df362a2106394967085360327573", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 272 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
                               WriteLiteral(Model.IncidentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n        <span>|</span>\r\n");
#nullable restore
#line 274 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 275 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
     if ((await AuthorizationService.AuthorizeAsync(User, "RequireAdministratorRole")).Succeeded)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b5a985b13b8035a6df362a2106394967085360330151", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 277 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
                                 WriteLiteral(Model.IncidentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <span>|</span>\r\n");
#nullable restore
#line 279 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b5a985b13b8035a6df362a2106394967085360332485", async() => {
                WriteLiteral("Duplicate");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 280 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
                                               WriteLiteral(Model.IncidentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 11508, "\"", 11564, 2);
            WriteAttributeValue("", 11515, "mailto:?subject=Incident%20Report&body=", 11515, 39, true);
#nullable restore
#line 281 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
WriteAttributeValue("", 11554, emailBody, 11554, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Email Incident</a>  |\r\n");
#nullable restore
#line 282 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
     if (Model.RequireES11.HasValue && Model.RequireES11.Value)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b5a985b13b8035a6df362a2106394967085360335442", async() => {
                WriteLiteral("Form");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 284 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
                                      WriteLiteral(Model.IncidentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <span> | </span>\r\n");
#nullable restore
#line 286 "H:\AutoIncidentTracking\Views\Incidents\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b5a985b13b8035a6df362a2106394967085360337781", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    $(\"#duplicate\").click(function () {\r\n        var dt = new Date().toISOString();\r\n\r\n        var ref = $(this).attr(\"href\");\r\n        $(this).attr(\"href\", ref + \"?date=\" + dt);\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IncidentTracking.Models.Incident> Html { get; private set; }
    }
}
#pragma warning restore 1591
