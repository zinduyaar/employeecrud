using EmployeeCrud.API.Controllers;
using EmployeeCrud.Core.AppInterfaces;
using EmployeeCrud.Core.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EmployeeCrud.API.Test
{
    public class EmployeeControllerTests
    {
        public EmployeeControllerTests()
        {
            var employee1 = new Employee() { Id = 1, FirstName = "Test1", LastName = "las", Age = 26, Salary = 2888 };
            var employee2 = new Employee() { Id = 2, FirstName = "Test2", LastName = "seee", Age = 27, Salary = 78237 };
            employeeList = new List<Employee>()
            {
                employee1, employee2
            };
        }
        private readonly List<Employee> employeeList;
        [Fact]
        public void WhenNoParametersPassedtoAPI_WeCallMethodToGetAllEmployees()
        {
            // Arrange
            var mockService = new Mock<IEmployeeService>();
            mockService.Setup(r=>r.GetAllEmployees()
                ).Returns(employeeList);
            var controller = new EmployeeController(mockService.Object);

            // Act
            //var response = controller.Get();

            // Assert
            mockService.Verify(r => r.GetAllEmployees(), Times.Once);

        }


    }
}
