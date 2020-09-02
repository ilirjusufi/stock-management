namespace Appshop
{
    partial class FrmClietsList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatagridClients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TxtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.BtnSearch = new Guna.UI.WinForms.GunaButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BtnDelete = new Guna.UI.WinForms.GunaButton();
            this.BtnEdit = new Guna.UI.WinForms.GunaButton();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DatagridClients);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 303);
            this.panel1.TabIndex = 0;
            // 
            // DatagridClients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DatagridClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridClients.AutoGenerateColumns = false;
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
            this.DatagridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addresDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.CompanyNo,
            this.CompanyName,
            this.Phone});
            this.DatagridClients.DataSource = this.clientsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatagridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatagridClients.EnableHeadersVisualStyles = false;
            this.DatagridClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridClients.Location = new System.Drawing.Point(0, 0);
            this.DatagridClients.Name = "DatagridClients";
            this.DatagridClients.RowHeadersVisible = false;
            this.DatagridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridClients.Size = new System.Drawing.Size(859, 303);
            this.DatagridClients.TabIndex = 8;
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
            // TxtSearch
            // 
            this.TxtSearch.BaseColor = System.Drawing.Color.White;
            this.TxtSearch.BorderColor = System.Drawing.Color.Silver;
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSearch.Location = new System.Drawing.Point(12, 47);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(744, 30);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.AnimationHoverSpeed = 0.07F;
            this.BtnSearch.AnimationSpeed = 0.03F;
            this.BtnSearch.BaseColor = System.Drawing.Color.RoyalBlue;
            this.BtnSearch.BorderColor = System.Drawing.Color.Black;
            this.BtnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Image = null;
            this.BtnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSearch.Location = new System.Drawing.Point(762, 47);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSearch.OnHoverImage = null;
            this.BtnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSearch.Size = new System.Drawing.Size(109, 30);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "search";
            this.BtnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(51, 22);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "search";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(839, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 25);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AnimationHoverSpeed = 0.07F;
            this.BtnDelete.AnimationSpeed = 0.03F;
            this.BtnDelete.BaseColor = System.Drawing.Color.RoyalBlue;
            this.BtnDelete.BorderColor = System.Drawing.Color.Black;
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Image = null;
            this.BtnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDelete.Location = new System.Drawing.Point(792, 390);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDelete.OnHoverImage = null;
            this.BtnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDelete.Size = new System.Drawing.Size(81, 30);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEdit
            // 
            this.BtnEdit.AnimationHoverSpeed = 0.07F;
            this.BtnEdit.AnimationSpeed = 0.03F;
            this.BtnEdit.BaseColor = System.Drawing.Color.RoyalBlue;
            this.BtnEdit.BorderColor = System.Drawing.Color.Black;
            this.BtnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Image = null;
            this.BtnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEdit.Location = new System.Drawing.Point(705, 390);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEdit.OnHoverImage = null;
            this.BtnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEdit.Size = new System.Drawing.Size(81, 30);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(Appshop.Clases.Clients);
            // 
            // ClientID
            // 
            this.ClientID.DataPropertyName = "ClientID";
            this.ClientID.HeaderText = "ClientID";
            this.ClientID.Name = "ClientID";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // addresDataGridViewTextBoxColumn
            // 
            this.addresDataGridViewTextBoxColumn.DataPropertyName = "Addres";
            this.addresDataGridViewTextBoxColumn.HeaderText = "Addres";
            this.addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // CompanyNo
            // 
            this.CompanyNo.DataPropertyName = "CompanyNo";
            this.CompanyNo.HeaderText = "CompanyNo";
            this.CompanyNo.Name = "CompanyNo";
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "CompName";
            this.CompanyName.Name = "CompanyName";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // FrmClietsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 432);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClietsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmClietsList";
            this.Load += new System.EventHandler(this.FrmClietsList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox TxtSearch;
        private Guna.UI.WinForms.GunaButton BtnSearch;
        private Guna.UI2.WinForms.Guna2DataGridView DatagridClients;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI.WinForms.GunaButton BtnDelete;
        private Guna.UI.WinForms.GunaButton BtnEdit;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}