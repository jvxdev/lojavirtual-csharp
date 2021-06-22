#pragma checksum "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adf8ab370363b6ca9d6a22052f78a840b0d86198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Collaborator_Views_Order_Show), @"mvc.1.0.view", @"/Areas/Collaborator/Views/Order/Show.cshtml")]
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
#line 4 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProductAggregator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Const;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\_ViewImports.cshtml"
using LojaVirtual.Areas.Collaborator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adf8ab370363b6ca9d6a22052f78a840b0d86198", @"/Areas/Collaborator/Views/Order/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fcc8b46f393922dd52e75ffaabf778f71ff6c7b", @"/Areas/Collaborator/Views/_ViewImports.cshtml")]
    public class Areas_Collaborator_Views_Order_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private global::AspNetCore.Areas_Collaborator_Views_Order_Show.__Generated__OrderSituationViewComponentTagHelper __OrderSituationViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
  
    ViewData["Title"] = "Visualizar pedido";
    TransactionPagarMe transaction = JsonConvert.DeserializeObject<TransactionPagarMe>(Model.TransactionData);
    List<ProductItem> products = JsonConvert.DeserializeObject<List<ProductItem>>(Model.ProductsData, new JsonSerializerSettings() { ContractResolver = new ProductItemResolver<List<ProductItem>>() });

    var birthDay = DateTime.Parse(transaction.Customer.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container my-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:order-situation", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adf8ab370363b6ca9d6a22052f78a840b0d861986192", async() => {
            }
            );
            __OrderSituationViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Collaborator_Views_Order_Show.__Generated__OrderSituationViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OrderSituationViewComponentTagHelper);
#nullable restore
#line 12 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
__OrderSituationViewComponentTagHelper.order = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("order", __OrderSituationViewComponentTagHelper.order, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
                REGISTRAR NOTA FISCAL
            </button>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <h3 class=""display-4 text-center mb-4"">Informações do pedido</h3>
            <table class=""table table-bordered"">
                <tr>
                    <td colspan=""6"" class=""text-center""><strong>SITUAÇÃO DO PEDIDO:</strong> ");
#nullable restore
#line 29 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                                                                        Write(Model.Situation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Cliente:</strong> ");
#nullable restore
#line 32 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                             Write(transaction.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Data de nascimento:</strong> ");
#nullable restore
#line 33 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                                        Write(birthDay.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Forma de pagamento:</strong> ");
#nullable restore
#line 36 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                                        Write(Model.PaymentForm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>N° nota fiscal:</strong> ");
#nullable restore
#line 37 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                                    Write(Model.NFE);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </table>

            <h3 class=""display-4 text-center my-4"">Endereço de entrega</h3>
            <table class=""table table-bordered"">
                <tr>
                    <td colspan=""6"" class=""text-center""><strong>");
#nullable restore
#line 44 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                                           Write(transaction.Shipping.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>CEP:</strong> ");
#nullable restore
#line 47 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                         Write(transaction.Shipping.Address.Zipcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Estado:</strong> ");
#nullable restore
#line 48 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                            Write(transaction.Shipping.Address.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Cidade:</strong> ");
#nullable restore
#line 49 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                            Write(transaction.Shipping.Address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Bairro:</strong> ");
#nullable restore
#line 50 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                            Write(transaction.Shipping.Address.Neighborhood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Rua:</strong> ");
#nullable restore
#line 51 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                         Write(transaction.Shipping.Address.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>N° casa/apart:</strong> ");
#nullable restore
#line 52 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                                   Write(transaction.Shipping.Address.StreetNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Empresa de entrega:</strong> ");
#nullable restore
#line 55 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                                        Write(Model.FreteCompany);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Valor do frete:</strong> ");
#nullable restore
#line 56 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                                    Write(Mask.ConvertPagarMeIntToDecimal(transaction.Shipping.Fee).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td colspan=\"4\"><strong>Código de rastreamento:</strong> ");
#nullable restore
#line 57 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                                                                        Write(Model.FreteTrackingCod);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </table>

            <h3 class=""display-4 text-center my-4"">Produtos do pedido</h3>
            <table class=""table table-bordered"">
                <tr>
                    <th>Nome</th>
                    <th>Quantidade</th>
                    <th>Valor (unid)</th>
                    <th>Valor total (todas unid)</th>
                </tr>

");
#nullable restore
#line 70 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                 foreach (var product in products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 74 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                       Write(product.ItensKartAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                       Write(product.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                        Write((product.Price * product.ItensKartAmount).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 78 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <tr>\r\n                    <td colspan=\"3\"><strong>FRETE</strong></td>\r\n                    <td><strong>");
#nullable restore
#line 82 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                           Write(Mask.ConvertPagarMeIntToDecimal(transaction.Shipping.Fee).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"3\"><strong>TOTAL</strong></td>\r\n                    <td><strong>");
#nullable restore
#line 86 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Areas\Collaborator\Views\Order\Show.cshtml"
                           Write(Model.TotalValue.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                </tr>\r\n            </table>\r\n\r\n            <button class=\"mt-3 btn btn-primary btn-imprimir\">Imprimir</button>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf8ab370363b6ca9d6a22052f78a840b0d8619817652", async() => {
                WriteLiteral(@"
    <div class=""modal fade"" id=""nfe"" tabindex=""-1"" role=""dialog"" aria-labelledby=""nfe"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">NOTA FISCAL - Eletrônica</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""mb-3"">
                        <label for=""control-nfe"" class=""form-label"">Link da NF-e</label>
                        <input type=""url"" class=""form-control"" id=""control-nfe"" name=""nfe_url"" placeholder=""URL - NF-e"">
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Fechar</button>
                        <button type=""submit"" class=""btn b");
                WriteLiteral("tn-dark\">Registrar</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:order-situation")]
        public class __Generated__OrderSituationViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__OrderSituationViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public LojaVirtual.Models.Order order { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("OrderSituation", new { order });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
