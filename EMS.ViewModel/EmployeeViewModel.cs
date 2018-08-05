using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Birthdate { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<int> CityId { get; set; }

        public CityViewModel City { get; set; }
    }
}
