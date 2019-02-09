using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCrud.Shared.Models
{
    public class BoolError
    {
        private bool fullnameError;
        private bool emailError;
        private bool addressError;
        private bool cityError;
        private bool phoneNumberError;
        private bool vnameError;
        private bool vmodelError;
        private bool vyearError;

        public bool FullnameError { get => fullnameError; set => fullnameError = value; }
        public bool EmailError { get => emailError; set => emailError = value; }
        public bool AddressError { get => addressError; set => addressError = value; }
        public bool CityError { get => cityError; set => cityError = value; }
        public bool PhoneNumberError { get => phoneNumberError; set => phoneNumberError = value; }
        public bool VnameError { get => vnameError; set => vnameError = value; }
        public bool VmodelError { get => vmodelError; set => vmodelError = value; }
        public bool VyearError { get => vyearError; set => vyearError = value; }
    }
}
