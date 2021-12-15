using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class EmployeeModel
    {
        public int id { get; set; }
        public int userid { get; set; }
        public double salary { get; set; }
        public int service_id { get; set; }
        public string work_area { get; set; }
        public string work_status { get; set; }
        public virtual CuserModel User { get; set; }
    }
}
