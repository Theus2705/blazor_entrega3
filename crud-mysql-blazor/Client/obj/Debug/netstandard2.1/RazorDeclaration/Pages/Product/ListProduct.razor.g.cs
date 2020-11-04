#pragma checksum "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\Pages\Product\ListProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "710175263616023bc9cca34b4dab1fa6ace5f0f8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor_mysql.Client.Pages.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\_Imports.razor"
using blazor_mysql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\_Imports.razor"
using blazor_mysql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\_Imports.razor"
using blazor_mysql.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\Pages\Product\ListProduct.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/ListProduct")]
    public partial class ListProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "c:\Users\EDUgi\Projetos\crud_mysq_blazor\blazor-mysql\Client\Pages\Product\ListProduct.razor"
       

    private List<Product> productList = new List<Product>();

    protected override async Task OnInitializedAsync()
    {

        var products = await Http.GetFromJsonAsync<List<Product>>("/Product/List");
        foreach (var item in products)
        {
            productList.Add(item);
        }
    }

    private async Task DeleteProduct(int itemId)
    {
        //call controller
        await Http.DeleteAsync("/Product/Delete/"+itemId);
        NavigationManager.NavigateTo("Product/ListProduct", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
