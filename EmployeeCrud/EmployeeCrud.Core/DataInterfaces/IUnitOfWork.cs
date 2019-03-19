using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCrud.Core.DataInterfaces
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
