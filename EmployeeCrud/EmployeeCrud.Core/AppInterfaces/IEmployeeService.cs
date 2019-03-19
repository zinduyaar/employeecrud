using EmployeeCrud.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCrud.Core.AppInterfaces
{
    public interface IEmployeeService
    {
        IList<Employee> GetAllEmployees();
        Employee GetByEmployeeId(int employeeId);
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);

        void DeleteEmployee(int employeeId);
    }
}
