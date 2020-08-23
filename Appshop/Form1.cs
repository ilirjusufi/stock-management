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

       
        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            var FrmProduct = new FrmProduct();
            if (FrmProduct.ShowDialog() == DialogResult.Abort)
            {

            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            var FrmOrders = new FrmOrders();
            if (FrmOrders.ShowDialog() == DialogResult.Abort)
            {

            }
        }
    }
}
