using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IOrder<T, ID>
    {
       List<T> MyOrderInfo(ID u_id);
       T MyOrderDetails(ID o_id);
    }
}
