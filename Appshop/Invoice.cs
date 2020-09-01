using Appshop.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;



namespace Appshop
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }
        Bitmap Bmp;
        private void button1_Click(object sender, EventArgs e)
        {
           


            dataGridView1.AutoGenerateColumns = false;

            //Set Columns Count.


            //Add Columns.


            //Add a Image Column to the DataGridView at the third position.
            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn.Name = "Image";

            
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.Columns[0].Width = 100;

            //Bind DataGridView.
            this.BindDataGridView();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Bmp, 0, 0);
        }
        private void BindDataGridView()
        {

            using (SqlConnection conn = new SqlConnection(DbConnection.sqllidhja))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT path FROM files", conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    //Add a new Byte[] Column.
                    dt.Columns.Add("Data1", Type.GetType("System.Byte[]"));

                    //Convert all Images to Byte[] and copy to DataTable.
                    foreach (DataRow row in dt.Rows)
                    {
                        row["Data1"] = File.ReadAllBytes(row["Path"].ToString());
                    }

                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
