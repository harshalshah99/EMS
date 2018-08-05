using EMS.Data.EmployeeModel;
using EMS.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<City> cities { get; }

        IGenericRepository<Employee> Employees { get; }

    }
}
