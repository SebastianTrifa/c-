#pragma checksum "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ce3aad367d4397f7b82fd9f411efd31982cfc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Lab_83_addrecord.Pages.Pages_EditCustomer), @"mvc.1.0.razor-page", @"/Pages/EditCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EditCustomer.cshtml", typeof(Lab_83_addrecord.Pages.Pages_EditCustomer), null)]
namespace Lab_83_addrecord.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\c-\Lab_83_addrecord\Pages\_ViewImports.cshtml"
using Lab_83_addrecord;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ce3aad367d4397f7b82fd9f411efd31982cfc8", @"/Pages/EditCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8b941610a22672350ae54807e76d1294cfde07", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EditCustomer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("EditCustomer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
  
    ViewData["Title"] = "EditCustomer";

#line default
#line hidden
            BeginContext(104, 81, true);
            WriteLiteral("\r\n<h2>EditCustomer</h2>\r\n\r\n<div class=\"row\">\r\n    <p>Add a new customer</p>\r\n    ");
            EndContext();
            BeginContext(185, 348, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc43a8096704587a167a413b64d0578", async() => {
                BeginContext(226, 300, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""customerID"">CustomerID</label>
            <input type=""text"" name=""customerID"" class=""form-control"" id=""customerID"" placeholder=""ZYX2A"" />
        </div>
        <button type=""submit"" class=""btn btn-primary btn-lg"">Select</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(533, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(539, 920, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59d28ab905bb4d7bb5184a1c9126d562", async() => {
                BeginContext(580, 205, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"customerName\">Customer Name</label>\r\n            <input type=\"text\" name=\"customerName\" class=\"form-control\" id=\"customerName\" placeholder=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 785, "\"", 803, 1);
#line 21 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
WriteAttributeValue("", 793, Model.ccn, 793, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(804, 222, true);
                WriteLiteral("/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"companyName\">Company Name</label>\r\n            <input type=\"text\" name=\"companyName\" class=\"form-control\" id=\"companyName\" placeholder=\"Company\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1026, "\"", 1045, 1);
#line 25 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
WriteAttributeValue("", 1034, Model.ccon, 1034, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1046, 190, true);
                WriteLiteral("/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"City\">City</label>\r\n            <input type=\"text\" name=\"city\" class=\"form-control\" id=\"city\" placeholder=\"City\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1236, "\"", 1253, 1);
#line 29 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
WriteAttributeValue("", 1244, Model.cc, 1244, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1254, 76, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"ID\" class=\"form-control\" id=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1330, "\"", 1348, 1);
#line 30 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
WriteAttributeValue("", 1338, Model.cid, 1338, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1349, 103, true);
                WriteLiteral(" />\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary btn-lg\">Submit</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1459, 189, true);
            WriteLiteral("\r\n</div>\r\n\r\n<table class=\"table table-bordered table-striped table-hover\">\r\n    <tr>\r\n        <th>Customer ID</th>\r\n        <th>Company Name</th>\r\n        <th>Contact Name</th>\r\n    </tr>\r\n");
            EndContext();
#line 42 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
     foreach (var c in Model.customers)
    {

#line default
#line hidden
            BeginContext(1696, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1727, 12, false);
#line 45 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
           Write(c.CustomerID);

#line default
#line hidden
            EndContext();
            BeginContext(1739, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1763, 13, false);
#line 46 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
           Write(c.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1800, 13, false);
#line 47 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
           Write(c.ContactName);

#line default
#line hidden
            EndContext();
            BeginContext(1813, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\c-\Lab_83_addrecord\Pages\EditCustomer.cshtml"
    }

#line default
#line hidden
            BeginContext(1842, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab_83_addrecord.Pages.EditCustomerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lab_83_addrecord.Pages.EditCustomerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lab_83_addrecord.Pages.EditCustomerModel>)PageContext?.ViewData;
        public Lab_83_addrecord.Pages.EditCustomerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591