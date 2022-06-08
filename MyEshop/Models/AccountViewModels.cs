using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyEshop.Models
{
    public class RegisterViewModel
    {
        [MaxLength(300)]
        [EmailAddress]
        [Display(Name = "Name")]
        [Required(ErrorMessage ="{0}")]
        [Remote("VerifyEmail", "Account")]
        public string Email { get; set; }

        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage ="Error Lenght")]
        public string Password { get; set; }

        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Password")]
        [Required(ErrorMessage ="Lenght Error")]
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {
        [MaxLength(300)]
        [EmailAddress]
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Lenght Error")]
        public string Email { get; set; }

        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Lenght Error")]
        public string Password { get; set; }

        [Display(Name = "Remember")]
        public bool RememberMe { get; set; }
    }
}
