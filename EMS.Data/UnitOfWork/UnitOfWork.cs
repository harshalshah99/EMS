using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Data.EmployeeModel;
using EMS.Data.Repository;

namespace EMS.Data.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        PracticeDBEntities _db;
        GenericRepository<City> _cityRepository;
        GenericRepository<Employee> _employeeRepository;
        
        UnitOfWork(PracticeDBEntities db)
        {
            _db = db;
        }

        public IGenericRepository<City> cities
        {
            get
            {
                if (_cityRepository == null)
                {
                    _cityRepository = new GenericRepository<City>(_db);
                }
                return _cityRepository;
            }
        }

        public IGenericRepository<Employee> Employees
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new GenericRepository<Employee>(_db);
                }
                return _employeeRepository;
            }
        }
    }
}
