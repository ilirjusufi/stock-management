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
    }
}
