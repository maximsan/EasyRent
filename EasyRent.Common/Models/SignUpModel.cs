using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EasyRent.Common.Models
{
    public class SignUpModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string ReturnUrl { get; set; }
    }
}