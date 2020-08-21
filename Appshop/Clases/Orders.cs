using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop.Clases
{
    class Orders
    {
        public int OrderID { get; set; }
        public Clients ClientID { get; set; }
        public Products ProductID { get; set; }
    }
}
