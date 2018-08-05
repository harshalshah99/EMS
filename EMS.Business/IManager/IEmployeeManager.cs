using EMS.Data.EmployeeModel;
using EMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Manager.IManager
{
    public interface IEmployeeManager
    {
        Employee GetDB(int id);

        EmployeeViewModel Get(int id);

        List<EmployeeViewModel> GetAll();

        int Insert(EmployeeViewModel employeeViewModel);

        int Update(EmployeeViewModel employeeViewModel);

        int Delete(EmployeeViewModel employeeViewModel);
    }
}
