#pragma checksum "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf42ac86f79443641924e731d5d65d78a4184ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Start_Views_Privacy_PartialCookieConsent), @"mvc.1.0.view", @"/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml", typeof(AspNetCore.Areas_Start_Views_Privacy_PartialCookieConsent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf42ac86f79443641924e731d5d65d78a4184ff8", @"/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml")]
    public class Areas_Start_Views_Privacy_PartialCookieConsent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEB.Areas.Start.Models.ViewModels.CookieConsentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml"
   var urlConsent = Url.Action("registerCookieConsent", "Privacy", new { area = "Start", option = "yes" }); 

#line default
#line hidden
            BeginContext(167, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml"
 if (!Model.showBanner) {
    return;
}

#line default
#line hidden
            BeginContext(208, 171, true);
            WriteLiteral("\n<div id=\"cookieConsent\" class=\"alert alert-info alert-dismissible fade show\" role=\"alert\">\n    Use this space to summarize your privacy and cookie use policy.\n    \n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 379, "\"", 447, 1);
#line 11 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml"
WriteAttributeValue("", 386, Url.Action("PrivacyDetails","Privacy", new {area = "Start"}), 386, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(448, 170, true);
            WriteLiteral(">Leia mais sobre nossas politicas</a>.\n    \n    <button id=\"cookieConsentButton\"\n            type=\"button\"\n            data-dismiss=\"alert\"\n            aria-label=\"Close\"");
            EndContext();
            BeginWriteAttribute("onclick", "\n            onclick = \"", 618, "\"", 678, 3);
            WriteAttributeValue("", 642, "System.assyncRegister(\'", 642, 23, true);
#line 17 "/home/notim/GitHub/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml"
WriteAttributeValue("", 665, urlConsent, 665, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 676, "\')", 676, 2, true);
            EndWriteAttribute();
            BeginContext(679, 78, true);
            WriteLiteral(">\n        \n        <span aria-hidden=\"true\">Accept</span>\n    </button>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEB.Areas.Start.Models.ViewModels.CookieConsentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
