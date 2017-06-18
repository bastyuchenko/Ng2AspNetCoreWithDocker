using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Ng2AspCore.DBModel;

namespace Ng2AspCore.Controllers
{
    [Route("api/EmployeeMongodb")]
    public class EmpMongoController: Controller
    {
        private readonly IMongoDatabase _mongoDatabase;
        public EmpMongoController()
        {
            var mongoClient = new MongoClient("mongodb://localhost:5533");
            _mongoDatabase = mongoClient.GetDatabase("CompanyDB");
        }

        [HttpGet("GetAll")]
        public IEnumerable<EmployeeMongo> GetAllEmployeesFromMongodb()
        {
            return _mongoDatabase.GetCollection<EmployeeMongo>("employees")
            .Find(x=>x.LastName.StartsWith("C")).ToList();
        }
    }
}