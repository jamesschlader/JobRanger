#pragma checksum "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9db1e152498c6b530ff980149a357af49d55e4b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(JobRanger.Pages.Contacts.Pages_Contacts_Details), @"mvc.1.0.razor-page", @"/Pages/Contacts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contacts/Details.cshtml", typeof(JobRanger.Pages.Contacts.Pages_Contacts_Details), @"{id:int}")]
namespace JobRanger.Pages.Contacts
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db1e152498c6b530ff980149a357af49d55e4b3", @"/Pages/Contacts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68a822ad2a8e1ef3467423615f697fe3ed6f12d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contacts_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
  
    ViewData["Title"] = "Contact Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(164, 8, true);
            WriteLiteral("\r\n\r\n<h1>");
            EndContext();
            BeginContext(173, 44, false);
#line 10 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
Write(Html.DisplayFor(model => model.Contact.Name));

#line default
#line hidden
            EndContext();
            BeginContext(217, 118, true);
            WriteLiteral("</h1>\r\n\r\n\r\n<div>\r\n    <h4>Contact</h4>\r\n    <hr/>\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(336, 49, false);
#line 19 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Email));

#line default
#line hidden
            EndContext();
            BeginContext(385, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(447, 45, false);
#line 22 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Email));

#line default
#line hidden
            EndContext();
            BeginContext(492, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(553, 55, false);
#line 25 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(608, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n          ");
            EndContext();
            BeginContext(670, 49, false);
#line 29 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
     Write(Html.DisplayFor(model=>model.Contact.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(719, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(780, 52, false);
#line 32 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(832, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(894, 48, false);
#line 35 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(942, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1003, 52, false);
#line 38 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1117, 48, false);
#line 41 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1226, 48, false);
#line 44 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.City));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1336, 44, false);
#line 47 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact.City));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1441, 49, false);
#line 50 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.State));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1552, 45, false);
#line 53 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact.State));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1658, 51, false);
#line 56 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1709, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1771, 47, false);
#line 59 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1879, 52, false);
#line 62 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Employer));

#line default
#line hidden
            EndContext();
            BeginContext(1931, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1993, 53, false);
#line 65 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Employer.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2046, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2093, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9db1e152498c6b530ff980149a357af49d55e4b311747", async() => {
                BeginContext(2147, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\Owner\source\repos\JobRanger\JobRanger\Pages\Contacts\Details.cshtml"
                           WriteLiteral(Model.Contact.Id);

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
            BeginContext(2155, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2163, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9db1e152498c6b530ff980149a357af49d55e4b314073", async() => {
                BeginContext(2185, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2201, 81, true);
            WriteLiteral(" |\r\n    <a href=\"javascript: history.go(-1)\">Go Back to Previous Page</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobRanger.Pages.Contacts.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JobRanger.Pages.Contacts.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JobRanger.Pages.Contacts.DetailsModel>)PageContext?.ViewData;
        public JobRanger.Pages.Contacts.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
