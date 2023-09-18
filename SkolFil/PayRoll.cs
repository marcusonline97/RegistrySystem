using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrySystem.SkolFil
{
    public class PayRoll
    {
        private List<Employee> employees;

        public PayRoll()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(string name, uint salary)
        {
            employees.Add(new Employee(name, salary)); 
        }

        public void AddEmployee(Employee employee)
        {
            employee.E
        }

        public class SqlPayRoll :
    }
}
