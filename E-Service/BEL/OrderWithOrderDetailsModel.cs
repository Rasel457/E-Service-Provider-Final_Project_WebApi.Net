using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderWithOrderDetailsModel
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public System.DateTime order_place_date { get; set; }
        public string status { get; set; }
        public string delevery_address { get; set; }
        public List<OrderDetailsModel> Order_Details { get; set; }
    }
}
