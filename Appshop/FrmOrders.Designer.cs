namespace Appshop
{
    partial class FrmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.AddInvoice = new Guna.UI.WinForms.GunaButton();
            this.ProductCombo = new Guna.UI.WinForms.GunaComboBox();
            this.ComboCllients = new Guna.UI.WinForms.GunaComboBox();
            this.TxtPostage = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTotal = new Guna.UI.WinForms.GunaTextBox();
            this.TxtSubTotal = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTax = new Guna.UI.WinForms.GunaTextBox();
            this.TxtCompanyno = new Guna.UI.WinForms.GunaTextBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.txtSearchClients = new Guna.UI.WinForms.GunaTextBox();
            this.BtnSearcClients = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductComboprice = new Guna.UI.WinForms.GunaComboBox();
            this.DatagridClients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Img5box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Img4box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Img3box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Img2box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Img1box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductPriceQ = new Guna.UI.WinForms.GunaTextBox();
            this.Addclient = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img5box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img4box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img3box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1box)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Appshop.Clases.Products);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(Appshop.Clases.Clients);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(11, 374);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(32, 15);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Total";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(162, 374);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(42, 15);
            this.gunaLabel3.TabIndex = 24;
            this.gunaLabel3.Text = "Tax(%)";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(330, 374);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(49, 15);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "Postage";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(494, 374);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(52, 15);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "SubTotal";
            // 
            // AddInvoice
            // 
            this.AddInvoice.AnimationHoverSpeed = 0.07F;
            this.AddInvoice.AnimationSpeed = 0.03F;
            this.AddInvoice.BaseColor = System.Drawing.Color.RoyalBlue;
            this.AddInvoice.BorderColor = System.Drawing.Color.Black;
            this.AddInvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddInvoice.FocusedColor = System.Drawing.Color.Empty;
            this.AddInvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddInvoice.ForeColor = System.Drawing.Color.White;
            this.AddInvoice.Image = null;
            this.AddInvoice.ImageSize = new System.Drawing.Size(20, 20);
            this.AddInvoice.Location = new System.Drawing.Point(662, 392);
            this.AddInvoice.Name = "AddInvoice";
            this.AddInvoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddInvoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddInvoice.OnHoverForeColor = System.Drawing.Color.White;
            this.AddInvoice.OnHoverImage = null;
            this.AddInvoice.OnPressedColor = System.Drawing.Color.Black;
            this.AddInvoice.Size = new System.Drawing.Size(101, 25);
            this.AddInvoice.TabIndex = 23;
            this.AddInvoice.Text = "Save invoice";
            this.AddInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddInvoice.Click += new System.EventHandler(this.AddInvoice_Click);
            // 
            // ProductCombo
            // 
            this.ProductCombo.BackColor = System.Drawing.Color.Transparent;
            this.ProductCombo.BaseColor = System.Drawing.Color.White;
            this.ProductCombo.BorderColor = System.Drawing.Color.Silver;
            this.ProductCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Price", true));
            this.ProductCombo.DataSource = this.productsBindingSource;
            this.ProductCombo.DisplayMember = "ProductName";
            this.ProductCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProductCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCombo.FocusedColor = System.Drawing.Color.Empty;
            this.ProductCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProductCombo.ForeColor = System.Drawing.Color.Black;
            this.ProductCombo.FormattingEnabled = true;
            this.ProductCombo.Location = new System.Drawing.Point(340, 56);
            this.ProductCombo.Name = "ProductCombo";
            this.ProductCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductCombo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ProductCombo.Size = new System.Drawing.Size(121, 26);
            this.ProductCombo.TabIndex = 4;
            this.ProductCombo.ValueMember = "ProductID";
            this.ProductCombo.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox2_SelectedIndexChanged);
            // 
            // ComboCllients
            // 
            this.ComboCllients.BackColor = System.Drawing.Color.Transparent;
            this.ComboCllients.BaseColor = System.Drawing.Color.White;
            this.ComboCllients.BorderColor = System.Drawing.Color.Silver;
            this.ComboCllients.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientsBindingSource, "ClientID", true));
            this.ComboCllients.DataSource = this.clientsBindingSource;
            this.ComboCllients.DisplayMember = "Name";
            this.ComboCllients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboCllients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCllients.FocusedColor = System.Drawing.Color.Empty;
            this.ComboCllients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboCllients.ForeColor = System.Drawing.Color.Black;
            this.ComboCllients.FormattingEnabled = true;
            this.ComboCllients.Location = new System.Drawing.Point(83, 56);
            this.ComboCllients.Name = "ComboCllients";
            this.ComboCllients.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboCllients.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboCllients.Size = new System.Drawing.Size(121, 26);
            this.ComboCllients.TabIndex = 3;
            this.ComboCllients.ValueMember = "ClientID";
            this.ComboCllients.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // TxtPostage
            // 
            this.TxtPostage.BaseColor = System.Drawing.Color.White;
            this.TxtPostage.BorderColor = System.Drawing.Color.Silver;
            this.TxtPostage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPostage.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtPostage.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtPostage.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPostage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPostage.Location = new System.Drawing.Point(331, 392);
            this.TxtPostage.Name = "TxtPostage";
            this.TxtPostage.PasswordChar = '\0';
            this.TxtPostage.SelectedText = "";
            this.TxtPostage.Size = new System.Drawing.Size(159, 26);
            this.TxtPostage.TabIndex = 1;
            this.TxtPostage.TextChanged += new System.EventHandler(this.TxtPostage_TextChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.BaseColor = System.Drawing.Color.White;
            this.TxtTotal.BorderColor = System.Drawing.Color.Silver;
            this.TxtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTotal.Location = new System.Drawing.Point(14, 392);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.PasswordChar = '\0';
            this.TxtTotal.SelectedText = "";
            this.TxtTotal.Size = new System.Drawing.Size(135, 26);
            this.TxtTotal.TabIndex = 1;
            this.TxtTotal.TextChanged += new System.EventHandler(this.TxtTotal_TextChanged);
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.BaseColor = System.Drawing.Color.White;
            this.TxtSubTotal.BorderColor = System.Drawing.Color.Silver;
            this.TxtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSubTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtSubTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtSubTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSubTotal.Location = new System.Drawing.Point(497, 392);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.PasswordChar = '\0';
            this.TxtSubTotal.SelectedText = "";
            this.TxtSubTotal.Size = new System.Drawing.Size(159, 26);
            this.TxtSubTotal.TabIndex = 1;
            // 
            // TxtTax
            // 
            this.TxtTax.BaseColor = System.Drawing.Color.White;
            this.TxtTax.BorderColor = System.Drawing.Color.Silver;
            this.TxtTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTax.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTax.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtTax.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTax.Location = new System.Drawing.Point(165, 392);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.PasswordChar = '\0';
            this.TxtTax.SelectedText = "";
            this.TxtTax.Size = new System.Drawing.Size(159, 26);
            this.TxtTax.TabIndex = 1;
            this.TxtTax.TextChanged += new System.EventHandler(this.TxtTax_TextChanged_1);
            // 
            // TxtCompanyno
            // 
            this.TxtCompanyno.BaseColor = System.Drawing.Color.White;
            this.TxtCompanyno.BorderColor = System.Drawing.Color.Silver;
            this.TxtCompanyno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCompanyno.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtCompanyno.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtCompanyno.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCompanyno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCompanyno.Location = new System.Drawing.Point(213, 56);
            this.TxtCompanyno.Name = "TxtCompanyno";
            this.TxtCompanyno.PasswordChar = '\0';
            this.TxtCompanyno.SelectedText = "";
            this.TxtCompanyno.Size = new System.Drawing.Size(121, 26);
            this.TxtCompanyno.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(756, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 19);
            this.gunaControlBox1.TabIndex = 14;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // txtSearchClients
            // 
            this.txtSearchClients.BaseColor = System.Drawing.Color.White;
            this.txtSearchClients.BorderColor = System.Drawing.Color.Silver;
            this.txtSearchClients.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchClients.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearchClients.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearchClients.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchClients.Location = new System.Drawing.Point(116, 29);
            this.txtSearchClients.Name = "txtSearchClients";
            this.txtSearchClients.PasswordChar = '\0';
            this.txtSearchClients.SelectedText = "";
            this.txtSearchClients.Size = new System.Drawing.Size(574, 26);
            this.txtSearchClients.TabIndex = 16;
            // 
            // BtnSearcClients
            // 
            this.BtnSearcClients.AnimationHoverSpeed = 0.07F;
            this.BtnSearcClients.AnimationSpeed = 0.03F;
            this.BtnSearcClients.BaseColor = System.Drawing.Color.RoyalBlue;
            this.BtnSearcClients.BorderColor = System.Drawing.Color.Black;
            this.BtnSearcClients.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSearcClients.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSearcClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSearcClients.ForeColor = System.Drawing.Color.White;
            this.BtnSearcClients.Image = null;
            this.BtnSearcClients.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSearcClients.Location = new System.Drawing.Point(696, 30);
            this.BtnSearcClients.Name = "BtnSearcClients";
            this.BtnSearcClients.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnSearcClients.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSearcClients.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSearcClients.OnHoverImage = null;
            this.BtnSearcClients.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSearcClients.Size = new System.Drawing.Size(82, 25);
            this.BtnSearcClients.TabIndex = 22;
            this.BtnSearcClients.Text = "Search";
            this.BtnSearcClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSearcClients.Click += new System.EventHandler(this.BtnSearcClients_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ProductComboprice);
            this.panel1.Controls.Add(this.DatagridClients);
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Img5box);
            this.panel1.Controls.Add(this.Img4box);
            this.panel1.Controls.Add(this.Img3box);
            this.panel1.Controls.Add(this.Img2box);
            this.panel1.Controls.Add(this.Img1box);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.AddInvoice);
            this.panel1.Controls.Add(this.TxtPostage);
            this.panel1.Controls.Add(this.TxtTotal);
            this.panel1.Controls.Add(this.TxtSubTotal);
            this.panel1.Controls.Add(this.TxtTax);
            this.panel1.Controls.Add(this.gunaLabel9);
            this.panel1.Controls.Add(this.gunaLabel8);
            this.panel1.Controls.Add(this.gunaLabel7);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComboCllients);
            this.panel1.Controls.Add(this.ProductPriceQ);
            this.panel1.Controls.Add(this.ProductCombo);
            this.panel1.Controls.Add(this.TxtCompanyno);
            this.panel1.Location = new System.Drawing.Point(15, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 425);
            this.panel1.TabIndex = 23;
            // 
            // ProductComboprice
            // 
            this.ProductComboprice.BackColor = System.Drawing.Color.Transparent;
            this.ProductComboprice.BaseColor = System.Drawing.Color.White;
            this.ProductComboprice.BorderColor = System.Drawing.Color.Silver;
            this.ProductComboprice.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Price", true));
            this.ProductComboprice.DataSource = this.productsBindingSource;
            this.ProductComboprice.DisplayMember = "Price";
            this.ProductComboprice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProductComboprice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductComboprice.FocusedColor = System.Drawing.Color.Empty;
            this.ProductComboprice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProductComboprice.ForeColor = System.Drawing.Color.Black;
            this.ProductComboprice.FormattingEnabled = true;
            this.ProductComboprice.Location = new System.Drawing.Point(468, 56);
            this.ProductComboprice.Name = "ProductComboprice";
            this.ProductComboprice.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductComboprice.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ProductComboprice.Size = new System.Drawing.Size(121, 26);
            this.ProductComboprice.TabIndex = 33;
            this.ProductComboprice.ValueMember = "Price";
            // 
            // DatagridClients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DatagridClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridClients.BackgroundColor = System.Drawing.Color.White;
            this.DatagridClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatagridClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridClients.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatagridClients.EnableHeadersVisualStyles = false;
            this.DatagridClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridClients.Location = new System.Drawing.Point(14, 135);
            this.DatagridClients.Name = "DatagridClients";
            this.DatagridClients.RowHeadersVisible = false;
            this.DatagridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridClients.Size = new System.Drawing.Size(747, 236);
            this.DatagridClients.TabIndex = 31;
            this.DatagridClients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DatagridClients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DatagridClients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DatagridClients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DatagridClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DatagridClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DatagridClients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DatagridClients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridClients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.DatagridClients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DatagridClients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DatagridClients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DatagridClients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DatagridClients.ThemeStyle.HeaderStyle.Height = 21;
            this.DatagridClients.ThemeStyle.ReadOnly = false;
            this.DatagridClients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DatagridClients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridClients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DatagridClients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DatagridClients.ThemeStyle.RowsStyle.Height = 22;
            this.DatagridClients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridClients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.RoyalBlue;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(259, 91);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(253, 38);
            this.gunaButton1.TabIndex = 24;
            this.gunaButton1.Text = "Add order";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 236);
            this.panel2.TabIndex = 32;
            // 
            // Img5box
            // 
            this.Img5box.BackColor = System.Drawing.Color.DarkGray;
            this.Img5box.Location = new System.Drawing.Point(569, 136);
            this.Img5box.Name = "Img5box";
            this.Img5box.ShadowDecoration.Parent = this.Img5box;
            this.Img5box.Size = new System.Drawing.Size(118, 90);
            this.Img5box.TabIndex = 32;
            this.Img5box.TabStop = false;
            // 
            // Img4box
            // 
            this.Img4box.BackColor = System.Drawing.Color.DarkGray;
            this.Img4box.Location = new System.Drawing.Point(445, 136);
            this.Img4box.Name = "Img4box";
            this.Img4box.ShadowDecoration.Parent = this.Img4box;
            this.Img4box.Size = new System.Drawing.Size(118, 90);
            this.Img4box.TabIndex = 32;
            this.Img4box.TabStop = false;
            // 
            // Img3box
            // 
            this.Img3box.BackColor = System.Drawing.Color.DarkGray;
            this.Img3box.Location = new System.Drawing.Point(321, 136);
            this.Img3box.Name = "Img3box";
            this.Img3box.ShadowDecoration.Parent = this.Img3box;
            this.Img3box.Size = new System.Drawing.Size(118, 90);
            this.Img3box.TabIndex = 32;
            this.Img3box.TabStop = false;
            // 
            // Img2box
            // 
            this.Img2box.BackColor = System.Drawing.Color.DarkGray;
            this.Img2box.Location = new System.Drawing.Point(197, 136);
            this.Img2box.Name = "Img2box";
            this.Img2box.ShadowDecoration.Parent = this.Img2box;
            this.Img2box.Size = new System.Drawing.Size(118, 90);
            this.Img2box.TabIndex = 32;
            this.Img2box.TabStop = false;
            // 
            // Img1box
            // 
            this.Img1box.BackColor = System.Drawing.Color.DarkGray;
            this.Img1box.Location = new System.Drawing.Point(73, 135);
            this.Img1box.Name = "Img1box";
            this.Img1box.ShadowDecoration.Parent = this.Img1box;
            this.Img1box.Size = new System.Drawing.Size(118, 90);
            this.Img1box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img1box.TabIndex = 32;
            this.Img1box.TabStop = false;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(593, 38);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(98, 15);
            this.gunaLabel9.TabIndex = 28;
            this.gunaLabel9.Text = "Product Quantity";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(465, 38);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(84, 15);
            this.gunaLabel8.TabIndex = 28;
            this.gunaLabel8.Text = "Product Pricee";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(337, 38);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(84, 15);
            this.gunaLabel7.TabIndex = 27;
            this.gunaLabel7.Text = "Product Name";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(211, 38);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel6.TabIndex = 27;
            this.gunaLabel6.Text = "Company No.";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(82, 38);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel5.TabIndex = 26;
            this.gunaLabel5.Text = "Client Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Order";
            // 
            // ProductPriceQ
            // 
            this.ProductPriceQ.BaseColor = System.Drawing.Color.White;
            this.ProductPriceQ.BorderColor = System.Drawing.Color.Silver;
            this.ProductPriceQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPriceQ.FocusedBaseColor = System.Drawing.Color.White;
            this.ProductPriceQ.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductPriceQ.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductPriceQ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductPriceQ.Location = new System.Drawing.Point(595, 56);
            this.ProductPriceQ.Name = "ProductPriceQ";
            this.ProductPriceQ.PasswordChar = '\0';
            this.ProductPriceQ.SelectedText = "";
            this.ProductPriceQ.Size = new System.Drawing.Size(113, 26);
            this.ProductPriceQ.TabIndex = 1;
            // 
            // Addclient
            // 
            this.Addclient.AnimationHoverSpeed = 0.07F;
            this.Addclient.AnimationSpeed = 0.03F;
            this.Addclient.BaseColor = System.Drawing.Color.RoyalBlue;
            this.Addclient.BorderColor = System.Drawing.Color.Black;
            this.Addclient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Addclient.FocusedColor = System.Drawing.Color.Empty;
            this.Addclient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Addclient.ForeColor = System.Drawing.Color.White;
            this.Addclient.Image = null;
            this.Addclient.ImageSize = new System.Drawing.Size(20, 20);
            this.Addclient.Location = new System.Drawing.Point(15, 29);
            this.Addclient.Name = "Addclient";
            this.Addclient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Addclient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Addclient.OnHoverForeColor = System.Drawing.Color.White;
            this.Addclient.OnHoverImage = null;
            this.Addclient.OnPressedColor = System.Drawing.Color.Black;
            this.Addclient.Size = new System.Drawing.Size(95, 25);
            this.Addclient.TabIndex = 22;
            this.Addclient.Text = "Add Client";
            this.Addclient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Addclient.Click += new System.EventHandler(this.BtnSearcClients_Click);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Addclient);
            this.Controls.Add(this.BtnSearcClients);
            this.Controls.Add(this.txtSearchClients);
            this.Controls.Add(this.gunaControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOrders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img5box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img4box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img3box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Guna.UI.WinForms.GunaTextBox TxtCompanyno;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaTextBox txtSearchClients;
        private Guna.UI.WinForms.GunaButton BtnSearcClients;
        private Guna.UI.WinForms.GunaComboBox ComboCllients;
        private Guna.UI.WinForms.GunaComboBox ProductCombo;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton AddInvoice;
        private Guna.UI.WinForms.GunaTextBox TxtPostage;
        private Guna.UI.WinForms.GunaTextBox TxtTotal;
        private Guna.UI.WinForms.GunaTextBox TxtSubTotal;
        private Guna.UI.WinForms.GunaTextBox TxtTax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton Addclient;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox ProductPriceQ;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView DatagridClients;
        private Guna.UI2.WinForms.Guna2PictureBox Img5box;
        private Guna.UI2.WinForms.Guna2PictureBox Img4box;
        private Guna.UI2.WinForms.Guna2PictureBox Img3box;
        private Guna.UI2.WinForms.Guna2PictureBox Img2box;
        private Guna.UI2.WinForms.Guna2PictureBox Img1box;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaComboBox ProductComboprice;
    }
}