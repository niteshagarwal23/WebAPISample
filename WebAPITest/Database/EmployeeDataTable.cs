using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPITest.Models;

namespace WebAPITest.Database
{
    public class EmployeeDataTable : IDataTable<Employee>
    {
        public IEnumerable<Employee> Data { get { return _data; } }

        private static List<Employee> _data;

        private static readonly List<Employee> _defaultData;
        
        static EmployeeDataTable()
        {
            _defaultData = GetEmployeeList();

            _data = new List<Employee>(_defaultData);
        }

        public Employee Add(Employee obj)
        {
            obj.ID = _data.Any() ? _data.Max(c => c.ID) + 1 : 1;
            _data.Add(obj);
            return obj;
        }

        public bool Delete(int eId)
        {
            var first = _data.FirstOrDefault(c => c.ID == eId);
            if (first != null)
            {
                _data.Remove(first);
                return true;
            }

            return false;
        }


        public void ResetCollection()
        {
            _data = new List<Employee>(_defaultData);
        }

        private static List<Employee> GetEmployeeList()
        {
            return new List<Employee>
            {
                new Employee {ID = 1, Name = "Nitesh", Experience = 4, Designation = "Soft. Engineer"},
                new Employee {ID = 2, Name = "Deepak", Experience = 5, Designation = "Sr. Soft. Engineer"},
                new Employee {ID = 3, Name = "Mohit", Experience = 3, Designation = "Soft. Engineer"},
                new Employee {ID = 4, Name = "Prashant", Experience = 3, Designation = "Soft. Engineer"}
            };
        }
    }
}