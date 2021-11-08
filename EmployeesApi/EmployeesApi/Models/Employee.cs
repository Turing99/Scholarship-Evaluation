using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeesApi.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        public Guid TeamLeaderId { get; set; }
        public string Role { get; set; }
    }
}
