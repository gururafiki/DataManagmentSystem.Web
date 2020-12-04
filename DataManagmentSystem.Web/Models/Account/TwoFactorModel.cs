using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagmentSystem.Web.Models.Account
{
    public class TwoFactorModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Code is required.")]
        public string Code { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

        [Display(Name = "Secret code")]
        public string SecretCode { get; set; }
    }
}
