using Appshop.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            FrmClients frmClients = new FrmClients();
            if (frmClients.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kundbasDataSet.Clients' table. You can move, or remove it, as needed.
            TxtLoginuser.Text = UserSesioni1.CurrentUser;

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            
            var ClientsList = new FrmClietsList();
            if (ClientsList.ShowDialog() == DialogResult.Abort)
            {
                
            }
        }
    }
}
