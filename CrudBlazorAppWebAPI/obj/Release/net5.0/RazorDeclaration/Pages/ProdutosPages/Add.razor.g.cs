// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\Add.razor"
using CrudBlazorAppWebAPI.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProdutosPages/Add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Projetos_CSharp\CrudBlazorAppWebAPI\CrudBlazorAppWebAPI\Pages\ProdutosPages\Add.razor"
       

    Produtos produtos = new Produtos();
    string message = "";
    async Task AddProdutos()
    {
        var data = await Http.PostAsJsonAsync<Produtos>("https://localhost:44309/api/Produtos/Add", produtos);
        message = "Dados salvos com sucesso";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
