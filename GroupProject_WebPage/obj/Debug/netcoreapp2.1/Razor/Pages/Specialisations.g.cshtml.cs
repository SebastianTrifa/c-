#pragma checksum "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47afbf26361228c626c1b9af3fdd7492ed7997ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GroupProject_WebPage.Pages.Pages_Specialisations), @"mvc.1.0.razor-page", @"/Pages/Specialisations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Specialisations.cshtml", typeof(GroupProject_WebPage.Pages.Pages_Specialisations), null)]
namespace GroupProject_WebPage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\c-\GroupProject_WebPage\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\c-\GroupProject_WebPage\Pages\_ViewImports.cshtml"
using GroupProject_WebPage;

#line default
#line hidden
#line 3 "C:\c-\GroupProject_WebPage\Pages\_ViewImports.cshtml"
using GroupProject_WebPage.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47afbf26361228c626c1b9af3fdd7492ed7997ed", @"/Pages/Specialisations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aea016228cc95a079296cb7e06d58259b025f47", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Specialisations : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml"
  
    ViewData["Title"] = "Specialisations";

#line default
#line hidden
            BeginContext(114, 153, true);
            WriteLiteral("\r\n<h2>Specialisations</h2>\r\n\r\n<table class=\"table table-bordered table-striped table-hover\">\r\n    <tr>\r\n        <th>Specialisation Name</th>\r\n    </tr>\r\n");
            EndContext();
#line 13 "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml"
     foreach (var c in Model.specialisations)
    {

#line default
#line hidden
            BeginContext(321, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(352, 10, false);
#line 16 "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml"
           Write(c.SpecName);

#line default
#line hidden
            EndContext();
            BeginContext(362, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 18 "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml"
    }

#line default
#line hidden
            BeginContext(391, 137, true);
            WriteLiteral("</table>\r\n\r\n<ul class=\"pagination\">\r\n    <li><a href=\"https://localhost:44318/AllCustomers?page=1\" class=\"asp\">First</a></li>\r\n    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 528, "\"", 597, 2);
            WriteAttributeValue("", 535, "https://localhost:44318/AllCustomers?page=", 535, 42, true);
#line 23 "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml"
WriteAttributeValue("", 577, Model.current - 1, 577, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(598, 102, true);
            WriteLiteral(" class=\"asp\">Previous</a></li>\r\n    <li>\r\n        <a><input name=\"pagine\" id=\"page\" onchange=\"Input()\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 700, "\"", 724, 1);
#line 25 "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml"
WriteAttributeValue("", 708, Model.current, 708, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(725, 4, true);
            WriteLiteral(" />/");
            EndContext();
            BeginContext(731, 10, false);
#line 25 "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml"
                                                                                     Write(Model.last);

#line default
#line hidden
            EndContext();
            BeginContext(742, 27, true);
            WriteLiteral("</a>\r\n    </li>\r\n    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 769, "\"", 838, 2);
            WriteAttributeValue("", 776, "https://localhost:44318/AllCustomers?page=", 776, 42, true);
#line 27 "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml"
WriteAttributeValue("", 818, Model.current + 1, 818, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(839, 38, true);
            WriteLiteral(" class=\"asp\">Next</a></li>\r\n    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 877, "\"", 939, 2);
            WriteAttributeValue("", 884, "https://localhost:44318/AllCustomers?page=", 884, 42, true);
#line 28 "C:\c-\GroupProject_WebPage\Pages\Specialisations.cshtml"
WriteAttributeValue("", 926, Model.last, 926, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(940, 128, true);
            WriteLiteral(" class=\"asp\">Last</a></li>\r\n</ul>\r\n\r\n<style>\r\n    input#page {\r\n        height: 20px;\r\n        width: 30px;\r\n    }\r\n</style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupProject_WebPage.Pages.SpecialisationsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GroupProject_WebPage.Pages.SpecialisationsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GroupProject_WebPage.Pages.SpecialisationsModel>)PageContext?.ViewData;
        public GroupProject_WebPage.Pages.SpecialisationsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
