using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Graphics g = this.CreateGraphics();
            Bmp = new Bitmap(this.Size.Width, this.Size.Height);
            Graphics mg = Graphics.FromImage(Bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0 ,this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Bmp, 0, 0);
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
           
        }
    }
}
