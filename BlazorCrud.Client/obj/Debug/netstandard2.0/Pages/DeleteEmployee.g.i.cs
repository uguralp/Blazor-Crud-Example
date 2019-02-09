#pragma checksum "C:\Users\Uguralp\Desktop\BlazorCrud\BlazorCrud.Client\Pages\DeleteEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "980975863626d7935443ee45c88d8e2bc641115f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCrud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BlazorCrud.Client;
    using BlazorCrud.Client.Shared;
    using BlazorCrud.Shared.Models;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/delete/{empID}")]
    public class DeleteEmployee : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 35 "C:\Users\Uguralp\Desktop\BlazorCrud\BlazorCrud.Client\Pages\DeleteEmployee.cshtml"
            

[Parameter]
string empID { get; set; }

Employee emp = new Employee();

protected override async Task OnInitAsync()
{
    emp = await Http.GetJsonAsync<Employee>
    ("/api/Employee/Details/" + Convert.ToInt32(empID));
}

protected async Task Delete()
{
    await Http.DeleteAsync("api/Employee/Delete/" + Convert.ToInt32(empID));
    UriHelper.NavigateTo("/fetchemployee");
}

void cancel()
{
    UriHelper.NavigateTo("/fetchemployee");
}


#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
