#pragma checksum "C:\Users\Uguralp\Desktop\Q&A_Assignment4\BlazorCrud\BlazorCrud.Client\Pages\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e962e46710da56eb51e987b8c978c44cda851e"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/adduser")]
    public class AddUser : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Create");
            builder.CloseElement();
            builder.AddContent(2, "\n");
            builder.OpenElement(3, "h3");
            builder.AddContent(4, "User");
            builder.CloseElement();
            builder.AddContent(5, "\n");
            builder.OpenElement(6, "hr");
            builder.CloseElement();
            builder.AddContent(7, "\n");
            builder.OpenElement(8, "div");
            builder.AddAttribute(9, "class", "row");
            builder.AddContent(10, "\n    ");
            builder.OpenElement(11, "div");
            builder.AddAttribute(12, "class", "col-md-4");
            builder.AddContent(13, "\n        ");
            builder.OpenElement(14, "form");
            builder.AddContent(15, "\n            ");
            builder.OpenElement(16, "div");
            builder.AddAttribute(17, "class", "form-group");
            builder.AddContent(18, "\n                ");
            builder.OpenElement(19, "label");
            builder.AddAttribute(20, "for", "Fullname");
            builder.AddAttribute(21, "class", "control-label");
            builder.AddContent(22, "Seller Name");
            builder.CloseElement();
            builder.AddContent(23, "\n                ");
            builder.OpenElement(24, "input");
            builder.AddAttribute(25, "asp-validation-for", "Fullname");
            builder.AddAttribute(26, "for", "Fullname");
            builder.AddAttribute(27, "class", "form-control");
            builder.AddAttribute(28, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(usr.Fullname));
            builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => usr.Fullname = __value, usr.Fullname));
            builder.CloseElement();
            builder.AddContent(30, "\n                ");
            builder.OpenElement(31, "span");
            builder.AddAttribute(32, "style", "color:red;");
            builder.AddContent(33, error.FullnameError);
            builder.CloseElement();
            builder.AddContent(34, "\n            ");
            builder.CloseElement();
            builder.AddContent(35, "\n            ");
            builder.OpenElement(36, "div");
            builder.AddAttribute(37, "class", "form-group");
            builder.AddContent(38, "\n                ");
            builder.OpenElement(39, "label");
            builder.AddAttribute(40, "asp-for", "Email");
            builder.AddAttribute(41, "class", "control-label");
            builder.AddContent(42, "Email");
            builder.CloseElement();
            builder.AddContent(43, "\n                ");
            builder.OpenElement(44, "input");
            builder.AddAttribute(45, "for", "Email");
            builder.AddAttribute(46, "class", "form-control");
            builder.AddAttribute(47, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(usr.Email));
            builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => usr.Email = __value, usr.Email));
            builder.CloseElement();
            builder.AddContent(49, "\n                ");
            builder.OpenElement(50, "span");
            builder.AddAttribute(51, "style", "color:red;");
            builder.AddContent(52, error.EmailError);
            builder.CloseElement();
            builder.AddContent(53, "\n            ");
            builder.CloseElement();
            builder.AddContent(54, "\n            ");
            builder.OpenElement(55, "div");
            builder.AddAttribute(56, "class", "form-group");
            builder.AddContent(57, "\n                ");
            builder.OpenElement(58, "label");
            builder.AddAttribute(59, "asp-for", "Address");
            builder.AddAttribute(60, "class", "control-label");
            builder.AddContent(61, "Address");
            builder.CloseElement();
            builder.AddContent(62, "\n                ");
            builder.OpenElement(63, "input");
            builder.AddAttribute(64, "asp-for", "Address");
            builder.AddAttribute(65, "class", "form-control");
            builder.AddAttribute(66, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(usr.Address));
            builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => usr.Address = __value, usr.Address));
            builder.CloseElement();
            builder.AddContent(68, "\n                ");
            builder.OpenElement(69, "span");
            builder.AddAttribute(70, "style", "color:red;");
            builder.AddContent(71, error.AddressError);
            builder.CloseElement();
            builder.AddContent(72, "\n            ");
            builder.CloseElement();
            builder.AddContent(73, "\n            ");
            builder.OpenElement(74, "div");
            builder.AddAttribute(75, "class", "form-group");
            builder.AddContent(76, "\n                ");
            builder.OpenElement(77, "label");
            builder.AddAttribute(78, "asp-for", "City");
            builder.AddAttribute(79, "class", "control-label");
            builder.AddContent(80, "City");
            builder.CloseElement();
            builder.AddContent(81, "\n                ");
            builder.OpenElement(82, "input");
            builder.AddAttribute(83, "asp-for", "City");
            builder.AddAttribute(84, "class", "form-control");
            builder.AddAttribute(85, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(usr.City));
            builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => usr.City = __value, usr.City));
            builder.CloseElement();
            builder.AddContent(87, "\n                ");
            builder.OpenElement(88, "span");
            builder.AddAttribute(89, "style", "color:red;");
            builder.AddContent(90, error.CityError);
            builder.CloseElement();
            builder.AddContent(91, "\n            ");
            builder.CloseElement();
            builder.AddContent(92, "\n            ");
            builder.OpenElement(93, "div");
            builder.AddAttribute(94, "class", "form-group");
            builder.AddContent(95, "\n                ");
            builder.OpenElement(96, "label");
            builder.AddAttribute(97, "asp-for", "PhoneNumber");
            builder.AddAttribute(98, "class", "control-label");
            builder.AddContent(99, "Phone Number");
            builder.CloseElement();
            builder.AddContent(100, "\n                ");
            builder.OpenElement(101, "input");
            builder.AddAttribute(102, "asp-for", "Phone Number");
            builder.AddAttribute(103, "class", "form-control");
            builder.AddAttribute(104, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(usr.PhoneNumber));
            builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => usr.PhoneNumber = __value, usr.PhoneNumber));
            builder.CloseElement();
            builder.AddContent(106, "\n                ");
            builder.OpenElement(107, "span");
            builder.AddAttribute(108, "style", "color:red;");
            builder.AddContent(109, error.PhoneNumberError);
            builder.CloseElement();
            builder.AddContent(110, "\n            ");
            builder.CloseElement();
            builder.AddContent(111, "\n            ");
            builder.OpenElement(112, "div");
            builder.AddAttribute(113, "class", "form-group");
            builder.AddContent(114, "\n                ");
            builder.OpenElement(115, "label");
            builder.AddAttribute(116, "asp-for", "Vname");
            builder.AddAttribute(117, "class", "control-label");
            builder.AddContent(118, "Vehicle Name");
            builder.CloseElement();
            builder.AddContent(119, "\n                ");
            builder.OpenElement(120, "input");
            builder.AddAttribute(121, "asp-for", "Vname");
            builder.AddAttribute(122, "class", "form-control");
            builder.AddAttribute(123, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(usr.Vname));
            builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => usr.Vname = __value, usr.Vname));
            builder.CloseElement();
            builder.AddContent(125, "\n                ");
            builder.OpenElement(126, "span");
            builder.AddAttribute(127, "style", "color:red;");
            builder.AddContent(128, error.VnameError);
            builder.CloseElement();
            builder.AddContent(129, "\n            ");
            builder.CloseElement();
            builder.AddContent(130, "\n            ");
            builder.OpenElement(131, "div");
            builder.AddAttribute(132, "class", "form-group");
            builder.AddContent(133, "\n                ");
            builder.OpenElement(134, "label");
            builder.AddAttribute(135, "asp-for", "Vmodel");
            builder.AddAttribute(136, "class", "control-label");
            builder.AddContent(137, "Vehicle Model");
            builder.CloseElement();
            builder.AddContent(138, "\n                ");
            builder.OpenElement(139, "input");
            builder.AddAttribute(140, "asp-for", "Vmodel");
            builder.AddAttribute(141, "class", "form-control");
            builder.AddAttribute(142, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(usr.Vmodel));
            builder.AddAttribute(143, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => usr.Vmodel = __value, usr.Vmodel));
            builder.CloseElement();
            builder.AddContent(144, "\n                ");
            builder.OpenElement(145, "span");
            builder.AddAttribute(146, "style", "color:red;");
            builder.AddContent(147, error.VmodelError);
            builder.CloseElement();
            builder.AddContent(148, "\n            ");
            builder.CloseElement();
            builder.AddContent(149, "\n            ");
            builder.OpenElement(150, "div");
            builder.AddAttribute(151, "class", "form-group");
            builder.AddContent(152, "\n                ");
            builder.OpenElement(153, "label");
            builder.AddAttribute(154, "asp-for", "Vyear");
            builder.AddAttribute(155, "class", "control-label");
            builder.AddContent(156, "Vehicle Year");
            builder.CloseElement();
            builder.AddContent(157, "\n                ");
            builder.OpenElement(158, "input");
            builder.AddAttribute(159, "asp-for", "Vyear");
            builder.AddAttribute(160, "class", "form-control");
            builder.AddAttribute(161, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(usr.Vyear));
            builder.AddAttribute(162, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => usr.Vyear = __value, usr.Vyear));
            builder.CloseElement();
            builder.AddContent(163, "\n                ");
            builder.OpenElement(164, "span");
            builder.AddAttribute(165, "style", "color:red;");
            builder.AddContent(166, error.VyearError);
            builder.CloseElement();
            builder.AddContent(167, "\n            ");
            builder.CloseElement();
            builder.AddContent(168, "\n            ");
            builder.OpenElement(169, "div");
            builder.AddAttribute(170, "class", "form-group");
            builder.AddContent(171, "\n                ");
            builder.OpenElement(172, "button");
            builder.AddAttribute(173, "type", "submit");
            builder.AddAttribute(174, "class", "btn btn-default");
            builder.AddAttribute(175, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(async () => await CreateUser()));
            builder.AddContent(176, "Save");
            builder.CloseElement();
            builder.AddContent(177, "\n                ");
            builder.OpenElement(178, "button");
            builder.AddAttribute(179, "class", "btn");
            builder.AddAttribute(180, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(cancel));
            builder.AddContent(181, "Cancel");
            builder.CloseElement();
            builder.AddContent(182, "\n            ");
            builder.CloseElement();
            builder.AddContent(183, "\n        ");
            builder.CloseElement();
            builder.AddContent(184, "\n    ");
            builder.CloseElement();
            builder.AddContent(185, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 60 "C:\Users\Uguralp\Desktop\Q&A_Assignment4\BlazorCrud\BlazorCrud.Client\Pages\AddUser.cshtml"
            

    User usr = new User();
    InputError error = new InputError();
    BoolError boolError = new BoolError();
    Int32 value;

    #region Createuser function
    protected async Task CreateUser()
    {
        //var email = new System.Net.Mail.MailAddress(usr.Email);

        if (string.IsNullOrWhiteSpace(usr.Fullname) || Int32.TryParse(usr.Fullname, out value) || usr.Fullname.Any(c => char.IsDigit(c)))
        {
            error.FullnameError = "Incorrect value!";
            boolError.FullnameError = true;
        }
        else {
            error.FullnameError = "";
            boolError.FullnameError = false;
        }
        if (string.IsNullOrWhiteSpace(usr.Email) || !usr.Email.ToLower().Contains("@"))
        {
            error.EmailError = "Incorrect value!";
            boolError.EmailError = true;
        }
        else {
            error.EmailError = "";
            boolError.EmailError = false;
        }
        if (string.IsNullOrWhiteSpace(usr.Address))
        {
            error.AddressError = "Incorrect value!";
            boolError.AddressError = true;
        }
        else {
            error.AddressError = "";
            boolError.AddressError = false;
        }
        if (string.IsNullOrWhiteSpace(usr.City))
        {
            error.CityError = "Incorrect value!";
            boolError.CityError = true;
        }
        else {
            error.CityError = "";
            boolError.CityError = false; }

        if (string.IsNullOrWhiteSpace(usr.PhoneNumber))
        {
            error.PhoneNumberError = "Incorrect value!";
            boolError.PhoneNumberError = true;
        }
        else {
            error.PhoneNumberError = "";
            boolError.PhoneNumberError = false;
        }
        if (string.IsNullOrWhiteSpace(usr.Vname))
        {
            error.VnameError = "Incorrect value!";
            boolError.PhoneNumberError = true;
        }
        else {
            error.VnameError = "";
            boolError.PhoneNumberError = false;
        }
        if (string.IsNullOrWhiteSpace(usr.Vmodel))
        {
            error.VmodelError = "Incorrect value!";
            boolError.VmodelError = true;
        }
        else {
            error.VmodelError = "";
            boolError.VmodelError = false;
        }

        if (string.IsNullOrWhiteSpace(usr.Vyear))
        {
            error.VyearError = "Incorrect value!";
            boolError.VyearError = true;
        }
        else
        {
            error.VyearError = "";
            boolError.VyearError = false;
        }

        if (usr.PhoneNumber.Length != 11)
        {
            error.PhoneNumberError = "It should be 11 digit!";
            boolError.PhoneNumberError = true;
        }
        else
        {
            error.PhoneNumberError = "";
            boolError.PhoneNumberError = false;
        }


        if (boolError.FullnameError == true || boolError.EmailError == true || boolError.AddressError == true
        || boolError.CityError == true || boolError.PhoneNumberError == true || boolError.VmodelError == true
        || boolError.VyearError == true || boolError.VnameError == true)
        {

        }
        else
        {
            await Http.SendJsonAsync(HttpMethod.Post, "/api/User/Create", usr);
            UriHelper.NavigateTo("/fetchuser");
        }

    }
    #endregion

    #region cancel button
    void cancel()
    {
        UriHelper.NavigateTo("/fetchuser");
    }
    #endregion

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
