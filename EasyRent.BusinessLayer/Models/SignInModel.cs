using System.ComponentModel.DataAnnotations;

namespace EasyRent.BusinessLayer.Models
{
    public class SignInModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}