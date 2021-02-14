using Employee_Salary_Haidar.DataContext;
using Employee_Salary_Haidar.Models;
using Employee_Salary_Haidar.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Salary_Haidar.Controllers
{
    public class PayrollsController : Controller
    {
        private readonly HRPayrollDBContext _context;

        public PayrollsController(HRPayrollDBContext context)
        {
            _context = context;         
        }
        
        // GET: Payrolls
        public IActionResult Index(string EmployeeType, string Period)
        {                                  
                //for create Filter
            var EmployeeTypeList = new List<string>();
            var EmployeeTypeQuery = from d in _context.Employees orderby d.EmployeeType.ToString() select d.EmployeeType.ToString();

            var PeriodList = new List<string>(); 
            var PeriodQuery = from d in _context.Payrolls orderby d.Period.Month.ToString() select CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(d.Period.Month).ToString() + " " + d.Period.Year.ToString();            


            EmployeeTypeList.AddRange(EmployeeTypeQuery.Distinct());
            PeriodList.AddRange(PeriodQuery.Distinct());
            

            ViewBag.EmployeeType = new SelectList(EmployeeTypeList);
            ViewBag.Period = new SelectList(PeriodList);

            //for get list data using join EF
            var result = from a in _context.Payrolls
                         join b in _context.Employees on a.EmployeeID equals b.ID
                         select new
                         {
                             EmployeeName = b.Name,
                             EmployeeType = b.EmployeeType,
                             BirthDate = b.BirthDate,
                             TIN = b.TIN,
                             Absences = a.Absences,
                             WorkDays = a.WorkDays,
                             SalaryTotal = a.SalaryTotal,
                             ID = a.ID,
                             Period = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(a.Period.Month) + " " + a.Period.Year
                         };

            //validate filter data list 
            if (!string.IsNullOrEmpty(EmployeeType))
            {
                result = result.Where(x => x.EmployeeType.ToString() == EmployeeType);
            }

            if (!string.IsNullOrEmpty(Period))
            {
                result = result.Where(x => x.Period.ToString() == Period);
            }

            //add data to viewmodel
            List<PayrollsViewModel> ViewPayrolls = new List<PayrollsViewModel>();
            foreach (var datamodel in result)

            {
                PayrollsViewModel data = new PayrollsViewModel();

                data.Name = datamodel.EmployeeName;
                data.EmployeeType = datamodel.EmployeeType.ToString();
                data.BirthDate = datamodel.BirthDate;
                data.TIN = datamodel.TIN;
                data.Absences = datamodel.Absences;
                data.WorkDays = datamodel.WorkDays;
                data.SalaryTotal = datamodel.SalaryTotal;
                data.ID = datamodel.ID;
                data.Period = datamodel.Period.ToString();

                ViewPayrolls.Add(data);

            }

            return View(ViewPayrolls);
        }

        // GET: Payrolls/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //get data using join
            var result = from a in _context.Payrolls.Where(m => m.ID == id)
                         join b in _context.Employees on a.EmployeeID equals b.ID
                         select new
                         {
                             EmployeeName = b.Name,
                             EmployeeType = b.EmployeeType,
                             BirthDate = b.BirthDate,
                             TIN = b.TIN,
                             Absences = a.Absences,
                             WorkDays = a.WorkDays,
                             SalaryTotal = a.SalaryTotal,
                             Period = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(a.Period.Month) + " " + a.Period.Year
                         };

            //add data to viewmodel
            List<PayrollsViewModel> ViewPayrolls = new List<PayrollsViewModel>();
            foreach (var datamodel in result)
            {
                PayrollsViewModel data = new PayrollsViewModel();

                data.Name = datamodel.EmployeeName;
                data.EmployeeType = datamodel.EmployeeType.ToString();
                data.BirthDate = datamodel.BirthDate;
                data.TIN = datamodel.TIN;
                data.Absences = datamodel.Absences;
                data.WorkDays = datamodel.WorkDays;
                data.SalaryTotal = datamodel.SalaryTotal;
                data.Period = datamodel.Period.ToString();

                ViewPayrolls.Add(data);
            }

            return View(ViewPayrolls);
        }

        // GET: Payrolls/Create Employee Regular
        public IActionResult CreateRegular()
        {
            ViewData["EmployeeID"] = new SelectList(_context.Employees.Where(u => u.EmployeeType.ToString() == "Regular"), "ID", "Name");
            return View();
        }
        // GET: Payrolls/Create Employee Contractual
        public IActionResult CreateContractual()
        {            
            ViewData["EmployeeID"] = new SelectList(_context.Employees.Where(u => u.EmployeeType.ToString() == "Contractual"), "ID", "Name");
            return View();
        }

        // POST: Payrolls/Create Employee Regular   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRegular([Bind("ID,EmployeeID,Period,Absences,WorkDays,SalaryTotal")] Payroll payroll)
        {
            if (ModelState.IsValid)
            {
                //Basic Salary
                decimal BasicMonthSalary = 20.000m;
                decimal Tax = 0.12m;

                //Get Current Month And Year                 
                payroll.Period = DateTime.Now;

                //Get Length Month
                int LengthMonth = 0;

                if (payroll.Period.Date.Month == 1 || payroll.Period.Date.Month == 3 || payroll.Period.Date.Month == 5 || payroll.Period.Date.Month == 7 || payroll.Period.Date.Month == 8 || payroll.Period.Date.Month == 10 || payroll.Period.Date.Month == 12)
                {
                    LengthMonth = 31;
                }
                if (payroll.Period.Date.Month == 4 || payroll.Period.Date.Month == 6 || payroll.Period.Date.Month == 9 || payroll.Period.Date.Month == 11)
                {
                    LengthMonth = 30;
                }
                else if (payroll.Period.Date.Month == 2 && DateTime.IsLeapYear(payroll.Period.Year))
                {
                    LengthMonth = 28;
                }
                else if (payroll.Period.Date.Month == 2 && !DateTime.IsLeapYear(payroll.Period.Year))
                {
                    LengthMonth = 29;
                }

                decimal TotalWorks = Convert.ToDecimal(LengthMonth - payroll.Absences);

                //Formula
                double OneDayAbsence = 20.000 / 22;

                decimal CutSalaryAbsence = Convert.ToDecimal(payroll.Absences * OneDayAbsence);

                payroll.WorkDays = Convert.ToDouble(TotalWorks);

                payroll.SalaryTotal = Convert.ToDecimal(BasicMonthSalary - CutSalaryAbsence - (BasicMonthSalary * Tax));                               

                _context.Add(payroll);

                //Get Employee Name For Validate No Double Data Save
                
                string Employee = Convert.ToString(_context.Payrolls.Where(u => u.Period.Month == payroll.Period.Month && u.EmployeeID == payroll.EmployeeID).Select(u => u.Employee.Name).SingleOrDefault());

                if (Employee != null)
                {
                    ViewBag.Message = String.Format("Sorry, this employee " + "in Period " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month).ToString() + " " + DateTime.Now.Year + " already in database for calculate salary");
                    ViewData["EmployeeID"] = new SelectList(_context.Employees.Where(u => u.EmployeeType.ToString() == "Regular"), "ID", "Name", payroll.EmployeeID);
                    return View(payroll);
                }
                else
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }                
            }
            else
            {
                ViewData["EmployeeID"] = new SelectList(_context.Employees.Where(u => u.EmployeeType.ToString() == "Regular"), "ID", "Name", payroll.EmployeeID);
                return View(payroll);
            }
        }

        // POST: Payrolls/Create Employee Contractual
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateContractual([Bind("ID,EmployeeID,Period,WorkDays,SalaryTotal")] Payroll payroll)
        {
            if (ModelState.IsValid)
            {
                int Dayrate = 500;
                //Get Current Month And Year                 
                payroll.Period = DateTime.Now;

                payroll.SalaryTotal = Convert.ToDecimal(Dayrate * payroll.WorkDays);

                _context.Add(payroll);

                //Get Employee Name For Validate No Double Data Save

                string Employee = Convert.ToString(_context.Payrolls.Where(u => u.Period.Month == payroll.Period.Month && u.EmployeeID == payroll.EmployeeID).Select(u => u.Employee.Name).SingleOrDefault());
                if (Employee != null)
                {
                    ViewBag.Message = String.Format("Sorry, this employee " + "in Period " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month).ToString() + " " + DateTime.Now.Year + " already in database for calculate salary");
                    ViewData["EmployeeID"] = new SelectList(_context.Employees.Where(u => u.EmployeeType.ToString() == "Contractual"), "ID", "Name", payroll.EmployeeID);
                    return View(payroll);
                }
                else
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }              
            }
            else
            {
                ViewData["EmployeeID"] = new SelectList(_context.Employees.Where(u => u.EmployeeType.ToString() == "Contractual"), "ID", "Name", payroll.EmployeeID);
                return View(payroll);
            }
        }

        // GET: Payrolls/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result = from a in _context.Payrolls.Where(m => m.ID == id)
                         join b in _context.Employees on a.EmployeeID equals b.ID
                         select new
                         {
                             EmployeeName = b.Name,
                             EmployeeType = b.EmployeeType,
                             BirthDate = b.BirthDate,
                             TIN = b.TIN,
                             Absences = a.Absences,
                             WorkDays = a.WorkDays,
                             SalaryTotal = a.SalaryTotal,
                             ID = a.ID
                         };
            List<PayrollsViewModel> ViewPayrolls = new List<PayrollsViewModel>();
            foreach (var datamodel in result)

            {
                PayrollsViewModel data = new PayrollsViewModel();

                data.Name = datamodel.EmployeeName;
                data.EmployeeType = datamodel.EmployeeType.ToString();
                data.BirthDate = datamodel.BirthDate;
                data.TIN = datamodel.TIN;
                data.Absences = datamodel.Absences;
                data.WorkDays = datamodel.WorkDays;
                data.SalaryTotal = datamodel.SalaryTotal;
                data.ID = datamodel.ID;

                ViewPayrolls.Add(data);

            }
            if (ViewPayrolls == null)
            {
                return NotFound();
            }

            return View(ViewPayrolls);
        }

        // POST: Payrolls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var payroll = await _context.Payrolls.FindAsync(id);
            _context.Payrolls.Remove(payroll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
