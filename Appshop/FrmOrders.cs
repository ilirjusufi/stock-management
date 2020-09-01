using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appshop.Clases;
using System.IO;

namespace Appshop
{
    public partial class FrmOrders : Form
    {
        public int get;
        private List<Products> Listp;
        private List<Clients> ListC;
        DataTable Otable = new DataTable();
        string filename;
        Image image1;
        Image image2;
        Image image3;
        Image image4;
        public FrmOrders()
        {
            InitializeComponent();
            LoadDataproduct();
            LoadDataClients();

            

        }
        private void LoadDataproduct()
        {
            Listp = ProductsDb.ProductList(TxtPostage.Text);

            this.productsBindingSource.Clear();

            Listp.ForEach(delegate (Products d)
            {
                this.productsBindingSource.Add(d);

            });
            Otable.Clear();
            


        }
        private void FrmOrders_Load(object sender, EventArgs e)
        {

        }
        private void LoadDataClients()
        {
            ListC = ClientList.Clientlists(txtSearchClients.Text);

            this.clientsBindingSource.Clear();

            ListC.ForEach(delegate (Clients d)
            {
                this.clientsBindingSource.Add(d);

            });
        }
        

        private void BtnSearchProduct_Click(object sender, EventArgs e)
        {
            Listp.Clear();
            Listp = ProductsDb.ProductList(txtSearchClients.Text);
            this.productsBindingSource.Clear();
            Listp.ForEach(delegate (Products d)
            {
                this.productsBindingSource.Add(d);
            });
            
        }

        private void BtnSearcClients_Click(object sender, EventArgs e)
        {
            ListC.Clear();
            ListC = ClientList.Clientlists(txtSearchClients.Text);
            this.clientsBindingSource.Clear();
            ListC.ForEach(delegate (Clients d)
            {
                this.clientsBindingSource.Add(d);

            });
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            get = int.Parse(gunaComboBox2.Text)*int.Parse(TxtCompanyno.Text);
            TxtTotal.Text = get.ToString();
        }

        private void TxtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPostage_TextChanged(object sender, EventArgs e)
        {
            get = get - Convert.ToInt32(TxtPostage.Text);
            TxtSubTotal.Text = get.ToString();
        }

        private void TxtTax_TextChanged_1(object sender, EventArgs e)
        {
            get = get - int.Parse(TxtTax.Text);
            TxtSubTotal.Text = get.ToString();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            

        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            panel2.Size = new Size(747, 140);
            DatagridClients.Size = new Size(747, 140);
            panel2.Location = new Point(14, 232);
            panel2.AutoSize = true;
            DatagridClients.AutoSize = true;

            panel2.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            DatagridClients.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
           
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            if(open.ShowDialog() == DialogResult.OK)
            {
                int i;
                foreach (string item in open.FileNames)
                {

                    image1 = Image.FromFile(item);
                }
                Image image = Image.FromFile(open.FileName);
                Img1box.Image = image1;
                filename = open.FileName;
            }

           

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            DataRow dr = Otable.NewRow();
         
            Otable.Columns.Add("image1", Type.GetType("System.Byte[]"));
            foreach (DataRow row in Otable.Rows)
            {
                row["Data1"] = File.ReadAllBytes(row[filename].ToString());
            }

            Otable.Rows.Add(dr);
            DatagridClients.DataSource = Otable;
            



        }
    }
}
