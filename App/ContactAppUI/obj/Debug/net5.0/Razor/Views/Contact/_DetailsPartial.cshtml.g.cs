#pragma checksum "C:\Users\Ana-Marija\Desktop\Privatno\Combis\ContactAppUI\Views\Contact\_DetailsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aa2c7614a74c8b9acb7a96361fe095284aa4244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact__DetailsPartial), @"mvc.1.0.view", @"/Views/Contact/_DetailsPartial.cshtml")]
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
#line 1 "C:\Users\Ana-Marija\Desktop\Privatno\Combis\ContactAppUI\Views\_ViewImports.cshtml"
using ContactAppUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ana-Marija\Desktop\Privatno\Combis\ContactAppUI\Views\_ViewImports.cshtml"
using ContactAppUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa2c7614a74c8b9acb7a96361fe095284aa4244", @"/Views/Contact/_DetailsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee75451f264f8a8e61484d792d2c160aa92e46a", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact__DetailsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Dodatne informacije o kontaktu</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
    <div class=""modal-body"">
        <div>
            ");
#nullable restore
#line 12 "C:\Users\Ana-Marija\Desktop\Privatno\Combis\ContactAppUI\Views\Contact\_DetailsPartial.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 12 "C:\Users\Ana-Marija\Desktop\Privatno\Combis\ContactAppUI\Views\Contact\_DetailsPartial.cshtml"
                                                          Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 15 "C:\Users\Ana-Marija\Desktop\Privatno\Combis\ContactAppUI\Views\Contact\_DetailsPartial.cshtml"
       Write(Html.DisplayNameFor(model => model.DateModified));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 15 "C:\Users\Ana-Marija\Desktop\Privatno\Combis\ContactAppUI\Views\Contact\_DetailsPartial.cshtml"
                                                           Write(Html.DisplayFor(model => model.DateModified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>    \r\n    </div>\r\n    <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Zatvori</button>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591