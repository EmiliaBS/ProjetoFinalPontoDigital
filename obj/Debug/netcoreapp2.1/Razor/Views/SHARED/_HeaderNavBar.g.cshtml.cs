#pragma checksum "D:\PontoDigitalWeb\Views\SHARED\_HeaderNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afc32ef6958592e2bb9f190ebde445ce6be90d0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SHARED__HeaderNavBar), @"mvc.1.0.view", @"/Views/SHARED/_HeaderNavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SHARED/_HeaderNavBar.cshtml", typeof(AspNetCore.Views_SHARED__HeaderNavBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc32ef6958592e2bb9f190ebde445ce6be90d0c", @"/Views/SHARED/_HeaderNavBar.cshtml")]
    public class Views_SHARED__HeaderNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 219, true);
            WriteLiteral(" <nav class=\"menu\">\r\n                <ul>\r\n                    <li><a asp-controller=\"Home\" asp-action=\"Index\" class=\"active\"></a></li>\r\n                    <img id=\"zero\" src=\"img/logo.png\">\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 219, "\'", 258, 2);
#line 5 "D:\PontoDigitalWeb\Views\SHARED\_HeaderNavBar.cshtml"
WriteAttributeValue("", 226, Url.Action("Index","Home"), 226, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 253, "#Home", 253, 5, true);
            EndWriteAttribute();
            BeginContext(259, 42, true);
            WriteLiteral(">Home</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 301, "\'", 342, 2);
#line 6 "D:\PontoDigitalWeb\Views\SHARED\_HeaderNavBar.cshtml"
WriteAttributeValue("", 308, Url.Action("Index","Sobre"), 308, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 336, "#Sobre", 336, 6, true);
            EndWriteAttribute();
            BeginContext(343, 43, true);
            WriteLiteral(">Sobre</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 386, "\'", 429, 2);
#line 7 "D:\PontoDigitalWeb\Views\SHARED\_HeaderNavBar.cshtml"
WriteAttributeValue("", 393, Url.Action("Index","Planos"), 393, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 422, "#Planos", 422, 7, true);
            EndWriteAttribute();
            BeginContext(430, 44, true);
            WriteLiteral(">Planos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 474, "\'", 518, 2);
#line 8 "D:\PontoDigitalWeb\Views\SHARED\_HeaderNavBar.cshtml"
WriteAttributeValue("", 481, Url.Action("Index","Cadastro"), 481, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 512, "#Login", 512, 6, true);
            EndWriteAttribute();
            BeginContext(519, 43, true);
            WriteLiteral(">Login</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 562, "\'", 607, 2);
#line 9 "D:\PontoDigitalWeb\Views\SHARED\_HeaderNavBar.cshtml"
WriteAttributeValue("", 569, Url.Action("Index","Contato"), 569, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 599, "#Contato", 599, 8, true);
            EndWriteAttribute();
            BeginContext(608, 52, true);
            WriteLiteral(">Contato</a></li>\r\n                </ul>\r\n    </nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
