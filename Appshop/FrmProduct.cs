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
    public partial class FrmProduct : Form
    {
        private List<Products> Listp;
        private Products addp = new Products();
        ProductsDb Pdb = new ProductsDb();
        public FrmProduct()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Listp = ProductsDb.ProductList(TxtSearch.Text);

            this.productsBindingSource.Clear();

            Listp.ForEach(delegate (Products d)
            {
                this.productsBindingSource.Add(d);
                this.productsBindingSource1.Add(d);

            });
        }
        private void addProduct()
        {
            addp.ProductName = ToUper.Touperc(TxtPname.Text);
            addp.Price = int.Parse(TxtPrice.Text);
            addp.Quantity = int.Parse(TxtQuantity.Text);
            addp.Description = ToUper.Touperc(TxtDess.Text);
            Pdb.AddProduct(addp);
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                addProduct();
                LoadData();
            }
            catch (Exception)
            {

                MessageBox.Show("Price and quantity need to fill with numeric values no text");
            }
            
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Listp.Clear();
            Listp = ProductsDb.ProductList(TxtSearch.Text);
            this.productsBindingSource.Clear();
            Listp.ForEach(delegate (Products d)
            {
                this.productsBindingSource.Add(d);
            });
        }
    }
}
