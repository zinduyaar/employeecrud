using EmployeeCrud.Core.AppInterfaces;
using EmployeeCrud.Core.DataInterfaces;
using EmployeeCrud.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCrud.Core.AppServices
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService(IEmployeeRepository repo, IUnitOfWork uow)
        {
            empRepo = repo;
            unitOfWork = uow;
        }
        private IEmployeeRepository empRepo;
        private IUnitOfWork unitOfWork;

        public IList<Employee> GetAllEmployees()
        {
            return empRepo.GetAllEmployees();
        }
        public Employee GetByEmployeeId(int employeeId)
        {
            return empRepo.GetEmployee(employeeId);
        }

        public Employee CreateEmployee(Employee employee)
        {
            empRepo.Add(employee);
            unitOfWork.SaveChanges();
            return employee;
        }
        public Employee UpdateEmployee(Employee employee)
        {
            empRepo.Update(employee);
            unitOfWork.SaveChanges();
            return employee;
        }
        public void DeleteEmployee(int employeeId)
        {
            var employeeToDelete = GetByEmployeeId(employeeId);
            if (employeeToDelete == null)
            {
                throw new Exception($"Employee id {employeeId} not found so it could not be deleted");
            }
            empRepo.Delete(employeeToDelete);
            unitOfWork.SaveChanges();
        }
    }
}
