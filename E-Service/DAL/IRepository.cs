using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T,ID,S>
    {
        List<T> GetAll();
        T Get(ID id);
        List<T> BySearch(S c);
        
    }
}
