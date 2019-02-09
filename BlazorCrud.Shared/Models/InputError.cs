using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCrud.Shared.Models
{
    public class InputError
    {
        private string fullnameError;
        private string emailError;
        private string addressError;
        private string cityError;
        private string phoneNumberError;
        private string vnameError;
        private string vmodelError;
        private string vyearError;

        public string FullnameError { get => fullnameError; set => fullnameError = value; }
        public string EmailError { get => emailError; set => emailError = value; }
        public string AddressError { get => addressError; set => addressError = value; }
        public string CityError { get => cityError; set => cityError = value; }
        public string PhoneNumberError { get => phoneNumberError; set => phoneNumberError = value; }
        public string VnameError { get => vnameError; set => vnameError = value; }
        public string VmodelError { get => vmodelError; set => vmodelError = value; }
        public string VyearError { get => vyearError; set => vyearError = value; }
    }
}
