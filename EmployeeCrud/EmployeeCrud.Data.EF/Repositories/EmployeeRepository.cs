using EmployeeCrud.Core.DataInterfaces;
using EmployeeCrud.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeCrud.Data.EF.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository(EmployeeCrudDBContext context)
        {
            employeeContext = context;
        }
        private EmployeeCrudDBContext employeeContext;
        public IList<Employee> GetAllEmployees()
        {
            var employees = this.employeeContext.Employees.ToList();
            return employees;
        }
        public Employee GetEmployee(int employeeId)
        {
            return this.employeeContext.Employees.SingleOrDefault(e => e.Id == employeeId);
        }
        public void Add(Employee employee)
        {

            this.employeeContext.Employees.Add(employee);
        }
        public void Update(Employee employee)
        {
            var entry =this.employeeContext.Entry(employee);
            entry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void Delete(Employee employee)
        {
            employeeContext.Remove(employee);
        }
    }
}
