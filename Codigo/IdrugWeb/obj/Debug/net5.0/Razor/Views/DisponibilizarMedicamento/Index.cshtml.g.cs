#pragma checksum "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4d372d57c1372aec41712028a236b356a8bbe2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisponibilizarMedicamento_Index), @"mvc.1.0.view", @"/Views/DisponibilizarMedicamento/Index.cshtml")]
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
#line 1 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\_ViewImports.cshtml"
using IdrugWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\_ViewImports.cshtml"
using IdrugWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d372d57c1372aec41712028a236b356a8bbe2e", @"/Views/DisponibilizarMedicamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1572a2142a0ec023952ac21c9cf3812380e29eca", @"/Views/_ViewImports.cshtml")]
    public class Views_DisponibilizarMedicamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdrugWeb.Models.DisponibilizarMedicamentoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
  
    ViewData["Title"] = "Disponibilizações";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Medicamentos Disponibilizados </h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d372d57c1372aec41712028a236b356a8bbe2e3861", async() => {
                WriteLiteral("Nova Disponibilização");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdDisponibilizacaoMedicamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataInicioDisponibilizacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Lote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StatusMedicamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataVencimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantidadeDisponivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayFor(ControllerContext => item.IdDisponibilizacaoMedicamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataInicioDisponibilizacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StatusMedicamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataVencimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantidadeDisponivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id=item.IdDisponibilizacaoMedicamento}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.ActionLink("Detalhes", "Details", new { id=item.IdDisponibilizacaoMedicamento}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
           Write(Html.ActionLink("Deletar", "Delete", new { id=item.IdDisponibilizacaoMedicamento }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\isacs\Desktop\Branch_Isac153\IDrug\Codigo\IdrugWeb\Views\DisponibilizarMedicamento\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdrugWeb.Models.DisponibilizarMedicamentoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
