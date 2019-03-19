using EmployeeCrud.Core.DataInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCrud.Data.EF
{
    public class UnitOfWork<T> : IUnitOfWork where T : DbContext
    {
        public UnitOfWork(T context)
        {
            dataContext = context;
        }
        private T dataContext;
        public void SaveChanges()
        {
            this.dataContext.SaveChanges();
        }
    }
}
