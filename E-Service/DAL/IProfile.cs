using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProfile<X,ID>
    {
        X MyProfileInfo(ID u_id);
        void Edit(X e);
    }
}
