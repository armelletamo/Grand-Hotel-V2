#pragma checksum "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded39997989403b8666a33cc2e3c7239762fd10d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GrandHotel.Pages.Chambres.Pages_Chambres_List), @"mvc.1.0.razor-page", @"/Pages/Chambres/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Chambres/List.cshtml", typeof(GrandHotel.Pages.Chambres.Pages_Chambres_List), null)]
namespace GrandHotel.Pages.Chambres
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\_ViewImports.cshtml"
using GrandHotel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded39997989403b8666a33cc2e3c7239762fd10d", @"/Pages/Chambres/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4740146f3530e9db5fb31c7f442916c8621c422a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Chambres_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96e4416e1d014c6a9f219a430a5dc37f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(122, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50075e9467ac4e698da3052eef10e8b1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(188, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e231d15c69604623b37c1904e3f04f78", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(228, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(230, 1694, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61193d8e9a3b43fbaa8a14856d73b1e1", async() => {
                BeginContext(236, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(242, 1673, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b823862d645429e9a16c4051f3c8af7", async() => {
                    BeginContext(278, 433, true);
                    WriteLiteral(@"
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>Room number</th>
                    <th>Level </th>
                    <th>Bath</th>
                    <th>Shower</th>
                    <th>Number of beds</th>
                    <th>Unit Price</th>
                    <th>Total Price</th>
                </tr>
            </thead>
            <tbody>
");
                    EndContext();
#line 24 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                 foreach (var chambre in Model.Chambre)
                {

#line default
#line hidden
                    BeginContext(787, 54, true);
                    WriteLiteral("                    <tr>\r\n                        <td>");
                    EndContext();
                    BeginContext(842, 14, false);
#line 27 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                       Write(chambre.Numero);

#line default
#line hidden
                    EndContext();
                    BeginContext(856, 35, true);
                    WriteLiteral("</td>\r\n                        <td>");
                    EndContext();
                    BeginContext(892, 13, false);
#line 28 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                       Write(chambre.Etage);

#line default
#line hidden
                    EndContext();
                    BeginContext(905, 35, true);
                    WriteLiteral("</td>\r\n                        <td>");
                    EndContext();
                    BeginContext(941, 12, false);
#line 29 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                       Write(chambre.Bain);

#line default
#line hidden
                    EndContext();
                    BeginContext(953, 35, true);
                    WriteLiteral("</td>\r\n                        <td>");
                    EndContext();
                    BeginContext(989, 14, false);
#line 30 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                       Write(chambre.Douche);

#line default
#line hidden
                    EndContext();
                    BeginContext(1003, 35, true);
                    WriteLiteral("</td>\r\n                        <td>");
                    EndContext();
                    BeginContext(1039, 14, false);
#line 31 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                       Write(chambre.NbLits);

#line default
#line hidden
                    EndContext();
                    BeginContext(1053, 35, true);
                    WriteLiteral("</td>\r\n                        <td>");
                    EndContext();
                    BeginContext(1089, 12, false);
#line 32 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                       Write(chambre.Prix);

#line default
#line hidden
                    EndContext();
                    BeginContext(1101, 35, true);
                    WriteLiteral("</td>\r\n                        <td>");
                    EndContext();
                    BeginContext(1137, 17, false);
#line 33 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                       Write(chambre.PrixTotal);

#line default
#line hidden
                    EndContext();
                    BeginContext(1154, 65, true);
                    WriteLiteral("</td>\r\n                        <td>\r\n                            ");
                    EndContext();
                    BeginContext(1219, 362, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb04947c5b124f7a9c7c35f3ed407dee", async() => {
                        BeginContext(1470, 107, true);
                        WriteLiteral("\r\n                                <i class=\"glyphicon glyphicon-zoom-in\"></i>\r\n                            ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-chambreId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#line 37 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                                        WriteLiteral(chambre.Numero);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["chambreId"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-chambreId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["chambreId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 37 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                                                                         WriteLiteral(chambre.Prix);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Prix"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Prix", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Prix"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 37 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                                                                                                             WriteLiteral(chambre.PrixTotal);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["prixTotal"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-prixTotal", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["prixTotal"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 37 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                                                                                                                                                   WriteLiteral(chambre.NbNuit);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nbnuit"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-nbnuit", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nbnuit"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1581, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(1611, 174, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc7c25131b09490ea83965e187d88962", async() => {
                        BeginContext(1708, 68, true);
                        WriteLiteral("\r\n                                Book\r\n                            ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numchambre", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#line 40 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                                                            WriteLiteral(chambre.Numero);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["numchambre"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numchambre", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["numchambre"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 40 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                                                                                             WriteLiteral(chambre.PrixTotal);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["prix"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-prix", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["prix"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1785, 60, true);
                    WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
                    EndContext();
#line 45 "C:\Users\armelle.youmbi\Documents\Grand-Hotel-Git\GrandHotel\GrandHotel\Pages\Chambres\List.cshtml"
                }

#line default
#line hidden
                    BeginContext(1864, 44, true);
                    WriteLiteral("            </tbody>\r\n        </table>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1915, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1924, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrandHotel.Pages.Chambres.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GrandHotel.Pages.Chambres.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GrandHotel.Pages.Chambres.ListModel>)PageContext?.ViewData;
        public GrandHotel.Pages.Chambres.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
