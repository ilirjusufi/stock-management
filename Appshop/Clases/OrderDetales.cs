using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop.Clases
{
    class OrderDetales
    {
        public int OrderDetalesID { get; set; }
        public int ClientID { get; set; }
        public int Taxvat { get; set; }
        public int Shipping { get; set; }
        public DateTime Date { get; set; }
        public int Total { get; set; }
    }
}
