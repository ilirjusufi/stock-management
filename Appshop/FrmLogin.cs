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
            
            UsersDb usersdb = new UsersDb();
            string Username = Txtusers.Text;
            string Password = TxtPassword.Text;
            usersdb.Login( Username,Password);
           
            if (Users.sendusername != null && Users.sendPassword != null)
            {
                UserSesioni1.CurrentUser = Users.sendusername; 
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Username or password not match");
                Application.Restart();

            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
