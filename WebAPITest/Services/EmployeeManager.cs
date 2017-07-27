using System.Collections.Generic;
using WebAPITest.Models;
using WebAPITest.Repository;

namespace WebAPITest.Services
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAllEmployees(bool getDefault)
        {
            return _employeeRepository.GetAllEmployees(getDefault);
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        public Employee VerifyAndSave(Employee obj)
        {
            //verified here.

            //lets save now.
            return _employeeRepository.SaveEmployee(obj);
        }

        public bool VerifyAndDelete(int id)
        {
            return _employeeRepository.DeleteEmployee(id);
        }
    }
}