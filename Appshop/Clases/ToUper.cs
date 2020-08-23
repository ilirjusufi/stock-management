using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop.Clases
{
    public class ToUper
    {
        public static string Touperc(string uper)
        {
            if(uper != "")
            {
                return uper[0].ToString().ToUpper() + uper.Substring(1);
            }
            return uper;
        }
    }
}
