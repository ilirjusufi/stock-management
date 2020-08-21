using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop
{
    public class Users
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static string sendusername { get; set; } 
        public static string sendPassword { get; set; }
        public Users(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            
        }

        
        public Users()
        {

        }
    }
}
