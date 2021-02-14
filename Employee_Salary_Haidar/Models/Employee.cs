using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Employee_Salary_Haidar.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]        
        public DateTime BirthDate { get; set; }

        [Required]
        [DisplayName("TIN")]
        public string TIN { get; set; }

        [DisplayName("Employee Type")]
        [Required]
        public Type EmployeeType { get; set; }

        public virtual Payroll Payroll { get; set; }

    }
    public enum Type
    {
        Regular,
        Contractual
    }
}
