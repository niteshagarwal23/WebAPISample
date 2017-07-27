using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITest.Models;

namespace WebAPITest.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);

        Employee SaveEmployee(Employee e);

        bool DeleteEmployee(int empId);
    }
}
