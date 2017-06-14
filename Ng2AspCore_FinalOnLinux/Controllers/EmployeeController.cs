using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ng2AspCore.DBModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ng2AspCore.Controllers
{
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        HRContext hrContext;
        public EmployeeController(HRContext hrContext)
        {
            this.hrContext = hrContext;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllEmployees()
        {
            var query = from emp in hrContext.Employees
                        join rm in hrContext.RoleAssignments on emp.EmployeeId equals rm.EmployeeId
                        where rm.Position == "Software developer"
                        select emp;
            return Ok(query.ToList());
        }
    }
}