using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Angular_In_ASPNET_Core_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Angular_In_ASPNET_Core_MVC.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private AppDbContext db = null;

        public EmployeesController(AppDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Employee> data = await db.Employees.ToListAsync();
            return Ok(data);
        }
    }
}
