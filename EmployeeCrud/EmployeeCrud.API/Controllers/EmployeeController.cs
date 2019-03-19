using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCrud.API.Models;
using EmployeeCrud.Core.AppInterfaces;
using EmployeeCrud.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(IEmployeeService employeeService)
        {
            empService = employeeService;
        }

        private IEmployeeService empService;
        // GET api/values

        [HttpGet]
        public IActionResult Get()
        {
            var employees = empService.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}", Name = "GetEmployeeById")]
        public IActionResult Get(int id)
        {
            var employee = empService.GetByEmployeeId(id);
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Employee employee)
        {
            empService.CreateEmployee(employee);
            return CreatedAtRoute("GetEmployeeById", new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Employee), 200)]
        public IActionResult Put(int id, [FromBody]Employee employee)
        {
            employee.Id = id;
            var updatedEmpoyee = empService.UpdateEmployee(employee);
            return Ok(updatedEmpoyee);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponseModel), 200)]
        [ProducesResponseType(typeof(ApiResponseModel), 404)]
        [ProducesResponseType(typeof(ApiResponseModel), 500)]
        public IActionResult Delete(int id)
        {
            empService.DeleteEmployee(id);
            return Ok(new ApiResponseModel() { Message = $"Employee with id {id} has been deleted" });
        }
    }
}
