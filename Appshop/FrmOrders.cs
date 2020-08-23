using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appshop.Clases;

namespace Appshop
{
    public partial class FrmOrders : Form
    {
        private List<Products> Listp;
        private List<Clients> ListC;
        public FrmOrders()
        {
            InitializeComponent();
            LoadDataproduct();
            LoadDataClients();
        }

        private void LoadDataproduct()
        {
            Listp = ProductsDb.ProductList(TxtSearcProduct.Text);

            this.productsBindingSource.Clear();

            Listp.ForEach(delegate (Products d)
            {
                this.productsBindingSource.Add(d);

            });
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
        private void BtnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
    }
}
