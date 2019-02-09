#pragma checksum "C:\Users\Uguralp\Desktop\Q&A_Assignment4\BlazorCrud\BlazorCrud.Client\Pages\DeleteUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4972a53a3f63989a9279ce4d30ee1c0d0b0d6e0c"
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
    using BlazorCrud.Shared.Models;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/delete/{userID}")]
    public class DeleteUser : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h2");
            builder.AddContent(1, "Delete");
            builder.CloseElement();
            builder.AddContent(2, "\n");
            builder.OpenElement(3, "h3");
            builder.AddContent(4, "Are you sure you want to delete employee with id : ");
            builder.AddContent(5, userID);
            builder.CloseElement();
            builder.AddContent(6, "\n");
            builder.OpenElement(7, "br");
            builder.CloseElement();
            builder.AddContent(8, "\n\n");
            builder.OpenElement(9, "div");
            builder.AddAttribute(10, "class", "col-md-4");
            builder.AddContent(11, "\n    ");
            builder.OpenElement(12, "table");
            builder.AddAttribute(13, "class", "table");
            builder.AddContent(14, "\n        ");
            builder.OpenElement(15, "tr");
            builder.AddContent(16, "\n            ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, "Fullname");
            builder.CloseElement();
            builder.AddContent(19, "\n            ");
            builder.OpenElement(20, "td");
            builder.AddContent(21, usr.Fullname);
            builder.CloseElement();
            builder.AddContent(22, "\n        ");
            builder.CloseElement();
            builder.AddContent(23, "\n        ");
            builder.OpenElement(24, "tr");
            builder.AddContent(25, "\n            ");
            builder.OpenElement(26, "td");
            builder.AddContent(27, "Email");
            builder.CloseElement();
            builder.AddContent(28, "\n            ");
            builder.OpenElement(29, "td");
            builder.AddContent(30, usr.Email);
            builder.CloseElement();
            builder.AddContent(31, "\n        ");
            builder.CloseElement();
            builder.AddContent(32, "\n        ");
            builder.OpenElement(33, "tr");
            builder.AddContent(34, "\n            ");
            builder.OpenElement(35, "td");
            builder.AddContent(36, "Address");
            builder.CloseElement();
            builder.AddContent(37, "\n            ");
            builder.OpenElement(38, "td");
            builder.AddContent(39, usr.Address);
            builder.CloseElement();
            builder.AddContent(40, "\n        ");
            builder.CloseElement();
            builder.AddContent(41, "\n        ");
            builder.OpenElement(42, "tr");
            builder.AddContent(43, "\n            ");
            builder.OpenElement(44, "td");
            builder.AddContent(45, "City");
            builder.CloseElement();
            builder.AddContent(46, "\n            ");
            builder.OpenElement(47, "td");
            builder.AddContent(48, usr.City);
            builder.CloseElement();
            builder.AddContent(49, "\n        ");
            builder.CloseElement();
            builder.AddContent(50, "\n        ");
            builder.OpenElement(51, "tr");
            builder.AddContent(52, "\n            ");
            builder.OpenElement(53, "td");
            builder.AddContent(54, "Phone Number");
            builder.CloseElement();
            builder.AddContent(55, "\n            ");
            builder.OpenElement(56, "td");
            builder.AddContent(57, usr.PhoneNumber);
            builder.CloseElement();
            builder.AddContent(58, "\n        ");
            builder.CloseElement();
            builder.AddContent(59, "\n        ");
            builder.OpenElement(60, "tr");
            builder.AddContent(61, "\n            ");
            builder.OpenElement(62, "td");
            builder.AddContent(63, "Vehicle Name");
            builder.CloseElement();
            builder.AddContent(64, "\n            ");
            builder.OpenElement(65, "td");
            builder.AddContent(66, usr.Vname);
            builder.CloseElement();
            builder.AddContent(67, "\n        ");
            builder.CloseElement();
            builder.AddContent(68, "\n        ");
            builder.OpenElement(69, "tr");
            builder.AddContent(70, "\n            ");
            builder.OpenElement(71, "td");
            builder.AddContent(72, "Vehicle Model");
            builder.CloseElement();
            builder.AddContent(73, "\n            ");
            builder.OpenElement(74, "td");
            builder.AddContent(75, usr.Vmodel);
            builder.CloseElement();
            builder.AddContent(76, "\n        ");
            builder.CloseElement();
            builder.AddContent(77, "\n        ");
            builder.OpenElement(78, "tr");
            builder.AddContent(79, "\n            ");
            builder.OpenElement(80, "td");
            builder.AddContent(81, "Vehicle Year");
            builder.CloseElement();
            builder.AddContent(82, "\n            ");
            builder.OpenElement(83, "td");
            builder.AddContent(84, usr.Vyear);
            builder.CloseElement();
            builder.AddContent(85, "\n        ");
            builder.CloseElement();
            builder.AddContent(86, "\n    ");
            builder.CloseElement();
            builder.AddContent(87, "\n    ");
            builder.OpenElement(88, "div");
            builder.AddAttribute(89, "class", "form-group");
            builder.AddContent(90, "\n        ");
            builder.OpenElement(91, "input");
            builder.AddAttribute(92, "type", "submit");
            builder.AddAttribute(93, "value", "Delete");
            builder.AddAttribute(94, "class", "btn btn-default");
            builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(async () => await Delete()));
            builder.CloseElement();
            builder.AddContent(96, "\n        ");
            builder.OpenElement(97, "input");
            builder.AddAttribute(98, "type", "submit");
            builder.AddAttribute(99, "value", "Cancel");
            builder.AddAttribute(100, "class", "btn");
            builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(cancel));
            builder.CloseElement();
            builder.AddContent(102, "\n    ");
            builder.CloseElement();
            builder.AddContent(103, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 51 "C:\Users\Uguralp\Desktop\Q&A_Assignment4\BlazorCrud\BlazorCrud.Client\Pages\DeleteUser.cshtml"
            

[Parameter]
string userID { get; set; }

User usr = new User();

protected override async Task OnInitAsync()
{
    usr = await Http.GetJsonAsync<User>
    ("/api/User/Details/" + Convert.ToInt32(userID));
}

protected async Task Delete()
{
    await Http.DeleteAsync("api/User/Delete/" + Convert.ToInt32(userID));
    UriHelper.NavigateTo("/fetchuser");
}

void cancel()
{
    UriHelper.NavigateTo("/fetchuser");
}


#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
