using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop.Clases
{
    public class test1
    {
        public  string emri { get; set; }
        public  string mbiemri { get; set; }

        public test1(string Emri, string Mbiemri)
        {
            this.emri = Emri;
            this.mbiemri = Mbiemri;
        }
    }
}
