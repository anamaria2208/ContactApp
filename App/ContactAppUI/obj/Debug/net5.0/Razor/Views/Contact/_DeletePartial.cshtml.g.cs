#pragma checksum "C:\Users\Ana-Marija\Desktop\Privatno\Combis\ContactAppUI\Views\Contact\_DeletePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3fdd5ce89f58590cd4562367e04d2a7e65a07d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact__DeletePartial), @"mvc.1.0.view", @"/Views/Contact/_DeletePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3fdd5ce89f58590cd4562367e04d2a7e65a07d", @"/Views/Contact/_DeletePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee75451f264f8a8e61484d792d2c160aa92e46a", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact__DeletePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Brisanje kontakta</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">×</span>
        </button>
    </div>
    <div class=""modal-body"">
        <h6>Jeste li sigurni da želite obrisati kontakt?</h6>
    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Odustani</button>
        <button type=""button"" id=""Delete"" class=""btn btn-danger"">Obriši</button>
 </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
