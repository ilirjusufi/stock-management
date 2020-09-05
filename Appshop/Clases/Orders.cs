using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop.Clases
{
    public class Orders
    {
        public int OrderID { get; set; }
        public int OrderDetalesID { get; set; }
        public int ClientID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
        //public Image image1 { get; set; }
        //public Image image2 { get; set; }
        //public Image image3 { get; set; }
        //public Image image4 { get; set; }
        //public Image image5 { get; set; }

    }
}
