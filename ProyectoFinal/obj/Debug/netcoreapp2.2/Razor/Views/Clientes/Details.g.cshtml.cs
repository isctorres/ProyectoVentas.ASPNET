#pragma checksum "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78b8cd9920e1ea74f13366472b8fd8b32dadca6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Details), @"mvc.1.0.view", @"/Views/Clientes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Details.cshtml", typeof(AspNetCore.Views_Clientes_Details))]
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
#line 1 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\_ViewImports.cshtml"
using ProyectoFinal;

#line default
#line hidden
#line 2 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\_ViewImports.cshtml"
using ProyectoFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78b8cd9920e1ea74f13366472b8fd8b32dadca6f", @"/Views/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a15a183d38432e5d59901f4b5b9ca0de63cbe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proyecto.Models.Clientes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 149, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h4>Detalles de Clientes</h4>\r\n    <hr />\r\n    <dl class=\"row col-md-12\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(228, 49, false);
#line 12 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreCliente));

#line default
#line hidden
            EndContext();
            BeginContext(277, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(339, 45, false);
#line 15 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreCliente));

#line default
#line hidden
            EndContext();
            BeginContext(384, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(445, 51, false);
#line 18 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApellidoPaterno));

#line default
#line hidden
            EndContext();
            BeginContext(496, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(558, 47, false);
#line 21 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApellidoPaterno));

#line default
#line hidden
            EndContext();
            BeginContext(605, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(666, 51, false);
#line 24 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApellidoMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(717, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(779, 47, false);
#line 27 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApellidoMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(826, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(887, 48, false);
#line 30 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailCliente));

#line default
#line hidden
            EndContext();
            BeginContext(935, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(997, 44, false);
#line 33 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmailCliente));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1102, 51, false);
#line 36 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TelefonoCliente));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1215, 47, false);
#line 39 "C:\Users\iscto\source\repos\ProyectoFinal\ProyectoFinal\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.TelefonoCliente));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1309, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78b8cd9920e1ea74f13366472b8fd8b32dadca6f8291", async() => {
                BeginContext(1331, 26, true);
                WriteLiteral("Regresar a lista principal");
                EndContext();
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
            EndContext();
            BeginContext(1361, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyecto.Models.Clientes> Html { get; private set; }
    }
}
#pragma warning restore 1591
