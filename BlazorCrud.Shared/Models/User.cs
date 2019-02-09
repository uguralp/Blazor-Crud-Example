using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace BlazorCrud.Shared.Models
{
    public class User
    {
        public int userID { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Vname { get; set; }
        [Required]
        public string Vmodel { get; set; }
        [Required]
        public string Vyear { get; set; }
    }
}