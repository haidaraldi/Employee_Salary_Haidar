using Employee_Salary_Haidar.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Employee_Salary_Haidar.Models
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HRPayrollDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<HRPayrollDBContext>>()))
            {
                if (context.Employees.Any())
                {
                    return;   // Database has been seeded
                }

                context.Employees.AddRange(
                    new Employee
                    {
                        ID = 1,
                        Name = "Haidar Aldi Wintoro",
                        BirthDate = Convert.ToDateTime("19/07/1997"),
                        TIN = "12345678910",
                        EmployeeType = Type.Regular
                    },
                    new Employee
                    {
                        ID = 2,
                        Name = "Arsyl Adi Kuncoro",
                        BirthDate = Convert.ToDateTime("18/09/1993"),
                        TIN = "10987654321",
                        EmployeeType = Type.Contractual
                    }
                    );

                if (context.Payrolls.Any())
                {
                    return;
                }

                context.Payrolls.AddRange(
                 new Payroll
                 {
                     ID = 1,
                     EmployeeID = 1,
                     Period = Convert.ToDateTime("31/01/2021"),
                     Absences = 1,
                     WorkDays = 28,
                     SalaryTotal = 16.69091m,
                 }
                 );
                context.SaveChanges();
            }

        }
    }
}
