#pragma checksum "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a32c96d34880411da771fc8ac57f974c4ff1b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KendraMakeupArtist.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(KendraMakeupArtist.Pages.Pages_Contact), null)]
namespace KendraMakeupArtist.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\_ViewImports.cshtml"
using KendraMakeupArtist;

#line default
#line hidden
#line 3 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\_ViewImports.cshtml"
using KendraMakeupArtist.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a32c96d34880411da771fc8ac57f974c4ff1b5f", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581fde00502e8335f3e6d3e6a184063ecc3ae329", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(71, 17, true);
            WriteLiteral("\r\n<div>\r\n    <h2>");
            EndContext();
            BeginContext(89, 17, false);
#line 8 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\Contact.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(106, 15, true);
            WriteLiteral("</h2>\r\n    <h3>");
            EndContext();
            BeginContext(122, 13, false);
#line 9 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\Contact.cshtml"
   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(135, 419, true);
            WriteLiteral(@"</h3>

    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title=""Phone"">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
    </address>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
