using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CustomerProfileRepo: IProfile<User, int>,IAuth
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

        /* public void Delete(int id)
         {
             var entity = (from o in db.Orders
                           where o.customer_id == id
                           select o).ToList();
             foreach(var o in entity)
             {
                 var details= (from od in db.Order_Details
                               where od.order_id == o.id
                               select od).ToList();
                 foreach(var d in details)
                 {
                     db.Order_Details.Remove(d);
                     db.SaveChanges();
                 }
                 db.Orders.Remove(o);
                 db.SaveChanges();

             }

             var comments = (from c in db.Comments
                            where c.user_id == id
                            select c).ToList();
             foreach (var cm in comments)
             {
                 db.Comments.Remove(cm);
                 db.SaveChanges();
             }

             var em=db.Employees.FirstOrDefault(e => e.userid == id);
             db.Employees.Remove(em);
             db.SaveChanges();

            var m = db.Managers.FirstOrDefault(e => e.userid == id);
            db.Managers.Remove(m);
            db.SaveChanges();

            var cus = db.Customers.FirstOrDefault(e => e.userid == id);
            db.Customers.Remove(cus);
            db.SaveChanges();

            var u=db.Users.FirstOrDefault(e => e.id == id);
            db.Users.Remove(u);
            db.SaveChanges();
         }*/
        public Token Authenticate(User user)
        {
            var u = db.Users.FirstOrDefault(en => en.email.Equals(user.email) && en.password.Equals(user.password));
            Token t = null;
            if (u != null)
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.UserId = u.id;
                t.AccessToken = token;
                t.CreatedAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();

            }
            return t;
        }
        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(en => en.AccessToken.Equals(token) && en.ExpiredAt == null);
            return rs;
        }

        public bool Logout(string Token)
        {
            throw new NotImplementedException();
        }

    }
}
