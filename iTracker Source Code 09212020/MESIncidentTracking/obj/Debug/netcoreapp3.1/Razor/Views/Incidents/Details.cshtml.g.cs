#pragma checksum "H:\MESIncidentTracking\Views\Incidents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab4940cd77730b32ccab38c65108b122699b827e"
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
#line 1 "H:\MESIncidentTracking\Views\_ViewImports.cshtml"
using ES13Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\MESIncidentTracking\Views\_ViewImports.cshtml"
using ES13Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4940cd77730b32ccab38c65108b122699b827e", @"/Views/Incidents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f444e84afe6bc9961e2f19b8070960e341cbc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Incidents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ES13Web.Models.Incident>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("duplicate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Duplicate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 32 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
   
    //limit the size of the incident description and action summary
    var incDesc = Model.IncidentDescription.Length > 350 ?
        Model.IncidentDescription.Substring(0, 346) + "..." :
        Model.IncidentDescription;
    var actSumm = Model.ActionSummary.Length > 350 ?
        Model.ActionSummary.Substring(0, 346) + "..." :
        Model.ActionSummary;
    var link = "Incident URL: http://" + Context.Request.Host + Context.Request.PathBase + Context.Request.Path;

    var desc = "Incident ID: " + Model.IncidentId + Environment.NewLine +
               "Engineer Name: " + Model.EngineerName + Environment.NewLine +
               "Short Description: " + Model.ShortDescription + Environment.NewLine +
               "Area Contact: " + Model.AreaContact + Environment.NewLine +
               String.Format("Est. Downtime (h): {0:0.00}", Model.EstimatedDownTimeHours) + Environment.NewLine +
               "Classification: " + Model.Classification.Name + Environment.NewLine +
               "Incident Description: " + incDesc + Environment.NewLine +
               "Action Summary: " + actSumm + Environment.NewLine + Environment.NewLine +
               link;
    var emailBody = System.Uri.EscapeDataString(desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Incident Details</h2>\r\n\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 col-lg-10\">\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
#nullable restore
#line 65 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IncidentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 68 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.IncidentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Created</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 72 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.FormattedLocalCreatedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Last Modified</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 76 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.FormattedLocalLastModifiedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Activity Performed</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 80 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.FormattedLocalActivityPerformedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 83 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 86 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 89 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 92 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Manufacturing Area</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 96 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.ManufacturingArea.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 99 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.AreaContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 102 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.AreaContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 105 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.EstimatedDownTimeHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 108 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.EstimatedDownTimeHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>Engn. Time (hours)</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 112 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.EngineeringTimeHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 115 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ClassificationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 118 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.Classification.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 121 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IncidentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 124 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.IncidentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 127 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ActionSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 130 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.ActionSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 133 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.HandoffWork));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 136 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.HandoffWork));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 139 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Resolved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 142 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.CheckBox("Resolved", Model.Resolved ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 145 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.RequireES13));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 148 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.CheckBox("RequireES13", Model.RequireES13 ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 152 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.WerumTicket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 155 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.WerumTicket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 158 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.WerumTicketResolved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 161 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.CheckBox("WerumTicketResolved", Model.WerumTicketResolved ?? false, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 164 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.WerumTicketSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 167 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.WerumTicketSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>BT Service Request</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 172 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.BTServiceRequestNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>BT Service Summary</dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 177 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.BTServiceRequestSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            \r\n            <dt>\r\n                ");
#nullable restore
#line 181 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.BatchNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 184 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.BatchNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            \r\n            <dt>\r\n                ");
#nullable restore
#line 188 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Escalation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 191 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
           Write(Html.DisplayFor(model => model.Escalation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n\r\n");
#nullable restore
#line 199 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
     if(User.Identity.Name.Equals(Model.UserId, StringComparison.CurrentCultureIgnoreCase) || (await AuthorizationService.AuthorizeAsync(User, "RequireAdministratorRole")).Succeeded)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4940cd77730b32ccab38c65108b122699b827e19056", async() => {
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
#line 201 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
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
#line 203 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 204 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
     if ((await AuthorizationService.AuthorizeAsync(User, "RequireAdministratorRole")).Succeeded)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4940cd77730b32ccab38c65108b122699b827e21631", async() => {
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
#line 206 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
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
#line 208 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4940cd77730b32ccab38c65108b122699b827e23963", async() => {
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
#line 209 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 8084, "\"", 8140, 2);
            WriteAttributeValue("", 8091, "mailto:?subject=Incident%20Report&body=", 8091, 39, true);
#nullable restore
#line 210 "H:\MESIncidentTracking\Views\Incidents\Details.cshtml"
WriteAttributeValue("", 8130, emailBody, 8130, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Email Incident</a> |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4940cd77730b32ccab38c65108b122699b827e26667", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ES13Web.Models.Incident> Html { get; private set; }
    }
}
#pragma warning restore 1591
