#pragma checksum "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3860aef41c4e03e6e53db239697b1675825bf3d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Show), @"mvc.1.0.view", @"/Views/Product/Show.cshtml")]
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
#line 4 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3860aef41c4e03e6e53db239697b1675825bf3d2", @"/Views/Product/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca47e21a6ca307b79ec2d96de648391fbbafc267", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/img-product-example.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/img-product-example.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""col-md-12"">
        <section id=""product_detail"">
            <h2 class=""title-doc display-4 my-5"">Detalhes do produto</h2>
            <div id=""code_prod_detail"">
                <div class=""card"">
                    <div class=""row no-gutters"">
                        <aside class=""col-sm-5 border-right"">
                            <article class=""gallery-wrap"">
                                <div class=""img-big-wrap"">
");
#nullable restore
#line 13 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                     if (Model.Images != null && Model.Images.Count > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div> <a");
            BeginWriteAttribute("href", " href=\"", 673, "\"", 711, 1);
#nullable restore
#line 15 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
WriteAttributeValue("", 680, Model.Images.ElementAt(0).Path, 680, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-fancybox><img");
            BeginWriteAttribute("src", " src=\"", 731, "\"", 768, 1);
#nullable restore
#line 15 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
WriteAttributeValue("", 737, Model.Images.ElementAt(0).Path, 737, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n");
#nullable restore
#line 16 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3860aef41c4e03e6e53db239697b1675825bf3d26553", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3860aef41c4e03e6e53db239697b1675825bf3d26769", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-fancybox", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"img-small-wrap\">\r\n");
#nullable restore
#line 23 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                     if (Model.Images != null && Model.Images.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                         foreach (Image image in Model.Images)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"item-gallery\"> <img");
            BeginWriteAttribute("src", " src=\"", 1523, "\"", 1540, 1);
#nullable restore
#line 27 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
WriteAttributeValue("", 1529, image.Path, 1529, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 28 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                         

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </article>
                        </aside>
                        <aside class=""col-sm-7"">
                            <article class=""p-5"">
                                <h3 class=""title mb-3"">");
#nullable restore
#line 36 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                                <div class=\"mb-3\">\r\n                                    <var class=\"price h3 text-warning\">\r\n                                        <span class=\"currency\"></span><span class=\"num\">");
#nullable restore
#line 40 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                                                                   Write(Model.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </var>
                                    <span>/unid</span>
                                </div>
                                <dl>
                                    <dt>Descrição</dt>
                                    <dd>
                                        <p>
                                            ");
#nullable restore
#line 48 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                    </dd>
                                </dl>

                                <dl class=""row"">
                                    <dt class=""col-sm-3"">Peso</dt>
                                    <dd class=""col-sm-9"">");
#nullable restore
#line 55 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                                    Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (kg) </dd>\r\n\r\n                                    <dt class=\"col-sm-3\">Largura</dt>\r\n                                    <dd class=\"col-sm-9\">");
#nullable restore
#line 58 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                                    Write(Model.Width);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (cm) </dd>\r\n\r\n                                    <dt class=\"col-sm-3\">Altura</dt>\r\n                                    <dd class=\"col-sm-9\">");
#nullable restore
#line 61 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                                    Write(Model.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (cm) </dd>\r\n\r\n                                    <dt class=\"col-sm-3\">Comprimento</dt>\r\n                                    <dd class=\"col-sm-9\">");
#nullable restore
#line 64 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                                    Write(Model.Lenght);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (cm) </dd>\r\n\r\n                                    <dt class=\"col-sm-3\">Em estoque</dt>\r\n                                    <dd class=\"col-sm-9\">");
#nullable restore
#line 67 "C:\Users\emotionalboys\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Product\Show.cshtml"
                                                    Write(Model.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" (unidades) </dd>
                                </dl>
                                <hr>
                                <div class=""row"">
                                    <div class=""col-sm-5"">
                                        <dl class=""dlist-inline"">
                                            <dt>Quantity: </dt>
                                            <dd>
                                                <select class=""form-control form-control-sm"" style=""width:70px;"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3860aef41c4e03e6e53db239697b1675825bf3d215713", async() => {
                WriteLiteral(" 1 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3860aef41c4e03e6e53db239697b1675825bf3d216721", async() => {
                WriteLiteral(" 2 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3860aef41c4e03e6e53db239697b1675825bf3d217729", async() => {
                WriteLiteral(" 3 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </select>
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <hr>
                                <a href=""#"" class=""btn  btn-outline-primary""> <i class=""fas fa-shopping-cart""></i> Adicionar ao carrinho </a>
                            </article>
                        </aside>
                    </div>
                </div>
            </div>
        </section>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
