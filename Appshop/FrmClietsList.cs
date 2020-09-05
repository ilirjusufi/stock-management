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
    public partial class FrmClietsList : Form
    {
        private List<Clients> ListC;
        public FrmClietsList()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ListC = ClientList.Clientlists(TxtSearch.Text);

            this.clientsBindingSource.Clear();

            ListC.ForEach(delegate (Clients d)
            {
                this.clientsBindingSource.Add(d);

            });
        }
        private void FrmClietsList_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ListC.Clear();
            ListC = ClientList.Clientlists(TxtSearch.Text);
            this.clientsBindingSource.Clear();
            ListC.ForEach(delegate (Clients d)
            {
                this.clientsBindingSource.Add(d);

            });
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmClients frClients = new FrmClients();
            if(this.DatagridClients[0, DatagridClients.CurrentCell.RowIndex].Value.ToString() != null)
            {
                string Name = (this.DatagridClients[1, DatagridClients.CurrentCell.RowIndex].Value.ToString());
                string Surname = (this.DatagridClients[2, DatagridClients.CurrentCell.RowIndex].Value.ToString());
                string Address = (this.DatagridClients[3, DatagridClients.CurrentCell.RowIndex].Value.ToString());
                string City = (this.DatagridClients[4, DatagridClients.CurrentCell.RowIndex].Value.ToString());
                string Email = (this.DatagridClients[6, DatagridClients.CurrentCell.RowIndex].Value.ToString());
                string Desc = (this.DatagridClients[9, DatagridClients.CurrentCell.RowIndex].Value.ToString());
                string  Companyno = (this.DatagridClients[8, DatagridClients.CurrentCell.RowIndex].Value.ToString());
                string CpmpanyName = (this.DatagridClients[7, DatagridClients.CurrentCell.RowIndex].Value.ToString());
                int clientid = Convert.ToInt32(this.DatagridClients[0, DatagridClients.CurrentCell.RowIndex].Value);
                string phone = (this.DatagridClients[5, DatagridClients.CurrentCell.RowIndex].Value.ToString());
                frClients.GetEdit(Name, Surname, Address, City, Email, Desc, clientid, Companyno, CpmpanyName, phone);

            }
        }

        private void DatagridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.DatagridClients[0, DatagridClients.CurrentCell.RowIndex].Value.ToString() != null)
            {
                int clientiddel = Convert.ToInt32(this.DatagridClients[0, DatagridClients.CurrentCell.RowIndex].Value);
                ClientList.Delete(clientiddel);
                LoadData();
            }

        }
    }
}
