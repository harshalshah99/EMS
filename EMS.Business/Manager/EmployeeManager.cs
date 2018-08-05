using EMS.Manager.IManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.ViewModel;
using EMS.Data.UnitOfWork;
using EMS.Data.EmployeeModel;

namespace EMS.Manager.Manager
{
    public class EmployeeManager : IEmployeeManager
    {
        IUnitOfWork _uow;

        public EmployeeManager()
        {
            _uow = new UnitOfWork();
        }

        public Employee GetDB(int id)
        {
           return _uow.Employees.Get(id);
        }


        public EmployeeViewModel Get(int id)
        {
            var data = _uow.Employees.Get(id);

            if(data != null)
            {
                return new EmployeeViewModel()
                {
                    Id = data.Id,
                    Name = data.Name,
                    Birthdate = data.Birthdate,
                    Salary = data.Salary,
                    CityId = data.CityId
                };
            }

            return null;
        }

        public List<EmployeeViewModel> GetAll()
        {
            return _uow.Employees.GetAll().Select(
                x => new EmployeeViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Birthdate = x.Birthdate,
                    Salary = x.Salary,
                    CityId = x.CityId
                }).ToList();

        }

        public int Insert(EmployeeViewModel employeeViewModel)
        {
            if(employeeViewModel != null)
            {
                _uow.Employees.Insert(new Employee()
                {
                    Name = employeeViewModel.Name,
                    Birthdate = employeeViewModel.Birthdate,
                    Salary = employeeViewModel.Salary,
                    CityId = employeeViewModel.CityId
                });
            }
            return _uow.Save();
        }

        public int Update(EmployeeViewModel employeeViewModel)
        { 
            if (employeeViewModel != null)
            {
                var data = GetDB(employeeViewModel.Id);
                data.Name = employeeViewModel.Name;
                data.Birthdate = employeeViewModel.Birthdate;
                data.Salary = employeeViewModel.Salary;
                data.CityId = employeeViewModel.CityId;

                if (data != null)
                {
                    _uow.Employees.Update(data);
                }           
            }
            return _uow.Save();
        }

        public int Delete(EmployeeViewModel employeeViewModel)
        {
            if (employeeViewModel != null)
            {
                var data = GetDB(employeeViewModel.Id);
                if (data != null)
                {
                    _uow.Employees.Delete(data);
                }
            }
            return _uow.Save();
        }
        
    }
}
