using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.model
{
    //datastorage of employees
    public class EmployeeRepository:IEmployeeRepository
    {
        List<MyEmployee> employeelist;

        public EmployeeRepository()
        {
            employeelist = new List<MyEmployee>() { new MyEmployee(1,"devika","devika@gmail.com",Dept.insurance),
                new MyEmployee(2,"devi","devi@gmail.com",Dept.Accounts),
                new MyEmployee(3,"dev","dev@gmail.com",Dept.  It),
            };
        }

        public MyEmployee GetEmployee(int id)
        {
            MyEmployee me = employeelist.FirstOrDefault(e => e.Id ==id);
            return me;
        }
        public List<MyEmployee> DisplayDetails()
        {
            return employeelist;
        }
        public bool AddEmployee(MyEmployee emp)
        {
            emp.Id = employeelist.Max(e => e.Id) + 1;
            employeelist.Add(emp);
            return true;

        }
    }
}
