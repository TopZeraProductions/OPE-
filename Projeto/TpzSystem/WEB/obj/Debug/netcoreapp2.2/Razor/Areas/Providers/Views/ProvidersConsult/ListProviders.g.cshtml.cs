#pragma checksum "/home/notim/GitHub/TopZera/OPE/Projeto/TpzSystem/WEB/Areas/Providers/Views/ProvidersConsult/ListProviders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1180938674717df5cfb73df85fe8449769cb302e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Providers_Views_ProvidersConsult_ListProviders), @"mvc.1.0.view", @"/Areas/Providers/Views/ProvidersConsult/ListProviders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Providers/Views/ProvidersConsult/ListProviders.cshtml", typeof(AspNetCore.Areas_Providers_Views_ProvidersConsult_ListProviders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1180938674717df5cfb73df85fe8449769cb302e", @"/Areas/Providers/Views/ProvidersConsult/ListProviders.cshtml")]
    public class Areas_Providers_Views_ProvidersConsult_ListProviders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/notim/GitHub/TopZera/OPE/Projeto/TpzSystem/WEB/Areas/Providers/Views/ProvidersConsult/ListProviders.cshtml"
  
    ViewBag.Title = "Products";
    Layout = "masterpage";

#line default
#line hidden
            BeginContext(64, 3547, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""modalcadastrocliente"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog  modal-lg"" role=""document"">
        <div class=""modal-content"">
            
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Adicionar Fornecedor</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""form-group col-md-6"">
                        <label>Nome do Foncecedor</label>
                        <input type=""text"" class=""form-control"" placeholder=""Nome do produto"" aria-label="""" aria-describedby=""basic-addon2"">
                    </div>
                    
                    <div class=""form-group col-md-6"">
                        <labe");
            WriteLiteral(@"l>Telefone:</label>
                        <input type=""text"" class=""form-control"" placeholder=""(__)____-____"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                    </div>
                    
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                    <button type=""button"" class=""btn btn-primary"">Salvar Dados</button>
                </div>
            </div>
        </div>
    </div>
</div>

<article id=""dados-clientes"">
    <div class=""row"">
        <div class=""col-12"">
            <h4>Fornecedores cadastrados no sistema</h4>
        </div>
        <div class=""col-8"">
            <div class=""input-group mb-3"">
                <input type=""text"" class=""form-control"" placeholder=""Digite para pesquisar"" aria-label=""Digite para pesquisar"" aria-describedby=""basic-addon2"">
                <div class=""input-group-append"">
                    <button c");
            WriteLiteral(@"lass=""btn btn-outline-secondary"" type=""button"">
                        <i class=""fa fa-search""></i>
                    </button>
                </div>
            </div>
        </div>
        <div class=""col-4"">
            <button type=""button"" class=""btn btn-outline-secondary"" data-toggle=""modal"" data-target=""#modalcadastrocliente"">
                <i class=""fa fa-plus""></i>
                Novo Fornecedor
            </button>
        </div>
    </div>
</article>

<div class=""row"" style=""padding: 10px; margin: 10px; border: 1px solid #2f4f4f"">
    <div class=""col-md-10"">
        <p>DAVO</p>
        <p>
            <strong>Telefone: 11 55669-8485</strong>
        </p>
    </div>
    <div class=""col-md-2"">
        <a href=""#"" style=""color: #1b1e21"">
            <i class=""fas fa-edit""></i>
            Editar
        </a>
        <br/>
        <a href=""#"" style=""color: #1b1e21"">
            <i class=""fas fa-trash""></i>
            Excluir
        </a>
    </div>
</div>

<div class=""row"" style=""padding: 10p");
            WriteLiteral(@"x; margin: 10px; border: 1px solid #2f4f4f"">
    <div class=""col-md-10"">
        <p>DAVO</p>
        <p>
            <strong>Telefone: 11 55669-8485</strong>
        </p>
    </div>
    <div class=""col-md-2"">
        <a href=""#"" style=""color: #1b1e21"">
            <i class=""fas fa-edit""></i>
            Editar
        </a>
        <br/>
        <a href=""#"" style=""color: #1b1e21"">
            <i class=""fas fa-trash""></i>
            Excluir
        </a>
    </div>
</div>
");
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
