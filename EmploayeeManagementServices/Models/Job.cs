using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploayeeManagementServices.Models
{
    public class Job
    {
        public string Title { get; set; }
        public int Number_of_Position { get; set; }
        public string Location_address { get; set; }
        public int Expected_salary_range { get; set; }
    }
}
