using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace IBJOffice.Models
{
    public enum Department {
        Software, Finance, Admin, Marketing, Research, HR
    }

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public Department Department { get; set; }

        public double Salary { get; set; }

        public DateTime DateJoined { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
