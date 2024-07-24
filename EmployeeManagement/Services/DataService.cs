using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services
{
    public class DataService
    {
        public List<Employee> employeeDB;
        public DataService()
        {
            employeeDB = new List<Employee>(GetDummyEmployees);
        }
        public void Save(Employee employee)
        {
            employeeDB.Add(employee);
        }
        public IEnumerable<Employee> GetAll()
        {
            return employeeDB;
        }
        public Employee Get(Guid id)
        {
            return employeeDB.FirstOrDefault(x=>x.Id==id);
        }
        private IEnumerable<Employee> GetDummyEmployees
        {
            get
            {
                yield return new Employee { Id = Guid.NewGuid(), FirstName = "Rakesh", LastName = "Kumar" };
                yield return new Employee { Id = Guid.NewGuid(), FirstName = "Mukesh", LastName = "Kumar" };
                yield return new Employee { Id = Guid.NewGuid(), FirstName = "Suresh", LastName = "Kumar" };

            }
        }
    }
}
