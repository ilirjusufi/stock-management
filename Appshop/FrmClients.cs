using Appshop.Clases;
using Microsoft.VisualBasic.ApplicationServices;
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
                Addc.Name = TxtName.Text;
                Addc.Surname = TxtSurname.Text;
                Addc.Addres = TxtAddres.Text;
                Addc.City = TxtCity.Text;
                Addc.Email = TxtEmail.Text;
                Addc.Description = TxtDess.Text;
                Dbo.AddClients(Addc);
                MessageBox.Show("Data as inserted","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            addClients();
            //dfdsfdsfdfd
        }
    }
}
