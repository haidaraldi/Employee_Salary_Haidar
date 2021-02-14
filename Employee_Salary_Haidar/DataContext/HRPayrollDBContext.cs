using Employee_Salary_Haidar.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Salary_Haidar.DataContext
{
    public class HRPayrollDBContext : DbContext
    {
        public HRPayrollDBContext(DbContextOptions<HRPayrollDBContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
    }
}
