using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CustomAuth.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specifies auto-increment
        public int EmpId { get; set; }

        [Required]
        public string EmpName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public int DeptId { get; set; }

        // Define DeptId as a foreign key for the Department entity
        [ForeignKey("DeptId")]
        public virtual Department Department { get; set; }


    }
}
