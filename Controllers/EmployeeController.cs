using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBJOffice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult SaveEmployee(Employee employee) {
            try
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return Json(new { success = true, message = "Saved Successfully" });
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

    }
}