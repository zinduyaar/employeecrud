using EmployeeCrud.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCrud.Core.DataInterfaces
{
    public interface IEmployeeRepository
    {
        IList<Employee> GetAllEmployees();
        Employee GetEmployee(int employeeId);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}
