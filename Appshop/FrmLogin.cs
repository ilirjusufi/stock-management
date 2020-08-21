using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appshop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            
            InitializeComponent();
            
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            var users = new Users();
            UsersDb usersdb = new UsersDb();
            users.Username = Txtusers.Text;
            users.Password = TxtPassword.Text;
            usersdb.Login(users);
            if (users.Username.Trim() != "" && users.Password != "")
            {
                
                if (users.Username != null)
                {
                    
                        UserSesioni1.CurrentUser = users;
                        this.Hide();
                        Form1 frm = new Form1();
                        frm.Show();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

                
           
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
