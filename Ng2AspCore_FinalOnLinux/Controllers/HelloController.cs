using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
 
namespace Ng2AspCore.Controllers
{
    [Route("api/hello")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello Angular4 and ASP.NET Core from Ubuntu");
        }
    }
}
