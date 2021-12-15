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
       
    }
}
