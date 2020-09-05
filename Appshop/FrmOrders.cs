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
        private OrderDetales getid;
        private OrderDetales addOrderDet = new OrderDetales();
        private Orders AddOrders = new Orders();
        OrderDetalesDb semdDb = new OrderDetalesDb();
        OrdersDB semdoDb = new OrdersDB();
        DataTable Otable = new DataTable();
        string filename;
        Image image1;
        Image image2;
        Image image3;
        Image image4;
        int FinalTotal;
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
            Otable.Clear();
            Otable.Columns.Add("ProductID");
            Otable.Columns.Add("ClientID");
            Otable.Columns.Add("Product");
            Otable.Columns.Add("Price");
            Otable.Columns.Add("Quantity");
            Otable.Columns.Add("Total");
            
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
            get = int.Parse(ProductCombo.Text)*int.Parse(TxtCompanyno.Text);
            TxtTotal.Text = get.ToString();
        }

        private void TxtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPostage_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtTax_TextChanged_1(object sender, EventArgs e)
        {
           
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
            DataRow fr = Otable.NewRow();

            fr["ProductID"] = ProductCombo.SelectedValue;
            fr["ClientID"] = ComboCllients.SelectedValue;
            fr["Product"] = ProductCombo.Text;
            fr["Price"] = ProductComboprice.Text;
            fr["Quantity"] = ProductPriceQ.Text;
            int total = Convert.ToInt32(ProductComboprice.Text) * Convert.ToInt32(ProductPriceQ.Text);
            fr["Total"] = total.ToString();
            Otable.Rows.Add(fr);
            DatagridClients.DataSource = Otable;
            FinalTotal = FinalTotal + Convert.ToInt32(fr["Total"]);
            TxtTotal.Text = FinalTotal.ToString();

        }

        private void AddInvoice_Click(object sender, EventArgs e)
        {
            addOrderDet.Total = Convert.ToInt32(TxtTotal.Text);
            addOrderDet.Taxvat = 10;
            addOrderDet.Shipping = 2;
            addOrderDet.Total = Convert.ToInt32(TxtSubTotal.Text);
            addOrderDet.ClientID = Convert.ToInt32(ComboCllients.SelectedValue);
            semdDb.AddOrderDetales(addOrderDet);






            foreach (DataRow fr2 in Otable.Rows)
            {
                getid = OrderDetalesDb.SendID();
                AddOrders.OrderDetalesID = getid.OrderDetalesID;
                AddOrders.ClientID = Convert.ToInt32(fr2["ClientID"]);
                AddOrders.ProductID = Convert.ToInt32(fr2["ProductID"]);
                AddOrders.Quantity = Convert.ToInt32(fr2["Quantity"]);
                AddOrders.Total = Convert.ToInt32(fr2["Total"]);
                semdoDb.AddOrders(AddOrders);


            }
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
            int stotal = Convert.ToInt32(TxtTotal.Text);
            TxtPostage.Text = 2.ToString();
            TxtTax.Text = "10%";
            int subtotal = stotal / 10 ;
            int Finaltotal = subtotal + stotal;
            TxtSubTotal.Text = Finaltotal.ToString();


        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Refresh();
        }
    }
}
