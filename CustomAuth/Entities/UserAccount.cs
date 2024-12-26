using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CustomAuth.Entities
{
    [Index(nameof(Email),IsUnique = true)]
    [Index(nameof(Phone),IsUnique = true)]
    [Index(nameof(UserName),IsUnique = true)]
    public class UserAccount
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage="Name is required")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone {  get; set; }

        [Required(ErrorMessage = "Designation is required")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string UserName {  get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password {  get; set; }

    }
}
