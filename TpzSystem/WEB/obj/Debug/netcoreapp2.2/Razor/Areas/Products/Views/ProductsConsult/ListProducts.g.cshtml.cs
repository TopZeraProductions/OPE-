#pragma checksum "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c39634ed105fbfcd99dfae3ee7ded0f16ff8671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Products_Views_ProductsConsult_ListProducts), @"mvc.1.0.view", @"/Areas/Products/Views/ProductsConsult/ListProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Products/Views/ProductsConsult/ListProducts.cshtml", typeof(AspNetCore.Areas_Products_Views_ProductsConsult_ListProducts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c39634ed105fbfcd99dfae3ee7ded0f16ff8671", @"/Areas/Products/Views/ProductsConsult/ListProducts.cshtml")]
    public class Areas_Products_Views_ProductsConsult_ListProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEB.Areas.Products.Models.ViewModels.ListProductsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Products/Assets/css/products.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
  
    ViewBag.Title = "Products";
    Layout = "masterpage";

#line default
#line hidden
            BeginContext(124, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(141, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(146, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c39634ed105fbfcd99dfae3ee7ded0f16ff86714156", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(219, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(222, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(228, 13, false);
#line 12 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
Write(ViewBag.teste);

#line default
#line hidden
            EndContext();
            BeginContext(241, 10, true);
            WriteLiteral("</h2>\n<h2>");
            EndContext();
            BeginContext(252, 14, false);
#line 13 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
Write(ViewBag.teste2);

#line default
#line hidden
            EndContext();
            BeginContext(266, 10, true);
            WriteLiteral("</h2>\n<h2>");
            EndContext();
            BeginContext(277, 14, false);
#line 14 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
Write(ViewBag.teste3);

#line default
#line hidden
            EndContext();
            BeginContext(291, 10, true);
            WriteLiteral("</h2>\n<h2>");
            EndContext();
            BeginContext(302, 14, false);
#line 15 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
Write(ViewBag.teste4);

#line default
#line hidden
            EndContext();
            BeginContext(316, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 17 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
 foreach (var Item  in Model.ApiServicesSettings.listServices) {
    

#line default
#line hidden
            BeginContext(393, 8, true);
            WriteLiteral("    <h3>");
            EndContext();
            BeginContext(402, 9, false);
#line 19 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
   Write(Item.name);

#line default
#line hidden
            EndContext();
            BeginContext(411, 14, true);
            WriteLiteral("</h3>\n    <h3>");
            EndContext();
            BeginContext(426, 9, false);
#line 20 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
   Write(Item.path);

#line default
#line hidden
            EndContext();
            BeginContext(435, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 21 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
}

#line default
#line hidden
            BeginContext(443, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 23 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
 foreach (var Item in Model.DataBaseSettings.listDatabases) {
    

#line default
#line hidden
            BeginContext(511, 8, true);
            WriteLiteral("    <h3>");
            EndContext();
            BeginContext(520, 9, false);
#line 25 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
   Write(Item.host);

#line default
#line hidden
            EndContext();
            BeginContext(529, 14, true);
            WriteLiteral("</h3>\n    <h3>");
            EndContext();
            BeginContext(544, 9, false);
#line 26 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
   Write(Item.user);

#line default
#line hidden
            EndContext();
            BeginContext(553, 14, true);
            WriteLiteral("</h3>\n    <h3>");
            EndContext();
            BeginContext(568, 13, false);
#line 27 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
   Write(Item.database);

#line default
#line hidden
            EndContext();
            BeginContext(581, 14, true);
            WriteLiteral("</h3>\n    <h3>");
            EndContext();
            BeginContext(596, 13, false);
#line 28 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
   Write(Item.password);

#line default
#line hidden
            EndContext();
            BeginContext(609, 14, true);
            WriteLiteral("</h3>\n    <h3>");
            EndContext();
            BeginContext(624, 13, false);
#line 29 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
   Write(Item.provider);

#line default
#line hidden
            EndContext();
            BeginContext(637, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 30 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
}

#line default
#line hidden
            BeginContext(645, 3, true);
            WriteLiteral("\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 648, "\"", 708, 1);
#line 32 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Products/Views/ProductsConsult/ListProducts.cshtml"
WriteAttributeValue("", 655, Url.Action("Error", "Error", new { area ="Errors" }), 655, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(709, 37, true);
            WriteLiteral(">Teste</a>\n\n<div class=\"teste\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEB.Areas.Products.Models.ViewModels.ListProductsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
