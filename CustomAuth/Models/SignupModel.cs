using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models
{
    public class SignupModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
