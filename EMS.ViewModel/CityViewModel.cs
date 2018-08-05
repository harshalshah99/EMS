using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ViewModel
{
    public class CityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<EmployeeViewModel> Employees { get; set; }
    }
}
