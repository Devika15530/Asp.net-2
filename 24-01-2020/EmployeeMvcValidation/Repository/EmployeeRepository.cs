using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMvcValidation.Models;

namespace EmployeeMvcValidation.Repository
{
    public class EmployeeRepository
    {
        //public static List<Employee> list = new List<Employee>();
        public static List<Employee> list = new List<Employee>()
        {

        new Employee()
        {
          Name="dev",
            Id=1,
        Pswd="1234",
            
            }
        };
        public void Add(Employee item)
        {
            list.Add(item);
        }

        public Employee Validate(int id, string pswd)
        {
            foreach (var item in list)
            {
                if (item.Id == id && item.Pswd == pswd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
