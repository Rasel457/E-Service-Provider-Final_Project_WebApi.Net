using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CustomerProfileRepo: IProfile<User, int>
    {
        Entities db;
        public CustomerProfileRepo(Entities db)
        {
            this.db = db;
        }

        public void Edit(User e)
        {
            var u = db.Users.FirstOrDefault(en => en.id == e.id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public User MyProfileInfo(int u_id)
        {
            return db.Users.FirstOrDefault(e => e.id == u_id);
        }

        /*public Order MyOrderInfo(int id)
        {
            //var customerId = (int)c_id;
            var orders = (from o in db.Orders
                         where o.customer_id == id
                         select o).ToList();
            return orders;
        }*/

    }
}
