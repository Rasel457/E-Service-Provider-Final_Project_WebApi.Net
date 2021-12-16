using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServiceRepo : IRepository<Service, int,string>
    {
        Entities db;
        public ServiceRepo(Entities db)
        {
            this.db = db;
        }

        public List<Service> BySearch(string c)
        {
            var entity = (from s in db.Services
                          where s.type == c && s.status == "open"
                          select s).ToList();
            return entity;
        }

        public Service Get(int id)
        {
            return db.Services.FirstOrDefault(e => e.id == id);
        }

        public List<Service> GetAll()
        {
            return db.Services.ToList();
        }

        public void PlaceOrder(List<Service> services, string add, int id)
        {
            var emp = (from e in db.Employees
                       where e.work_status == "free"
                       && e.work_area == add
                       select e).First();
            var emp_id = emp.id;

            Order o = new Order();
            //o.customer_id = (int)u_id;
            o.customer_id = id;
            o.order_place_date = DateTime.Now;
            o.status = "Ordered";
            o.delevery_address = add;
            db.Orders.Add(o);
            db.SaveChanges();

            foreach (var s in services)
            {
                var od = new Order_Details()
                {
                    service_id = s.id,
                    employee_id = emp_id,
                    unit_price = s.price,
                    quantity = 1,
                    order_id = o.id
                };
                db.Order_Details.Add(od);
                db.SaveChanges();
            }


        }
    }
}
