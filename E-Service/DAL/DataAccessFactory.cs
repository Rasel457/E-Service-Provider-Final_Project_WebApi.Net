using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static Entities db;
        static DataAccessFactory()
        {
            db = new Entities();
        }
        public static IRepository<Service, int,string> ServiceDataAccess()
        {
            return new ServiceRepo(db);
        }
        public static IProfile<User, int> CuserDataAccess()
        {
            return new CustomerProfileRepo(db);
        }

        public static IOrder<Order, int> CorderDataAccess()
        {
             return new CustomerOrderRepo(db);
        }
        public static IComment<Comment> CommentDataAccess()
        {
            return new CustomerCommentRepo(db);
        }

    }
}
