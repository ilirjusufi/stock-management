using Appshop.Clases;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Appshop
{
    public partial class FrmClients : Form
    {
        private Clients Addc = new Clients();
        ClientsDb Dbo = new ClientsDb();
        public FrmClients()
        {
            InitializeComponent();

        }
        public void addClients()
        {
            if (TxtName.Text == "" || TxtEmail.Text == "")
            {
                MessageBox.Show("Please fill all boxes","info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Addc.Name = ToUper.Touperc(TxtName.Text);
                Addc.Surname = ToUper.Touperc(TxtSurname.Text);
                Addc.Addres = ToUper.Touperc(TxtAddres.Text);
                Addc.City = ToUper.Touperc(TxtCity.Text);
                Addc.Email = ToUper.Touperc(TxtEmail.Text);
                Addc.Description = ToUper.Touperc(TxtDess.Text);
                Dbo.AddClients(Addc);
                MessageBox.Show("Data as inserted","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            
            
        }
       
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            addClients();
            //dfdsfdsfdfd
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
