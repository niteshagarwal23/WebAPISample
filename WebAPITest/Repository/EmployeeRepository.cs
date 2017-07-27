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
        IDataTable<Employee> dt;
        public EmployeeRepository(IDataTable<Employee> employeeDT)
        {
            dt = employeeDT;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return dt.Data;
        }

        public Employee GetEmployeeById(int id)
        {
            return dt.Data.FirstOrDefault(x => x.ID == id);
        }


        public Employee SaveEmployee(Employee employee)
        {
            return dt.Add(employee);
        }

        public bool DeleteEmployee(int empId)
        {
            return dt.Delete(empId);
        }
    }
}