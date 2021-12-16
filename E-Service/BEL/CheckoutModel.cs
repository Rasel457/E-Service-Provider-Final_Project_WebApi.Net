using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CheckoutModel
    {
        public CheckoutModel()
        {
            this.Service = new List<ServiceModel>();

        }
        public virtual List<ServiceModel> Service { get; set; }
        public string Address { get; set; }
       // public string Address2 { get; set; }

    }
}
