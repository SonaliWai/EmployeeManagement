using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploayeeManagementServices.Models
{
    public class Employee
    {
       public int Emp_no { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Email { get; set; }
    }
}
