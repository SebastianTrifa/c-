#pragma checksum "C:\c-\Labs_asp\Pages\OrderBy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d245a4a4920c958a1292f9e9c5277a4687dd5362"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Labs_asp.Pages.Pages_OrderBy), @"mvc.1.0.razor-page", @"/Pages/OrderBy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/OrderBy.cshtml", typeof(Labs_asp.Pages.Pages_OrderBy), null)]
namespace Labs_asp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\c-\Labs_asp\Pages\_ViewImports.cshtml"
using Labs_asp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d245a4a4920c958a1292f9e9c5277a4687dd5362", @"/Pages/OrderBy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76c3d3a1131f4d382a9e2ed717f9551e8453102", @"/Pages/_ViewImports.cshtml")]
    public class Pages_OrderBy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(163, 10, true);
            WriteLiteral("\r\n\r\n<ul>\r\n");
            EndContext();
#line 8 "C:\c-\Labs_asp\Pages\OrderBy.cshtml"
     foreach (var c in Model.newlist)
    {

#line default
#line hidden
            BeginContext(219, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(232, 13, false);
#line 10 "C:\c-\Labs_asp\Pages\OrderBy.cshtml"
       Write(c.ContactName);

#line default
#line hidden
            EndContext();
            BeginContext(245, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\c-\Labs_asp\Pages\OrderBy.cshtml"
    }

#line default
#line hidden
            BeginContext(259, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Labs_asp.Pages.OrderByModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Labs_asp.Pages.OrderByModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Labs_asp.Pages.OrderByModel>)PageContext?.ViewData;
        public Labs_asp.Pages.OrderByModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591