#pragma checksum "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e40013ad7877a8aceb9e062c4122d1db1964f6f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(JobRanger.Pages.Employer.Pages_Employer_Index), @"mvc.1.0.razor-page", @"/Pages/Employer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employer/Index.cshtml", typeof(JobRanger.Pages.Employer.Pages_Employer_Index), null)]
namespace JobRanger.Pages.Employer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\_ViewImports.cshtml"
using JobRanger;

#line default
#line hidden
#line 3 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\_ViewImports.cshtml"
using JobRanger.Data;

#line default
#line hidden
#line 2 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
using System.Diagnostics;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e40013ad7877a8aceb9e062c4122d1db1964f6f9", @"/Pages/Employer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68a822ad2a8e1ef3467423615f697fe3ed6f12d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employer_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Job/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Contacts/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
  
    ViewData["Title"] = "Employer";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(172, 76, true);
            WriteLiteral("\r\n<h3 class=\"display-3\">\r\n    <strong>Employers</strong>\r\n</h3>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(248, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40013ad7877a8aceb9e062c4122d1db1964f6f95741", async() => {
                BeginContext(269, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(283, 43, true);
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"container-fluid\">\r\n\r\n");
            EndContext();
#line 20 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
     foreach (var item in Model.AppUser.Employers.OrderBy(e => e.Name))
    {
        if (item.Name.Trim().Contains(" "))
        {

#line default
#line hidden
            BeginContext(462, 126, true);
            WriteLiteral("            <a class=\"btn btn-light p-1 m-1 agency-card\" style=\"box-shadow: 4px 4px rgb(172, 105, 177)\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 588, "\"", 645, 2);
            WriteAttributeValue("", 595, "#", 595, 1, true);
#line 24 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
WriteAttributeValue("", 596, item.Name.Trim().Remove(item.Name.IndexOf(" " )), 596, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(646, 36, true);
            WriteLiteral(" role=\"button\" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 682, "\"", 746, 1);
#line 24 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
WriteAttributeValue("", 698, item.Name.Trim().Remove(item.Name.IndexOf(" ")), 698, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(747, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(749, 35, false);
#line 24 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                                                                                                                                                                                                                                                                         Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(784, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 25 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(826, 126, true);
            WriteLiteral("            <a class=\"btn btn-light p-1 m-1 agency-card\" style=\"box-shadow: 4px 4px rgb(172, 105, 177)\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 952, "\"", 970, 2);
            WriteAttributeValue("", 959, "#", 959, 1, true);
#line 28 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
WriteAttributeValue("", 960, item.Name, 960, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(971, 36, true);
            WriteLiteral(" role=\"button\" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1007, "\"", 1033, 1);
#line 28 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
WriteAttributeValue("", 1023, item.Name, 1023, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1034, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1036, 35, false);
#line 28 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                                                                                                                                                                                            Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 29 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(1090, 37, true);
            WriteLiteral("        <div class=\"collapse p-4 m-4\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1127, "", 1220, 1);
#line 31 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
WriteAttributeValue("", 1131, item.Name.Contains(" ") ? item.Name.Trim().Remove(item.Name.IndexOf(" ") ) : item.Name, 1131, 89, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1220, 199, true);
            WriteLiteral(">\r\n            <div class=\"card m-1 p-1\" style=\"display: inline-block; width: auto;\">\r\n                <div class=\"card-body\">\r\n                    <h1 class=\"card-title\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1419, "", 1468, 1);
#line 35 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
WriteAttributeValue("", 1425, Html.DisplayFor(modelItem => item.WebSite), 1425, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1468, 16, true);
            WriteLiteral(" target=\"blank\">");
            EndContext();
            BeginContext(1485, 39, false);
#line 35 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 107, true);
            WriteLiteral("</a>\r\n                    </h1>\r\n                    <div class=\"d-inline-block\">\r\n                        ");
            EndContext();
            BeginContext(1631, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40013ad7877a8aceb9e062c4122d1db1964f6f912993", async() => {
                BeginContext(1676, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1684, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1712, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40013ad7877a8aceb9e062c4122d1db1964f6f915349", async() => {
                BeginContext(1760, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1771, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1799, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40013ad7877a8aceb9e062c4122d1db1964f6f917711", async() => {
                BeginContext(1846, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1856, 57, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n");
            EndContext();
#line 43 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                         if (item.Description != null)
                        {

#line default
#line hidden
            BeginContext(1996, 65, true);
            WriteLiteral("                            <p>\r\n                                ");
            EndContext();
            BeginContext(2062, 42, false);
#line 46 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                           Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2104, 36, true);
            WriteLiteral("\r\n                            </p>\r\n");
            EndContext();
#line 48 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2224, 79, true);
            WriteLiteral("                            <p>No description available. Edit to add one.</p>\r\n");
            EndContext();
#line 52 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2330, 282, true);
            WriteLiteral(@"
                    </div>

                    <table class=""table"">
                        <tr>
                            <th>Job Name</th>
                            <th>Job Number</th>
                            <th>Description</th>
                        </tr>
");
            EndContext();
#line 62 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                         if (item.Jobs != null)
                        {

                            foreach (var job in item.Jobs)
                            {

#line default
#line hidden
            BeginContext(2781, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2901, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40013ad7877a8aceb9e062c4122d1db1964f6f922317", async() => {
                BeginContext(2953, 50, true);
                WriteLiteral("\r\n                                            <h4>");
                EndContext();
                BeginContext(3004, 38, false);
#line 70 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => job.Name));

#line default
#line hidden
                EndContext();
                BeginContext(3042, 47, true);
                WriteLiteral("</h4>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                                                       WriteLiteral(job.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3093, 129, true);
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3223, 40, false);
#line 75 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => job.Number));

#line default
#line hidden
            EndContext();
            BeginContext(3263, 182, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <p style=\"height: 50px; overflow: auto; width: auto;\"> ");
            EndContext();
            BeginContext(3446, 41, false);
#line 78 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                                                                          Write(Html.DisplayFor(model => job.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3487, 90, true);
            WriteLiteral("</p>\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 82 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(3635, 303, true);
            WriteLiteral(@"
                    </table>
                    <br />
                    <table class=""table"">
                        <tr>
                            <th>Contact Name</th>
                            <th>Email</th>
                            <th>Phone</th>
                        </tr>
");
            EndContext();
#line 93 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                         if (item.Contacts != null)
                        {
                            foreach (var dude in item.Contacts)
                            {

#line default
#line hidden
            BeginContext(4114, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4234, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40013ad7877a8aceb9e062c4122d1db1964f6f927508", async() => {
                BeginContext(4292, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4294, 39, false);
#line 99 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                                                                              Write(Html.DisplayFor(modelItem => dude.Name));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                                                            WriteLiteral(dude.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(4337, 129, true);
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4467, 40, false);
#line 103 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => dude.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4507, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4635, 42, false);
#line 106 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                                   Write(Html.DisplayFor(model => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(4677, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 109 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(4819, 94, true);
            WriteLiteral("\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 117 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Employer\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4920, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobRanger.Pages.Employer.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JobRanger.Pages.Employer.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JobRanger.Pages.Employer.IndexModel>)PageContext?.ViewData;
        public JobRanger.Pages.Employer.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591