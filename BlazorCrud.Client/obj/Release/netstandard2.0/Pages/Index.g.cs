#pragma checksum "C:\Users\Uguralp\Desktop\Q&A_Assignment4\BlazorCrud\BlazorCrud.Client\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bc15f49d5bd23fc212d63bdbc01f4b465f456bb"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Welcome!");
            builder.CloseElement();
            builder.AddContent(2, "\n\nWelcome to my web app.\n\n");
            builder.OpenElement(3, "p");
            builder.AddContent(4, "You can add vehicle with the user\'s information.");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591