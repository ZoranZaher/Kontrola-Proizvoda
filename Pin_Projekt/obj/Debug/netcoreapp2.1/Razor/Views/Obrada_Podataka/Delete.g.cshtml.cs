#pragma checksum "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "631a29f27b9e9b325169b185764d90c3b688753a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Obrada_Podataka_Delete), @"mvc.1.0.view", @"/Views/Obrada_Podataka/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Obrada_Podataka/Delete.cshtml", typeof(AspNetCore.Views_Obrada_Podataka_Delete))]
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
#line 1 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\_ViewImports.cshtml"
using Pin_Projekt;

#line default
#line hidden
#line 2 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\_ViewImports.cshtml"
using Pin_Projekt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"631a29f27b9e9b325169b185764d90c3b688753a", @"/Views/Obrada_Podataka/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a22ebecaf71087cd7ec005548c898ad8595d175", @"/Views/_ViewImports.cshtml")]
    public class Views_Obrada_Podataka_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pin_Projekt.Models.Obrada_Podataka>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(87, 182, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Jeste li sigurni da želite izbrisat stavku?</h3>\r\n<div>\r\n    <h4>Obrada_Podataka</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(270, 49, false);
#line 15 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ime_Proizvoda));

#line default
#line hidden
            EndContext();
            BeginContext(319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(363, 45, false);
#line 18 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ime_Proizvoda));

#line default
#line hidden
            EndContext();
            BeginContext(408, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(452, 43, false);
#line 21 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tržište));

#line default
#line hidden
            EndContext();
            BeginContext(495, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(539, 39, false);
#line 24 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tržište));

#line default
#line hidden
            EndContext();
            BeginContext(578, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(622, 40, false);
#line 27 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(662, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(706, 36, false);
#line 30 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(742, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(786, 43, false);
#line 33 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Etiketa));

#line default
#line hidden
            EndContext();
            BeginContext(829, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(873, 39, false);
#line 36 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Etiketa));

#line default
#line hidden
            EndContext();
            BeginContext(912, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(956, 39, false);
#line 39 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Čep));

#line default
#line hidden
            EndContext();
            BeginContext(995, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1039, 35, false);
#line 42 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Čep));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1118, 52, false);
#line 45 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Izgled_Proizvoda));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1214, 48, false);
#line 48 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Izgled_Proizvoda));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1300, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593aebff5ebf4e958f621d649205b1b5", async() => {
                BeginContext(1326, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1336, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e716ffb52a794f02a47c2582125b8eec", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "F:\Web_Aplikacije\Kontrola_Proizvoda\Pin_Projekt\Views\Obrada_Podataka\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(1372, 85, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Izbriši\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1457, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3493ed08d2dd4742bcc2354275cbf9e1", async() => {
                    BeginContext(1479, 15, true);
                    WriteLiteral("Povrat na listu");
                    EndContext();
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
                EndContext();
                BeginContext(1498, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1511, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pin_Projekt.Models.Obrada_Podataka> Html { get; private set; }
    }
}
#pragma warning restore 1591
