using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalryApp
{
    class Employee
    {
        public Employee(string id,string name,string email):this()
        {
            ID = id;
            Name = name;
            Email = email;
        }

        public Employee()
        {

        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Salary ASalary { get;  set; }

    }
}
