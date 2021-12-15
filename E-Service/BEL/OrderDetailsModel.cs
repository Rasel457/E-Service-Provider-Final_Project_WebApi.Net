using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public  class OrderDetailsModel
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int service_id { get; set; }
        public Nullable<int> employee_id { get; set; }
        public double unit_price { get; set; }
        public int quantity { get; set; }

        public virtual EmployeeModel Employee { get; set; }
       // public virtual CorderModel Order { get; set; }
        public virtual ServiceModel Service { get; set; }
    }
}
