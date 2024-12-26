using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        public string Email { get; set; }
    }
}
