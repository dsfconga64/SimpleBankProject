namespace CenfoBankUI2
{
    partial class AccountsForm
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
            this.accountComboBox = new MetroFramework.Controls.MetroComboBox();
            this.txtAccountId = new MetroFramework.Controls.MetroTextBox();
            this.txtAccountName = new MetroFramework.Controls.MetroTextBox();
            this.txtBalance = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerId = new MetroFramework.Controls.MetroTextBox();
            this.dataGridAccounts = new System.Windows.Forms.DataGridView();
            this.ACCOUNT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURRENCY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BALANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_CUSTOMER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCustomers1 = new System.Windows.Forms.DataGridView();
            this.CUSTOMER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAccounts = new MetroFramework.Controls.MetroButton();
            this.btnDeleteAccounts = new MetroFramework.Controls.MetroButton();
            this.btnUpdateAccounts = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Account Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.Location = new System.Drawing.Point(22, 285);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Customer Id";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 234);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Balance";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 183);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Currency";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 139);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Name";
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.ItemHeight = 23;
            this.accountComboBox.Items.AddRange(new object[] {
            "Dolares",
            "Colones",
            "Euros",
            "Libras"});
            this.accountComboBox.Location = new System.Drawing.Point(126, 183);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(121, 29);
            this.accountComboBox.TabIndex = 5;
            this.accountComboBox.UseSelectable = true;
            // 
            // txtAccountId
            // 
            // 
            // 
            // 
            this.txtAccountId.CustomButton.Image = null;
            this.txtAccountId.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtAccountId.CustomButton.Name = "";
            this.txtAccountId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccountId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccountId.CustomButton.TabIndex = 1;
            this.txtAccountId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccountId.CustomButton.UseSelectable = true;
            this.txtAccountId.CustomButton.Visible = false;
            this.txtAccountId.Enabled = false;
            this.txtAccountId.Lines = new string[] {
        "Id"};
            this.txtAccountId.Location = new System.Drawing.Point(126, 89);
            this.txtAccountId.MaxLength = 32767;
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.PasswordChar = '\0';
            this.txtAccountId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccountId.SelectedText = "";
            this.txtAccountId.SelectionLength = 0;
            this.txtAccountId.SelectionStart = 0;
            this.txtAccountId.ShortcutsEnabled = true;
            this.txtAccountId.Size = new System.Drawing.Size(121, 23);
            this.txtAccountId.TabIndex = 6;
            this.txtAccountId.Text = "Id";
            this.txtAccountId.UseSelectable = true;
            this.txtAccountId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccountId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccountName
            // 
            // 
            // 
            // 
            this.txtAccountName.CustomButton.Image = null;
            this.txtAccountName.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtAccountName.CustomButton.Name = "";
            this.txtAccountName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccountName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccountName.CustomButton.TabIndex = 1;
            this.txtAccountName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccountName.CustomButton.UseSelectable = true;
            this.txtAccountName.CustomButton.Visible = false;
            this.txtAccountName.Lines = new string[] {
        "Name"};
            this.txtAccountName.Location = new System.Drawing.Point(126, 139);
            this.txtAccountName.MaxLength = 32767;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.PasswordChar = '\0';
            this.txtAccountName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccountName.SelectedText = "";
            this.txtAccountName.SelectionLength = 0;
            this.txtAccountName.SelectionStart = 0;
            this.txtAccountName.ShortcutsEnabled = true;
            this.txtAccountName.Size = new System.Drawing.Size(121, 23);
            this.txtAccountName.TabIndex = 7;
            this.txtAccountName.Text = "Name";
            this.txtAccountName.UseSelectable = true;
            this.txtAccountName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccountName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBalance
            // 
            // 
            // 
            // 
            this.txtBalance.CustomButton.Image = null;
            this.txtBalance.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtBalance.CustomButton.Name = "";
            this.txtBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBalance.CustomButton.TabIndex = 1;
            this.txtBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBalance.CustomButton.UseSelectable = true;
            this.txtBalance.CustomButton.Visible = false;
            this.txtBalance.Lines = new string[] {
        "Balance"};
            this.txtBalance.Location = new System.Drawing.Point(126, 234);
            this.txtBalance.MaxLength = 32767;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBalance.SelectedText = "";
            this.txtBalance.SelectionLength = 0;
            this.txtBalance.SelectionStart = 0;
            this.txtBalance.ShortcutsEnabled = true;
            this.txtBalance.Size = new System.Drawing.Size(121, 23);
            this.txtBalance.TabIndex = 8;
            this.txtBalance.Text = "Balance";
            this.txtBalance.UseSelectable = true;
            this.txtBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerId
            // 
            // 
            // 
            // 
            this.txtCustomerId.CustomButton.Image = null;
            this.txtCustomerId.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtCustomerId.CustomButton.Name = "";
            this.txtCustomerId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerId.CustomButton.TabIndex = 1;
            this.txtCustomerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerId.CustomButton.UseSelectable = true;
            this.txtCustomerId.CustomButton.Visible = false;
            this.txtCustomerId.Lines = new string[] {
        "CustomerId"};
            this.txtCustomerId.Location = new System.Drawing.Point(126, 285);
            this.txtCustomerId.MaxLength = 32767;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.PasswordChar = '\0';
            this.txtCustomerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerId.SelectedText = "";
            this.txtCustomerId.SelectionLength = 0;
            this.txtCustomerId.SelectionStart = 0;
            this.txtCustomerId.ShortcutsEnabled = true;
            this.txtCustomerId.Size = new System.Drawing.Size(121, 23);
            this.txtCustomerId.TabIndex = 9;
            this.txtCustomerId.Text = "CustomerId";
            this.txtCustomerId.UseSelectable = true;
            this.txtCustomerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridAccounts
            // 
            this.dataGridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACCOUNT_ID,
            this.ACCOUNT_NAME,
            this.CURRENCY,
            this.BALANCE,
            this.FK_CUSTOMER_ID});
            this.dataGridAccounts.Location = new System.Drawing.Point(375, 89);
            this.dataGridAccounts.Name = "dataGridAccounts";
            this.dataGridAccounts.RowHeadersWidth = 62;
            this.dataGridAccounts.RowTemplate.Height = 28;
            this.dataGridAccounts.Size = new System.Drawing.Size(828, 150);
            this.dataGridAccounts.TabIndex = 10;
            this.dataGridAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAccounts_CellContentClick);
            // 
            // ACCOUNT_ID
            // 
            this.ACCOUNT_ID.HeaderText = "Account Id";
            this.ACCOUNT_ID.MinimumWidth = 8;
            this.ACCOUNT_ID.Name = "ACCOUNT_ID";
            this.ACCOUNT_ID.Width = 150;
            // 
            // ACCOUNT_NAME
            // 
            this.ACCOUNT_NAME.HeaderText = "Account name";
            this.ACCOUNT_NAME.MinimumWidth = 8;
            this.ACCOUNT_NAME.Name = "ACCOUNT_NAME";
            this.ACCOUNT_NAME.Width = 150;
            // 
            // CURRENCY
            // 
            this.CURRENCY.HeaderText = "Currency";
            this.CURRENCY.MinimumWidth = 8;
            this.CURRENCY.Name = "CURRENCY";
            this.CURRENCY.Width = 150;
            // 
            // BALANCE
            // 
            this.BALANCE.HeaderText = "Balance";
            this.BALANCE.MinimumWidth = 8;
            this.BALANCE.Name = "BALANCE";
            this.BALANCE.Width = 150;
            // 
            // FK_CUSTOMER_ID
            // 
            this.FK_CUSTOMER_ID.HeaderText = "Customer Id";
            this.FK_CUSTOMER_ID.MinimumWidth = 8;
            this.FK_CUSTOMER_ID.Name = "FK_CUSTOMER_ID";
            this.FK_CUSTOMER_ID.Width = 150;
            // 
            // dataGridCustomers1
            // 
            this.dataGridCustomers1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUSTOMER_ID,
            this.NAME});
            this.dataGridCustomers1.Location = new System.Drawing.Point(375, 313);
            this.dataGridCustomers1.Name = "dataGridCustomers1";
            this.dataGridCustomers1.RowHeadersWidth = 62;
            this.dataGridCustomers1.RowTemplate.Height = 28;
            this.dataGridCustomers1.Size = new System.Drawing.Size(492, 150);
            this.dataGridCustomers1.TabIndex = 11;
            this.dataGridCustomers1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCustomers1_CellContentClick);
            // 
            // CUSTOMER_ID
            // 
            this.CUSTOMER_ID.HeaderText = "ID";
            this.CUSTOMER_ID.MinimumWidth = 8;
            this.CUSTOMER_ID.Name = "CUSTOMER_ID";
            this.CUSTOMER_ID.Width = 150;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "Name";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            this.NAME.Width = 150;
            // 
            // btnAddAccounts
            // 
            this.btnAddAccounts.Location = new System.Drawing.Point(22, 379);
            this.btnAddAccounts.Name = "btnAddAccounts";
            this.btnAddAccounts.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccounts.TabIndex = 12;
            this.btnAddAccounts.Text = "Add";
            this.btnAddAccounts.UseSelectable = true;
            this.btnAddAccounts.Click += new System.EventHandler(this.BtnAddAccounts_Click);
            // 
            // btnDeleteAccounts
            // 
            this.btnDeleteAccounts.Location = new System.Drawing.Point(22, 440);
            this.btnDeleteAccounts.Name = "btnDeleteAccounts";
            this.btnDeleteAccounts.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAccounts.TabIndex = 14;
            this.btnDeleteAccounts.Text = "Delete";
            this.btnDeleteAccounts.UseSelectable = true;
            this.btnDeleteAccounts.Click += new System.EventHandler(this.BtnDeleteAccounts_Click);
            // 
            // btnUpdateAccounts
            // 
            this.btnUpdateAccounts.Location = new System.Drawing.Point(146, 379);
            this.btnUpdateAccounts.Name = "btnUpdateAccounts";
            this.btnUpdateAccounts.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAccounts.TabIndex = 13;
            this.btnUpdateAccounts.Text = "Update";
            this.btnUpdateAccounts.UseSelectable = true;
            this.btnUpdateAccounts.Click += new System.EventHandler(this.BtnUpdateAccounts_Click);
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 749);
            this.Controls.Add(this.btnDeleteAccounts);
            this.Controls.Add(this.btnUpdateAccounts);
            this.Controls.Add(this.btnAddAccounts);
            this.Controls.Add(this.dataGridCustomers1);
            this.Controls.Add(this.dataGridAccounts);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAccountId);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AccountsForm";
            this.Text = "AccountsForm";
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox accountComboBox;
        private MetroFramework.Controls.MetroTextBox txtAccountId;
        private MetroFramework.Controls.MetroTextBox txtAccountName;
        private MetroFramework.Controls.MetroTextBox txtBalance;
        private MetroFramework.Controls.MetroTextBox txtCustomerId;
        private System.Windows.Forms.DataGridView dataGridAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENCY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BALANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_CUSTOMER_ID;
        private System.Windows.Forms.DataGridView dataGridCustomers1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private MetroFramework.Controls.MetroButton btnAddAccounts;
        private MetroFramework.Controls.MetroButton btnDeleteAccounts;
        private MetroFramework.Controls.MetroButton btnUpdateAccounts;
    }
}