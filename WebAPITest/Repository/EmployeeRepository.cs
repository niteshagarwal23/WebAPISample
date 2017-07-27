using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPITest.Database;
using WebAPITest.Models;

namespace WebAPITest.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly IDataTable<Employee> _dt;

        public EmployeeRepository(IDataTable<Employee> employeeDT)
        {
            _dt = employeeDT;
        }

        public IEnumerable<Employee> GetAllEmployees(bool getDefault)
        {
            if (getDefault)
            {
                _dt.ResetCollection();
            }
            return _dt.Data;
        }

        public Employee GetEmployeeById(int id)
        {
            return _dt.Data.FirstOrDefault(x => x.ID == id);
        }

        public Employee SaveEmployee(Employee employee)
        {
            return _dt.Add(employee);
        }

        public bool DeleteEmployee(int empId)
        {
            return _dt.Delete(empId);
        }
    }
}