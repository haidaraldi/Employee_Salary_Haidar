using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Employee_Salary_Haidar.Models
{
    public class Payroll
    {
        public int ID { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public DateTime Period { get; set; }

        [Required]
        [DisplayName("Absences")]
        [RegularExpression("^[0-9]{1,11}(?:.[0-9]{1,3})?$", ErrorMessage = "Input only number")]        
        public double Absences { get; set; }

        [Required]
        [DisplayName("Work Days")]
        [RegularExpression("^[0-9]{1,11}(?:.[0-9]{1,3})?$", ErrorMessage = "Input only number")]        
        public double WorkDays { get; set; }

        [DisplayName("Salary Total")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal SalaryTotal { get; set; }
    }
}
