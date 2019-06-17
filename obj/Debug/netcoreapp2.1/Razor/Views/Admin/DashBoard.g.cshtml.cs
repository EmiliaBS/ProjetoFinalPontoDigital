#pragma checksum "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dbd77782f2650422d3bfd69a699e2978325045f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DashBoard), @"mvc.1.0.view", @"/Views/Admin/DashBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DashBoard.cshtml", typeof(AspNetCore.Views_Admin_DashBoard))]
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
#line 1 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
using PontoDigitalWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dbd77782f2650422d3bfd69a699e2978325045f", @"/Views/Admin/DashBoard.cshtml")]
    public class Views_Admin_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0672221cb024b02a8666c3e520a3733", async() => {
                BeginContext(38, 163, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=devide-width, inicial-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"/css/style-admin.css\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(208, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(212, 1337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e042a3fbf04fc3ae7d45022db38ef9", async() => {
                BeginContext(218, 84, true);
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"menu\">\r\n            <ul>\r\n                <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 302, "\'", 341, 2);
#line 12 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
WriteAttributeValue("", 309, Url.Action("Index","Home"), 309, 27, false);

#line default
#line hidden
                WriteAttributeValue("", 336, "#Home", 336, 5, true);
                EndWriteAttribute();
                BeginContext(342, 38, true);
                WriteLiteral(">Home</a></li>\r\n                <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 380, "\'", 423, 2);
#line 13 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
WriteAttributeValue("", 387, Url.Action("Listar","Admin"), 387, 29, false);

#line default
#line hidden
                WriteAttributeValue("", 416, "#Listar", 416, 7, true);
                EndWriteAttribute();
                BeginContext(424, 405, true);
                WriteLiteral(@">Listar</a></li>
            </ul>
        </nav>
    </header>
    <main>
        <h2>Tela de Administrador</h2>
        <table>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>EMAIL</th>
                    <th>COMENTÁRIO</th>
                    <th>DATA DO COMENTÁRIO</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 29 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
                 foreach (var item in Model.ListaDeComentarios)
                {

#line default
#line hidden
                BeginContext(913, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(968, 7, false);
#line 32 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
                       Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(975, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1011, 10, false);
#line 33 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
                       Write(item.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1021, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1057, 15, false);
#line 34 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
                       Write(item.Comentario);

#line default
#line hidden
                EndContext();
                BeginContext(1072, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1108, 19, false);
#line 35 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
                       Write(item.DataComentario);

#line default
#line hidden
                EndContext();
                BeginContext(1127, 79, true);
                WriteLiteral("</td>\r\n                        <td>\r\n                            <td><button><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1206, "\"", 1249, 2);
                WriteAttributeValue("", 1213, "/Admin/AprovarComentario?id=", 1213, 28, true);
#line 37 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
WriteAttributeValue("", 1241, item.Id, 1241, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1250, 70, true);
                WriteLiteral(">Aprovar</a></button></td>\r\n                            <td><button><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1320, "\"", 1364, 2);
                WriteAttributeValue("", 1327, "/Admin/RejeitarComentario?id=", 1327, 29, true);
#line 38 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
WriteAttributeValue("", 1356, item.Id, 1356, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1365, 87, true);
                WriteLiteral(">Reprovar</a></button></td>\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 41 "D:\PontoDigitalWeb\Views\Admin\DashBoard.cshtml"
                }

#line default
#line hidden
                BeginContext(1471, 71, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        </div>\r\n    </main>\r\n");
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
            BeginContext(1549, 2, true);
            WriteLiteral("\r\n");
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
