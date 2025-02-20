﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
    }
}
