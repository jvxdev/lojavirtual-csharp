#pragma checksum "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f40cb7f8a0e7b0f777a6d7d5f25836d01a1ae146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 3 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40cb7f8a0e7b0f777a6d7d5f25836d01a1ae146", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c14ce1da0f302608dfa3476ea8e48247d504f9e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/ContactPost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contato";
    LojaVirtual.Models.Contact contact = (LojaVirtual.Models.Contact)ViewData["CONTATO"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <div class=""container"">
        <div class=""row"">
            <aside class=""col-md-6"">
                <h4 class=""subtitle-doc"">
                    Nossos contatos!
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Devolução/Garantia: </dt>
                            <dd>devolucao@lojavirtual.com.br</dd>
                        </dl>
                        <dl>
                            <dt>Televendas: </dt>
                            <dd>(61) 4000-2000</dd>
                        </dl>
                        <dl>
                            <dt>SAC:</dt>
                            <dd>sac@lojavirtual.com.br</dd>
                        </dl>
                    </div>
                </div>
            </aside>
            <aside class=""col-sm-6"">

                <h4 class=""subtitle-doc"">
                    Fa");
            WriteLiteral("le conosco!\r\n                </h4>\r\n                <div>\r\n\r\n                    <article class=\"card\">\r\n                        <div class=\"card-body p-5\">\r\n");
#nullable restore
#line 41 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
                             if (ViewData["MSG_S"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"alert alert-success\">");
#nullable restore
#line 43 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
                                                          Write(ViewData["MSG_S"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 44 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
                             if (ViewData["MSG_E"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"alert alert-danger\">");
#nullable restore
#line 48 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
                                                         Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 49 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f40cb7f8a0e7b0f777a6d7d5f25836d01a1ae1467324", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label for=""nome"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" id=""name"" name=""name""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2362, "\"", 2376, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", "\r\n                                               required=\"", 2377, "\"", 2436, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2437, "\"", 2483, 1);
#nullable restore
#line 59 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
WriteAttributeValue("", 2445, contact != null ? contact.Nome : "", 2445, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label for=""email"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" id=""email"" name=""email""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3099, "\"", 3113, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                               value=\"", 3114, "\"", 3209, 1);
#nullable restore
#line 70 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
WriteAttributeValue("", 3170, contact != null ? contact.Email : "", 3170, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label for=""texto""><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" id=""text"" name=""text"" style=""width:100%"">");
#nullable restore
#line 79 "C:\Users\jvxdev\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contact.cshtml"
                                                                                                                    Write(contact != null ? contact.Texto : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </article>\r\n\r\n                </div>\r\n\r\n            </aside>\r\n        </div>\r\n    </div>\r\n</main>");
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
