using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Data.EmployeeModel;
using EMS.Data.Repository;

namespace EMS.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        PracticeDBEntities _db;
        GenericRepository<City> _cityRepository;
        GenericRepository<Employee> _employeeRepository;

        public UnitOfWork()
        {
            _db = new PracticeDBEntities();
        }
        

        public IGenericRepository<City> Cities
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

        public int Save()
        {
            return _db.SaveChanges();
        }
    }
}
