using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMvcValidation.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Designation { get; set; }
        public string ProjectName { get; set; }
        public string Pswd { get; set; }
    }
}
