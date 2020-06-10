using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBJOffice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace IBJOffice.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IBJOfficeDbContext _db;

        public EmployeeController(IBJOfficeDbContext db)
        {
            _db = db;
        }


        [HttpGet("employee")]
        public IActionResult Index()
        {
            return View("~/Views/Employee/Index.cshtml");
        }

        [HttpGet("employee/table-data-view")]
        public async Task<IActionResult> GetAllEmployees() {

            try
            {
                var data = await _db.Employees.ToListAsync();
                    ViewData["EmployeesList"] = data;
                    return PartialView("~/Views/Employee/_TableData.cshtml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpGet("employee/add")]
        public IActionResult AddEmployeeForm() {
            try
            {
                ViewData["Title"] = "Add New Employee";
                ViewData["Employee"] = new Employee();
                return PartialView("~/Views/Employee/_AddForm.cshtml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpPost("employee/save")]
        public async Task<IActionResult> SaveEmployee(Employee employee) {
            try
            {
                Employee employeeFromDb = await _db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
                
                if (employeeFromDb == null) {
                        _db.Employees.Add(employee);
                        _db.SaveChanges();
                        return Json(new { success = true, message = "Created Successfully" });
                        } else {
                        employeeFromDb.FirstName = employee.FirstName;
                        employeeFromDb.LastName = employee.LastName;
                        employeeFromDb.Position = employee.Position;
                        employeeFromDb.Department = employee.Department;
                        employeeFromDb.Salary = employee.Salary;
                        employeeFromDb.DateJoined = employee.DateJoined;
                        employeeFromDb.LastUpdated = employee.LastUpdated;
                        employeeFromDb.EmployeeId = employee.EmployeeId;
                        _db.Employees.Update(employeeFromDb);
                        _db.SaveChanges();
                        return Json(new { success = true, message = "Updated Successfully" });
                        }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = "Error while saving" });
            }
        }

        [HttpPost("employee/delete")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                var employeeFromDb = await _db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);

                if (employeeFromDb == null)
                {
                    return Json(new { success = false, message = "Error while deleting." });
                }

                _db.Employees.Remove(employeeFromDb);
                await _db.SaveChangesAsync();
                return Json(new { success = true, message = "Delete Successfull!" });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = "Error while deleting." });
            }
        }    

        [HttpGet("employee/edit")]
        public async Task<IActionResult> EditEmployee(int id) {
            try
            {
                Employee employee = await _db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
                if (employee == null)
                {
                    return NotFound();
                }

                ViewData["Title"] = "Edit Employee: " + employee.FirstName + " " + employee.LastName;
                ViewData["Employee"] = employee;
                return PartialView("~/Views/Employee/_AddForm.cshtml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = "Error while deleting." });
            }
        }

        [HttpGet("employee/search")]
        public async Task<IActionResult> SearchEmployee(string keyword) {

            try
            {
                var employees = await _db.Employees.Where(e => 
                e.LastName.ToLower().Contains(keyword.ToLower()) ||
                e.FirstName.ToLower().Contains(keyword.ToLower()) ||
                e.Position.ToLower().Contains(keyword.ToLower())
                ).ToListAsync();

                ViewData["EmployeesList"] = employees;
                return PartialView("~/Views/Employee/_TableData.cshtml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //public async Task<List<Employee>> GetEmployeesListAsync(EmployeeFilter filter) {
        //    List<Employee> searchResult = new List<Employee>();
        //    try
        //    {
        //        if (filter == null)
        //        {
        //            var target = await _db.Employees.Select(e => new Employee(e)
        //            {
        //                EmployeeId = e.EmployeeId,
        //                FirstName = e.FirstName,
        //                LastName = e.LastName,
        //                Position = e.Position,
        //                Department = e.Department,
        //                Salary = e.Salary,
        //                DateJoined = e.DateJoined,
        //                LastUpdated = e.LastUpdated
        //            }).AsQueryable().ToListAsync();

        //            searchResult = target;
        //        }
        //        else
        //        {
        //            var query = _db.Employees.Select(e => new Employee(e)).AsQueryable();
        //            query = Filter(query, filter);

        //            if (filter.PageSize == 0)
        //            {
        //                searchResult = await query.ToListAsync();
        //            }
        //            else
        //            {
        //                if (filter.PageSize == 0)
        //                {
        //                    searchResult = await query.ToListAsync();
        //                }
        //                else
        //                {
        //                    searchResult = await query.Skip(filter.PageIndex * filter.PageSize).Take(filter.PageSize).ToListAsync();
        //                }
        //            }
        //        }

        //        return searchResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return searchResult;
        //    }
        //}
        //private IQueryable<Employee> Filter(IQueryable<Employee> query, EmployeeFilter filter) {
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(filter.Keyword))
        //        {
        //            query = query.Where(e =>
        //            e.FirstName.ToLower().Contains(filter.Keyword.ToLower()) ||
        //            e.LastName.ToLower().Contains(filter.Keyword.ToLower()) ||
        //            e.Position.ToLower().Contains(filter.Keyword.ToLower()) ||
        //            e.Department.ToString().ToLower().Contains(filter.Keyword.ToLower()) ||
        //            e.Salary.ToString().ToLower().Contains(filter.Keyword.ToLower())
        //            );
        //        } 
        //        else {

        //            if (!string.IsNullOrEmpty(filter.FirstName))
        //            {
        //                if (filter.FirstName[0] == '%')
        //                {
        //                    query = query.Where(e => e.FirstName.ToLower().Contains(filter.FirstName.Substring(1).ToLower()));
        //                }
        //                else
        //                {
        //                    query = query.Where(e => e.FirstName.ToLower() == filter.FirstName.ToLower());
        //                }
        //            }
        //            if (!string.IsNullOrEmpty(filter.LastName))
        //            {
        //                if (filter.LastName[0] == '%')
        //                {
        //                    query = query.Where(e => e.LastName.ToLower().Contains(filter.LastName.Substring(1).ToLower()));
        //                }
        //                else
        //                {
        //                    query = query.Where(e => e.LastName.ToLower() == filter.LastName.ToLower());
        //                }
        //            }
        //            if (!string.IsNullOrEmpty(filter.Position))
        //            {
        //                if (filter.Position[0] == '%')
        //                {
        //                    query = query.Where(e => e.Position.ToLower().Contains(filter.Position.Substring(1).ToLower()));
        //                }
        //                else
        //                {
        //                    query = query.Where(e => e.Position.ToLower() == filter.Position.ToLower());
        //                }
        //            }
        //            if (!string.IsNullOrEmpty(filter.Department))
        //            {
        //                if (filter.Department[0] == '%')
        //                {
        //                    query = query.Where(e => e.Department.ToString().ToLower().Contains(filter.Department.Substring(1).ToLower()));
        //                }
        //                else
        //                {
        //                    query = query.Where(e => e.Department.ToString().ToLower() == filter.Department.ToLower());
        //                }
        //            }
        //            if (!string.IsNullOrEmpty(filter.Salary))
        //            {
        //                if (filter.Salary[0] == '%')
        //                {
        //                    query = query.Where(e => e.Salary.ToString().ToLower().Contains(filter.Salary.Substring(1).ToLower()));
        //                }
        //                else
        //                {
        //                    query = query.Where(e => e.Salary.ToString().ToLower() == filter.Salary.ToLower());
        //                }
        //            }
        //        }

        //        //switch (filter.SortBy)
        //        //{
        //        //    case: "name":
        //        //    default:
        //        //        if (filter.AscSort) { query = query.OrderBy(e => e.EmployeeId); }
        //        //        else { query = query.OrderByDescending(e => e.EmployeeId); }
        //        //        break;
        //        //    case: 
        //        //}

        //        return query;


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return query;
        //    }
        //}

    }
}