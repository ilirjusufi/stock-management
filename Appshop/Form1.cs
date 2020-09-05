using Appshop.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Appshop
{
    public partial class Form1 : Form
    {
        Statistices getD ;
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
            getD = StatisticesDb.GetStatistices();
            lblOrders.Text = getD.TotalOrders.ToString();
            lblClients.Text = getD.TotalClients.ToString();
            lblProducts.Text = getD.TotalProducts.ToString();
            lblSales.Text = getD.TotalSales.ToString()+ "€";
            // TODO: This line of code loads data into the 'kundbasDataSet1.OrderList' table. You can move, or remove it, as needed.
            this.orderListTableAdapter1.Fill(this.kundbasDataSet1.OrderList);
            // TODO: This line of code loads data into the 'kundbasDataSet.OrderList' table. You can move, or remove it, as needed.
            this.orderListTableAdapter.Fill(this.kundbasDataSet.OrderList);
            // TODO: This line of code loads data into the 'kundbasDataSet.OrderList' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'kundbasDataSet.Orders' table. You can move, or remove it, as needed.

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
        public void refreshGrid()
        {
            guna2DataGridView1.Refresh();
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

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            if(guna2DataGridView1.Rows.Count > 0)
            {
               
                Microsoft.Office.Interop.Excel._Application ExelApp = new Microsoft.Office.Interop.Excel.Application();
                ExelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < guna2DataGridView1.Columns.Count + 1; i++)
                {
                    ExelApp.Cells[1, i] = guna2DataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < guna2DataGridView1.Columns.Count; j++)
                    {
                        ExelApp.Cells[i + 2, j + 1] = guna2DataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExelApp.Columns.AutoFit();
                ExelApp.Visible = true;
                
            }
        }
    }
}
