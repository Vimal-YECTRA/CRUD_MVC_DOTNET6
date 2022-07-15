using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC_DOTNET6.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;     
        public string CompanyName { get; set; } = null!;
        public int EmployeeId { get; set; }
        public int Experience { get; set; }

    }
}
