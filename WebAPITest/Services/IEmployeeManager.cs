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
        IEnumerable<Employee> GetAllEmployees(bool getDefault);

        Employee GetEmployeeById(int id);

        Employee VerifyAndSave(Employee emp);

        Employee VerifyAndUpdate(Employee emp);

        bool VerifyAndDelete(int id);
    }
}
