#pragma checksum "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea6a6dbe47cd2b2bf9e8737bf0df36ee29363c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KendraMakeupArtist.Pages.ManageRequests.Pages_ManageRequests_Delete), @"mvc.1.0.razor-page", @"/Pages/ManageRequests/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ManageRequests/Delete.cshtml", typeof(KendraMakeupArtist.Pages.ManageRequests.Pages_ManageRequests_Delete), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea6a6dbe47cd2b2bf9e8737bf0df36ee29363c7", @"/Pages/ManageRequests/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581fde00502e8335f3e6d3e6a184063ecc3ae329", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ManageRequests_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(111, 179, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>AppointmentRequest</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(291, 68, false);
#line 16 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.RequestStatus));

#line default
#line hidden
            EndContext();
            BeginContext(359, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(403, 64, false);
#line 19 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.RequestStatus));

#line default
#line hidden
            EndContext();
            BeginContext(467, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(511, 64, false);
#line 22 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(575, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(619, 60, false);
#line 25 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(679, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(723, 63, false);
#line 28 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(786, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(830, 59, false);
#line 31 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(889, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(933, 70, false);
#line 34 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.AppointmentType));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1047, 66, false);
#line 37 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.AppointmentType));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1157, 70, false);
#line 40 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.RequestDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1271, 66, false);
#line 43 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.RequestDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1381, 70, false);
#line 46 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1495, 66, false);
#line 49 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1605, 63, false);
#line 52 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1712, 59, false);
#line 55 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1815, 67, false);
#line 58 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.ContactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1926, 63, false);
#line 61 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.ContactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1989, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2033, 67, false);
#line 64 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.ContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2100, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2144, 63, false);
#line 67 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.ContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2251, 62, false);
#line 70 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentRequest.Message));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2357, 58, false);
#line 73 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentRequest.Message));

#line default
#line hidden
            EndContext();
            BeginContext(2415, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2453, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ee8a34b994c40fa9a5643719e6681ae", async() => {
                BeginContext(2473, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2483, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a2f79a97edd497d8cc4cee4ea86533c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 78 "C:\Users\tcape\source\repos\KendraMakeupArtist\KendraMakeupArtist\Pages\ManageRequests\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AppointmentRequest.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2538, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2622, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051c70dad3c0462aa14f0c1a4671cdb8", async() => {
                    BeginContext(2644, 12, true);
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
                BeginContext(2660, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2673, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KendraMakeupArtist.Pages.ManageRequests.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KendraMakeupArtist.Pages.ManageRequests.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KendraMakeupArtist.Pages.ManageRequests.DeleteModel>)PageContext?.ViewData;
        public KendraMakeupArtist.Pages.ManageRequests.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
