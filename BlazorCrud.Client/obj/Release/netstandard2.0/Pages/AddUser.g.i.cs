#pragma checksum "C:\Users\Uguralp\Desktop\Q&A_Assignment4\BlazorCrud\BlazorCrud.Client\Pages\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e962e46710da56eb51e987b8c978c44cda851e"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/adduser")]
    public class AddUser : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
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
