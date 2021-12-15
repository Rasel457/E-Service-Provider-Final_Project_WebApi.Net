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
            //var entity = (from o in db.Orders
            //              where o.id == o_id
            //              select o).First();
            return db.Orders.FirstOrDefault(e => e.id == o_id);
            //double x = 0;
            //double y = 0;
            //int i = 0;
            //foreach (var item in entity.Order_Details)
            //{
            //    var price = item.unit_price;
            //    var qty = item.quantity;
            //    x = x + (price * qty);
            //    i++;
            //}
            //double[] arr = new double[i];
            //ViewBag.totalPrice = x;
            //return entity;
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
