using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ng2AspCore.DBModel
{
    [BsonIgnoreExtraElements]
    public class EmployeeMongo
    {
        [BsonElement("employeeId")]
        public int EmployeeId  { get; set; }
        [BsonElement("firstName")]
        public string FirstName  { get; set; }
        [BsonElement("lastName")]
        public string LastName  { get; set; }
        [BsonElement("birthDay")]
        public DateTime BirthDay { get; set; }
    }
}