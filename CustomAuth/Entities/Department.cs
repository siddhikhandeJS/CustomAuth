using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomAuth.Entities
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specifies auto-increment
        public int DeptId { get; set; }

        [Required]
        public string DeptName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
