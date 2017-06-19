using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Ng2AspCore.DBModel;
using Ng2AspCore.Services;

namespace Ng2AspCore.Controllers
{
    [Route("api/EmployeeMongodb")]
    public class EmpMongoController: Controller
    {
        private MongoContext context;
        public EmpMongoController(MongoContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAll")]
        public IEnumerable<EmployeeMongo> GetAllEmployeesFromMongodb()
        {
            return context.db.GetCollection<EmployeeMongo>("employees")
            .Find(x=>x.LastName.StartsWith("C")).ToList();
        }
    }
}