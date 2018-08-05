using EMS.Data.EmployeeModel;
using EMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Manager.IManager
{
    public interface ICityManager
    {
        City GetDB(int id);

        CityViewModel Get(int id);

        List<CityViewModel> GetAll();

        int Insert(CityViewModel cityViewModel);

        int Update(CityViewModel cityViewModel);

        int Delete(CityViewModel cityViewModel);
    }
}
