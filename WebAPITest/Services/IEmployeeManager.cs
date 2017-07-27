using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITest.Models;

namespace WebAPITest.Services
{
    public interface IEmployeeManager
    {
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);

        Employee VerifyAndSave(Employee e);

        bool VerifyAndDelete(int id);
    }
}
