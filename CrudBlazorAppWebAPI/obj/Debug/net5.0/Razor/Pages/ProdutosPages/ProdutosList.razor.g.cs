#pragma checksum "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a8b775f1d0a398b701d8acb85b7a5e292ca1ab7"
// <auto-generated/>
#pragma warning disable 1591
namespace CrudBlazorAppWebAPI.Pages.ProdutosPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using CrudBlazorAppWebAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\_Imports.razor"
using CrudBlazorAppWebAPI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
using CrudBlazorAppWebAPI.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProdutosPages/ProdutosList")]
    public partial class ProdutosList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<a class=\"btn btn-info\" href=\"/produtospages/add\">Criar Novo</a>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Lista de Produtos</h3>");
#nullable restore
#line 9 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
 if(Produtos==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em> Loading...  </em></p>");
#nullable restore
#line 12 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Nome</th>\r\n                <th>Tipo</th>\r\n                <th>Ação</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 24 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
             foreach(var produtos in Produtos)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 27 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
                         produtos.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 28 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
                         produtos.Tipo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "/produtospages/edit/" + (
#nullable restore
#line 30 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
                                                      produtos.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "text-danger");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
                                                         (()=>Delete(produtos.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Deletar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\ProdutosList.razor"
       
    public List<Produtos> Produtos { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Produtos = await Http.GetFromJsonAsync<List<Produtos>>("https://localhost:44309/api/Produtos/GetAllAdd");
    }

    public async Task Delete(int Id)
    {
        bool isConfirm = await js.InvokeAsync<bool>("confirm", "Deseja realmente deletar este produto?");
        if (isConfirm)
        {
            await Http.DeleteAsync("https://localhost:44309/api/Produtos/Delete?=" + Id);
            //await OnInitializedAsync();
            Produtos = Produtos.Where(c => c.Id != Id).ToList();

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591