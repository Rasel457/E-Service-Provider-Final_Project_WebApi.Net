using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerOrderRepo : IOrder<Order, int>
    {
        Entities db;
        public CustomerOrderRepo(Entities db)
        {
            this.db = db;
        }

        public Order MyOrderDetails(int o_id)
        {
            return db.Orders.FirstOrDefault(e => e.id == o_id);
           
        }

        public List<Order> MyOrderInfo(int u_id)
        {
            //var customerId = (int)c_id;
            var orders = (from o in db.Orders
                          where o.customer_id == u_id
                          select o).ToList();
            return orders;
        }
    }
}
