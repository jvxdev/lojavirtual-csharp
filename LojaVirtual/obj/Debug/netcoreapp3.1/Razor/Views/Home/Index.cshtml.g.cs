#pragma checksum "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2769c5a7de5151981f09df60cac9798e5e7028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 4 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProductAggregator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModel.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2769c5a7de5151981f09df60cac9798e5e7028", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"196eb434ce273ddae17d94b813486485f73bb699", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsletterEmail>
    {
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
        private global::AspNetCore.Views_Home_Index.__Generated__ProductListViewComponentTagHelper __ProductListViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Página Inicial";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">
    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <img class=""first-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                     alt=""First slide"">
                <div class=""container"">
                    <div class=""carousel-caption text-left"">
                        <h1>Example headline.</h1>
                        <p>
                            Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id");
            WriteLiteral(@" elit.
                        </p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Sign up today</a></p>
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <img class=""second-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                     alt=""Second slide"">
                <div class=""container"">
                    <div class=""carousel-caption"">
                        <h1>Another example headline.</h1>
                        <p>
                            Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                        </p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Learn more</a></p>
                    </div>
                </div>
");
            WriteLiteral(@"            </div>
            <div class=""carousel-item"">
                <img class=""third-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                     alt=""Third slide"">
                <div class=""container"">
                    <div class=""carousel-caption text-right"">
                        <h1>One more for good measure.</h1>
                        <p>
                            Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                        </p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Browse gallery</a></p>
                    </div>
                </div>
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" ");
            WriteLiteral(@"aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>

    <h1 class=""display-2 text-center text-dark mb-5"">
        Últimos lançamentos
    </h1>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:product-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2769c5a7de5151981f09df60cac9798e5e70288149", async() => {
            }
            );
            __ProductListViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Home_Index.__Generated__ProductListViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__ProductListViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n</main>\r\n\r\n");
#nullable restore
#line 76 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Home\Index.cshtml"
 using (Html.BeginForm(null, null, null, FormMethod.Post, true, new { @action = Url.Action("Index", "Home") + "#form" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container mt-5\" id=\"form\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-8 offset-sm-2\">\r\n");
#nullable restore
#line 81 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Home\Index.cshtml"
             if (TempData["MSG_S"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"alert alert-success text-center\">");
#nullable restore
#line 83 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Home\Index.cshtml"
                                                      Write(TempData["MSG_S"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 84 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col-md-10"">
            <div class=""form-group"">
                <label for=""email"" class=""font-weight-light"">Cadastre seu e-mail para receber novas promoções:</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text""><i class=""fa fa-envelope""></i></span>
                    </div>
                    ");
#nullable restore
#line 93 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Home\Index.cshtml"
               Write(Html.EditorFor(m => m.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <span style=\"color: darkred;\">");
#nullable restore
#line 95 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Home\Index.cshtml"
                                         Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-2 mt-2\">\r\n            <br />\r\n            <button class=\"subscribe btn btn-primary btn-block\" type=\"submit\"> Cadastrar </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 104 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsletterEmail> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:product-list")]
        public class __Generated__ProductListViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__ProductListViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("ProductList", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
