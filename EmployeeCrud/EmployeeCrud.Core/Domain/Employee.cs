using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCrud.Core.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
