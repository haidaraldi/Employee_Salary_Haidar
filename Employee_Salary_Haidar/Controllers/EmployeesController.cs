using Employee_Salary_Haidar.DataContext;
using Employee_Salary_Haidar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Salary_Haidar.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly HRPayrollDBContext _context;

        public EmployeesController(HRPayrollDBContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index(string EmployeeType)
        {
            var EmployeeTypeList = new List<string>();
            var EmployeeTypeQuery = from d in _context.Employees orderby d.EmployeeType.ToString() select d.EmployeeType.ToString();

            EmployeeTypeList.AddRange(EmployeeTypeQuery.Distinct());
            ViewBag.EmployeeType = new SelectList(EmployeeTypeList);

            var employees = from e in _context.Employees select e;

            //validate filter data list 
            if (!string.IsNullOrEmpty(EmployeeType))
            {
                employees = employees.Where(x => x.EmployeeType.ToString() == EmployeeType);
            }


            return View(await employees.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.ID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,BirthDate,TIN,EmployeeType")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                //Get Employee Name For Validate No Double Data Save
                string Employee = Convert.ToString(_context.Employees.Where(u => u.EmployeeType == employee.EmployeeType && u.Name == employee.Name).Select(u => u.Name).SingleOrDefault());

                if (Employee != null)
                {
                    ViewBag.Message = String.Format("Sorry, this employee already in database");
                    return View();
                }

                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,BirthDate,TIN,EmployeeType")] Employee employee)
        {
            if (id != employee.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.ID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.ID == id);
        }
    }
}
