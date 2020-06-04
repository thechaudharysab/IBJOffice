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
                //Json(new { data = await _db.Employees.ToListAsync() });
                //Console.WriteLine(data);

                //if (data != null)
                //{
                    ViewData["EmployeesList"] = data;
                    return PartialView("~/Views/Employee/_TableData.cshtml");
                //} else {
                //    return null;
               // }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}