using EmployeeCrud.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCrud.Data.EF
{
    public class EmployeeCrudDBContext : DbContext
    {

        public EmployeeCrudDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
