#pragma checksum "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24e3f37b8c65f16df06e26abedc13707c77e52ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipamentos_Details), @"mvc.1.0.view", @"/Views/Equipamentos/Details.cshtml")]
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
#line 1 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\_ViewImports.cshtml"
using SAEP_Treino_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\_ViewImports.cshtml"
using SAEP_Treino_Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24e3f37b8c65f16df06e26abedc13707c77e52ae", @"/Views/Equipamentos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1415f80a5a3e179571d48e29099ba4368e10ea81", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipamentos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SAEP_Treino_Final.Models.Equipamentos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Comentários</h1>\r\n\r\n<div>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24e3f37b8c65f16df06e26abedc13707c77e52ae4356", async() => {
                WriteLiteral("\r\n\r\n        <input class=\"form-control\" type=\"text\" name=\"Comentario\" />\r\n\r\n        <input");
                BeginWriteAttribute("value", " value=\"", 277, "\"", 300, 1);
#nullable restore
#line 15 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
WriteAttributeValue("", 285, ViewBag.Perfil, 285, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" type=\"hidden\" name=\"IdPerfil\" />\r\n        <input");
                BeginWriteAttribute("value", " value=\"", 371, "\"", 414, 1);
#nullable restore
#line 16 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
WriteAttributeValue("", 379, Html.DisplayFor(model => model.Id), 379, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" type=\"hidden\" name=\"IdEquipamento\" />\r\n\r\n        <button type=\"submit\" class=\"btn btn-dark\">Comentar</button>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
AddHtmlAttributeValue("", 148, Url.Action("Comentar"), 148, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24e3f37b8c65f16df06e26abedc13707c77e52ae7438", async() => {
                WriteLiteral("Voltar aos equipamentos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n");
#nullable restore
#line 27 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
         if(ViewBag.Comentarios != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
             foreach (var item in ViewBag.Comentarios)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"comentarios\">\r\n                <b>");
#nullable restore
#line 32 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
              Write(item.Perfis.Perfil);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 32 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
                                    Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                <p>");
#nullable restore
#line 33 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
              Write(item.Comentario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\fic\Desktop\SAEP_treinamento_final\SAEP_Treino_Final\Views\Equipamentos\Details.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SAEP_Treino_Final.Models.Equipamentos> Html { get; private set; }
    }
}
#pragma warning restore 1591
