﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagmentSystem.Web.Models.Account
{
    public class ForgotPasswordModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
