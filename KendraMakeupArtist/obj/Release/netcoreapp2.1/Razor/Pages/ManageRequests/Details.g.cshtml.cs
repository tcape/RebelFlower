#pragma checksum "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c11da0b06df49358bb8141f380802c8172e2edba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KendraMakeupArtist.Pages.ManageRequests.Pages_ManageRequests_Details), @"mvc.1.0.razor-page", @"/Pages/ManageRequests/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ManageRequests/Details.cshtml", typeof(KendraMakeupArtist.Pages.ManageRequests.Pages_ManageRequests_Details), null)]
namespace KendraMakeupArtist.Pages.ManageRequests
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c11da0b06df49358bb8141f380802c8172e2edba", @"/Pages/ManageRequests/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581fde00502e8335f3e6d3e6a184063ecc3ae329", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ManageRequests_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(113, 132, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>AppointmentRequest</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 68, false);
#line 15 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.RequestStatus));

#line default
#line hidden
            EndContext();
            BeginContext(314, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(358, 64, false);
#line 18 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.RequestStatus));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(466, 64, false);
#line 21 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(530, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(574, 60, false);
#line 24 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(678, 63, false);
#line 27 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(741, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(785, 59, false);
#line 30 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(844, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(888, 70, false);
#line 33 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.AppointmentType));

#line default
#line hidden
            EndContext();
            BeginContext(958, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1002, 66, false);
#line 36 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.AppointmentType));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1112, 70, false);
#line 39 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.RequestDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1226, 66, false);
#line 42 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.RequestDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1336, 70, false);
#line 45 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1450, 66, false);
#line 48 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1560, 63, false);
#line 51 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1667, 59, false);
#line 54 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1770, 67, false);
#line 57 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.ContactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1881, 63, false);
#line 60 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.ContactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1988, 67, false);
#line 63 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.ContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2055, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2099, 63, false);
#line 66 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.ContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2206, 62, false);
#line 69 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.Message));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2312, 58, false);
#line 72 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.Message));

#line default
#line hidden
            EndContext();
            BeginContext(2370, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2417, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "582acb1088fd4830ba3884368b51d767", async() => {
                BeginContext(2482, 4, true);
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
#line 77 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Details.cshtml"
                           WriteLiteral(Model.AppointmentRequest.Id);

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
            BeginContext(2490, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2498, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5391e93fb0534ca69e21879a2fa7ddc9", async() => {
                BeginContext(2520, 12, true);
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
            BeginContext(2536, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KendraMakeupArtist.Pages.ManageRequests.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KendraMakeupArtist.Pages.ManageRequests.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KendraMakeupArtist.Pages.ManageRequests.DetailsModel>)PageContext?.ViewData;
        public KendraMakeupArtist.Pages.ManageRequests.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
