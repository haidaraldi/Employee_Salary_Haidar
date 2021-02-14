using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Employee_Salary_Haidar.ViewModel
{
    public class PayrollsViewModel
    {
        public int ID { get; set; }
        [DisplayName("Employee Name")]
        public string Name { get; set; }
        [DisplayName("Employee Type")]
        public string EmployeeType { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        [DisplayName("TIN")]
        public string TIN { get; set; }
        [DisplayName("Absences")]
        public double Absences { get; set; }
        [DisplayName("Work Days")]
        public double WorkDays { get; set; }

        [DisplayName("Salary Total")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal SalaryTotal { get; set; }

        public string Period { get; set; }

    }
}
