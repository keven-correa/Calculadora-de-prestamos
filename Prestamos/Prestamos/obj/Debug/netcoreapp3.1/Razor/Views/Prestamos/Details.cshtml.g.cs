#pragma checksum "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a146d41786ef7147e572b4f380b8f316fa700e2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prestamos_Details), @"mvc.1.0.view", @"/Views/Prestamos/Details.cshtml")]
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
#line 1 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\_ViewImports.cshtml"
using Prestamos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\_ViewImports.cshtml"
using Prestamos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a146d41786ef7147e572b4f380b8f316fa700e2e", @"/Views/Prestamos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dafb0e09d8695b375a7bade3da5e5653ec9a115f", @"/Views/_ViewImports.cshtml")]
    public class Views_Prestamos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prestamos.Models.Prestamo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Prestamo</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Capital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Capital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Intereses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Intereses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Periodo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Periodo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Clientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Clientes.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>

<h1>Tabla de amortizacion</h1>
<table class=""table table-bordered"">
    <thead class="" thead-dark"">
        <tr>
            <th>#Cuotas</th>
            <th>Cuota</th>
            <th>Interes mensual</th>
            <th>Amortizacion principal</th>
            <th>Amortizacion total</th>
            <th>Capital pendiente</th>
        </tr>
    </thead>
");
#nullable restore
#line 52 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
       
        double capital = Model.Capital;
        double interes = Convert.ToDouble(Model.Intereses) / 1200;
        double plazo = Convert.ToDouble(Model.Periodo);

        //Formula para los numeros de cuotas

        double cuota = capital * (interes / (double)(1 - Math.Pow(1 + (double)interes, -plazo)));
        double interesMensual = 0;
        double amortizacionPrincipal = 0;
        double amortizacionTotal = 0;
        int i = 1;

        for(i = 1; i<= plazo; i++)
        {
            interesMensual = Math.Round((interes * capital), 2);
            capital = Math.Round(capital - cuota + interesMensual, 2);


            //amortizacion, totales y principales

            amortizacionTotal += Math.Round(cuota - interesMensual, 2);
            amortizacionPrincipal = cuota - interesMensual;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 79 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 81 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
                       Write(Math.Round(cuota, MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 82 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
                       Write(Math.Round(interesMensual, MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 83 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
                       Write(Math.Round(amortizacionPrincipal, MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 84 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
                       Write(Math.Round(amortizacionTotal, MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 85 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
                       Write(Math.Round(capital, MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    </tr>\r\n\r\n            </tbody>\r\n");
#nullable restore
#line 91 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a146d41786ef7147e572b4f380b8f316fa700e2e11569", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Details.cshtml"
                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a146d41786ef7147e572b4f380b8f316fa700e2e13847", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prestamos.Models.Prestamo> Html { get; private set; }
    }
}
#pragma warning restore 1591
