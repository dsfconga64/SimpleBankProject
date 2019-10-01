namespace CenfoBankUI2
{
    partial class AddressesForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dataGridAddresses = new System.Windows.Forms.DataGridView();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.btnAddAdress = new MetroFramework.Controls.MetroButton();
            this.btnUpdateAdress = new MetroFramework.Controls.MetroButton();
            this.btnDeleteAddress = new MetroFramework.Controls.MetroButton();
            this.txtAddressId = new MetroFramework.Controls.MetroTextBox();
            this.txtProvince = new MetroFramework.Controls.MetroTextBox();
            this.txtTown = new MetroFramework.Controls.MetroTextBox();
            this.txtDisctrict = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerId = new MetroFramework.Controls.MetroTextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVINCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOWN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCTRICT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_CUSTOMER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Addresses Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 321);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Customer Id";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 261);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Disctrict";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(34, 207);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Town";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(36, 158);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Province";
            // 
            // dataGridAddresses
            // 
            this.dataGridAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ADDRESS_ID,
            this.PROVINCE,
            this.TOWN,
            this.DISCTRICT,
            this.FK_CUSTOMER_ID});
            this.dataGridAddresses.Location = new System.Drawing.Point(341, 85);
            this.dataGridAddresses.Name = "dataGridAddresses";
            this.dataGridAddresses.RowHeadersWidth = 62;
            this.dataGridAddresses.RowTemplate.Height = 28;
            this.dataGridAddresses.Size = new System.Drawing.Size(795, 150);
            this.dataGridAddresses.TabIndex = 5;
            this.dataGridAddresses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAddresses_CellContentClick);
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME});
            this.dataGridCustomers.Location = new System.Drawing.Point(418, 288);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.RowHeadersWidth = 62;
            this.dataGridCustomers.RowTemplate.Height = 28;
            this.dataGridCustomers.Size = new System.Drawing.Size(399, 150);
            this.dataGridCustomers.TabIndex = 6;
            this.dataGridCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCustomers_CellContentClick);
            // 
            // btnAddAdress
            // 
            this.btnAddAdress.Location = new System.Drawing.Point(36, 397);
            this.btnAddAdress.Name = "btnAddAdress";
            this.btnAddAdress.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdress.TabIndex = 7;
            this.btnAddAdress.Text = "Add";
            this.btnAddAdress.UseSelectable = true;
            this.btnAddAdress.Click += new System.EventHandler(this.BtnAddAdress_Click);
            // 
            // btnUpdateAdress
            // 
            this.btnUpdateAdress.ForeColor = System.Drawing.Color.Coral;
            this.btnUpdateAdress.Location = new System.Drawing.Point(161, 397);
            this.btnUpdateAdress.Name = "btnUpdateAdress";
            this.btnUpdateAdress.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAdress.TabIndex = 8;
            this.btnUpdateAdress.Text = "Update";
            this.btnUpdateAdress.UseSelectable = true;
            this.btnUpdateAdress.Click += new System.EventHandler(this.BtnUpdateAdress_Click);
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.Location = new System.Drawing.Point(34, 464);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAddress.TabIndex = 9;
            this.btnDeleteAddress.Text = "Delete";
            this.btnDeleteAddress.UseSelectable = true;
            this.btnDeleteAddress.Click += new System.EventHandler(this.BtnDeleteAddress_Click);
            // 
            // txtAddressId
            // 
            // 
            // 
            // 
            this.txtAddressId.CustomButton.Image = null;
            this.txtAddressId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtAddressId.CustomButton.Name = "";
            this.txtAddressId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddressId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressId.CustomButton.TabIndex = 1;
            this.txtAddressId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressId.CustomButton.UseSelectable = true;
            this.txtAddressId.CustomButton.Visible = false;
            this.txtAddressId.Enabled = false;
            this.txtAddressId.Lines = new string[] {
        "Id"};
            this.txtAddressId.Location = new System.Drawing.Point(161, 109);
            this.txtAddressId.MaxLength = 32767;
            this.txtAddressId.Name = "txtAddressId";
            this.txtAddressId.PasswordChar = '\0';
            this.txtAddressId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressId.SelectedText = "";
            this.txtAddressId.SelectionLength = 0;
            this.txtAddressId.SelectionStart = 0;
            this.txtAddressId.ShortcutsEnabled = true;
            this.txtAddressId.Size = new System.Drawing.Size(75, 23);
            this.txtAddressId.TabIndex = 10;
            this.txtAddressId.Text = "Id";
            this.txtAddressId.UseSelectable = true;
            this.txtAddressId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProvince
            // 
            // 
            // 
            // 
            this.txtProvince.CustomButton.Image = null;
            this.txtProvince.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtProvince.CustomButton.Name = "";
            this.txtProvince.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProvince.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProvince.CustomButton.TabIndex = 1;
            this.txtProvince.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProvince.CustomButton.UseSelectable = true;
            this.txtProvince.CustomButton.Visible = false;
            this.txtProvince.Lines = new string[] {
        "Province"};
            this.txtProvince.Location = new System.Drawing.Point(161, 158);
            this.txtProvince.MaxLength = 32767;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.PasswordChar = '\0';
            this.txtProvince.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProvince.SelectedText = "";
            this.txtProvince.SelectionLength = 0;
            this.txtProvince.SelectionStart = 0;
            this.txtProvince.ShortcutsEnabled = true;
            this.txtProvince.Size = new System.Drawing.Size(75, 23);
            this.txtProvince.TabIndex = 11;
            this.txtProvince.Text = "Province";
            this.txtProvince.UseSelectable = true;
            this.txtProvince.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProvince.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTown
            // 
            // 
            // 
            // 
            this.txtTown.CustomButton.Image = null;
            this.txtTown.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtTown.CustomButton.Name = "";
            this.txtTown.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTown.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTown.CustomButton.TabIndex = 1;
            this.txtTown.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTown.CustomButton.UseSelectable = true;
            this.txtTown.CustomButton.Visible = false;
            this.txtTown.Lines = new string[] {
        "Town"};
            this.txtTown.Location = new System.Drawing.Point(161, 212);
            this.txtTown.MaxLength = 32767;
            this.txtTown.Name = "txtTown";
            this.txtTown.PasswordChar = '\0';
            this.txtTown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTown.SelectedText = "";
            this.txtTown.SelectionLength = 0;
            this.txtTown.SelectionStart = 0;
            this.txtTown.ShortcutsEnabled = true;
            this.txtTown.Size = new System.Drawing.Size(75, 23);
            this.txtTown.TabIndex = 12;
            this.txtTown.Text = "Town";
            this.txtTown.UseSelectable = true;
            this.txtTown.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTown.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDisctrict
            // 
            // 
            // 
            // 
            this.txtDisctrict.CustomButton.Image = null;
            this.txtDisctrict.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtDisctrict.CustomButton.Name = "";
            this.txtDisctrict.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDisctrict.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDisctrict.CustomButton.TabIndex = 1;
            this.txtDisctrict.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDisctrict.CustomButton.UseSelectable = true;
            this.txtDisctrict.CustomButton.Visible = false;
            this.txtDisctrict.Lines = new string[] {
        "Disctrict"};
            this.txtDisctrict.Location = new System.Drawing.Point(161, 261);
            this.txtDisctrict.MaxLength = 32767;
            this.txtDisctrict.Name = "txtDisctrict";
            this.txtDisctrict.PasswordChar = '\0';
            this.txtDisctrict.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDisctrict.SelectedText = "";
            this.txtDisctrict.SelectionLength = 0;
            this.txtDisctrict.SelectionStart = 0;
            this.txtDisctrict.ShortcutsEnabled = true;
            this.txtDisctrict.Size = new System.Drawing.Size(75, 23);
            this.txtDisctrict.TabIndex = 13;
            this.txtDisctrict.Text = "Disctrict";
            this.txtDisctrict.UseSelectable = true;
            this.txtDisctrict.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDisctrict.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerId
            // 
            // 
            // 
            // 
            this.txtCustomerId.CustomButton.Image = null;
            this.txtCustomerId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCustomerId.CustomButton.Name = "";
            this.txtCustomerId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerId.CustomButton.TabIndex = 1;
            this.txtCustomerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerId.CustomButton.UseSelectable = true;
            this.txtCustomerId.CustomButton.Visible = false;
            this.txtCustomerId.Lines = new string[] {
        "Customer id"};
            this.txtCustomerId.Location = new System.Drawing.Point(197, 321);
            this.txtCustomerId.MaxLength = 32767;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.PasswordChar = '\0';
            this.txtCustomerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerId.SelectedText = "";
            this.txtCustomerId.SelectionLength = 0;
            this.txtCustomerId.SelectionStart = 0;
            this.txtCustomerId.ShortcutsEnabled = true;
            this.txtCustomerId.Size = new System.Drawing.Size(116, 23);
            this.txtCustomerId.TabIndex = 14;
            this.txtCustomerId.Text = "Customer id";
            this.txtCustomerId.UseSelectable = true;
            this.txtCustomerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "Name";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            this.NAME.Width = 150;
            // 
            // ADDRESS_ID
            // 
            this.ADDRESS_ID.HeaderText = "Address Id";
            this.ADDRESS_ID.MinimumWidth = 8;
            this.ADDRESS_ID.Name = "ADDRESS_ID";
            this.ADDRESS_ID.Width = 150;
            // 
            // PROVINCE
            // 
            this.PROVINCE.HeaderText = "Province";
            this.PROVINCE.MinimumWidth = 8;
            this.PROVINCE.Name = "PROVINCE";
            this.PROVINCE.Width = 150;
            // 
            // TOWN
            // 
            this.TOWN.HeaderText = "Town";
            this.TOWN.MinimumWidth = 8;
            this.TOWN.Name = "TOWN";
            this.TOWN.Width = 150;
            // 
            // DISCTRICT
            // 
            this.DISCTRICT.HeaderText = "Disctrict";
            this.DISCTRICT.MinimumWidth = 8;
            this.DISCTRICT.Name = "DISCTRICT";
            this.DISCTRICT.Width = 150;
            // 
            // FK_CUSTOMER_ID
            // 
            this.FK_CUSTOMER_ID.HeaderText = "Customer Id";
            this.FK_CUSTOMER_ID.MinimumWidth = 8;
            this.FK_CUSTOMER_ID.Name = "FK_CUSTOMER_ID";
            this.FK_CUSTOMER_ID.Width = 150;
            // 
            // AddressesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 734);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtDisctrict);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtAddressId);
            this.Controls.Add(this.btnDeleteAddress);
            this.Controls.Add(this.btnUpdateAdress);
            this.Controls.Add(this.btnAddAdress);
            this.Controls.Add(this.dataGridCustomers);
            this.Controls.Add(this.dataGridAddresses);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddressesForm";
            this.Text = "AddressesForm";
            this.Load += new System.EventHandler(this.AddressesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridView dataGridAddresses;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private MetroFramework.Controls.MetroButton btnAddAdress;
        private MetroFramework.Controls.MetroButton btnUpdateAdress;
        private MetroFramework.Controls.MetroButton btnDeleteAddress;
        private MetroFramework.Controls.MetroTextBox txtAddressId;
        private MetroFramework.Controls.MetroTextBox txtProvince;
        private MetroFramework.Controls.MetroTextBox txtTown;
        private MetroFramework.Controls.MetroTextBox txtDisctrict;
        private MetroFramework.Controls.MetroTextBox txtCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVINCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOWN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCTRICT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_CUSTOMER_ID;
    }
}