namespace CenfoBankUI2
{
    partial class CreditsForm
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.CreditStartDate = new MetroFramework.Controls.MetroDateTime();
            this.ComboBoxStatus = new MetroFramework.Controls.MetroComboBox();
            this.txtCreditId = new MetroFramework.Controls.MetroTextBox();
            this.txtCreditFee = new MetroFramework.Controls.MetroTextBox();
            this.txtCreditName = new MetroFramework.Controls.MetroTextBox();
            this.txtCreditRate = new MetroFramework.Controls.MetroTextBox();
            this.txtCreditAmount = new MetroFramework.Controls.MetroTextBox();
            this.dataGridCredits = new System.Windows.Forms.DataGridView();
            this.btnAddCredit = new MetroFramework.Controls.MetroButton();
            this.btnRetrieve = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdateCredits = new MetroFramework.Controls.MetroButton();
            this.txtOperationalBalance = new MetroFramework.Controls.MetroTextBox();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CX_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtFkCustomerId = new MetroFramework.Controls.MetroTextBox();
            this.CREDIT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATIONAL_BALANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_CUSTOMER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.Location = new System.Drawing.Point(23, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Credit Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 402);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Status";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 352);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Start Date";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 306);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Fee";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 254);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Name";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 209);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Rate";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(21, 166);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Amount";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(11, 481);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(128, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Operational Balance";
            // 
            // CreditStartDate
            // 
            this.CreditStartDate.Location = new System.Drawing.Point(159, 352);
            this.CreditStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.CreditStartDate.Name = "CreditStartDate";
            this.CreditStartDate.Size = new System.Drawing.Size(200, 29);
            this.CreditStartDate.TabIndex = 16;
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.ItemHeight = 23;
            this.ComboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.ComboBoxStatus.Location = new System.Drawing.Point(177, 402);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(121, 29);
            this.ComboBoxStatus.TabIndex = 17;
            this.ComboBoxStatus.UseSelectable = true;
            // 
            // txtCreditId
            // 
            // 
            // 
            // 
            this.txtCreditId.CustomButton.Image = null;
            this.txtCreditId.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtCreditId.CustomButton.Name = "";
            this.txtCreditId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCreditId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreditId.CustomButton.TabIndex = 1;
            this.txtCreditId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreditId.CustomButton.UseSelectable = true;
            this.txtCreditId.CustomButton.Visible = false;
            this.txtCreditId.Enabled = false;
            this.txtCreditId.Lines = new string[] {
        "Credit Id"};
            this.txtCreditId.Location = new System.Drawing.Point(177, 120);
            this.txtCreditId.MaxLength = 32767;
            this.txtCreditId.Name = "txtCreditId";
            this.txtCreditId.PasswordChar = '\0';
            this.txtCreditId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreditId.SelectedText = "";
            this.txtCreditId.SelectionLength = 0;
            this.txtCreditId.SelectionStart = 0;
            this.txtCreditId.ShortcutsEnabled = true;
            this.txtCreditId.Size = new System.Drawing.Size(146, 23);
            this.txtCreditId.TabIndex = 19;
            this.txtCreditId.Text = "Credit Id";
            this.txtCreditId.UseSelectable = true;
            this.txtCreditId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreditId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCreditFee
            // 
            // 
            // 
            // 
            this.txtCreditFee.CustomButton.Image = null;
            this.txtCreditFee.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtCreditFee.CustomButton.Name = "";
            this.txtCreditFee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCreditFee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreditFee.CustomButton.TabIndex = 1;
            this.txtCreditFee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreditFee.CustomButton.UseSelectable = true;
            this.txtCreditFee.CustomButton.Visible = false;
            this.txtCreditFee.Lines = new string[] {
        "Credit free"};
            this.txtCreditFee.Location = new System.Drawing.Point(177, 302);
            this.txtCreditFee.MaxLength = 32767;
            this.txtCreditFee.Name = "txtCreditFee";
            this.txtCreditFee.PasswordChar = '\0';
            this.txtCreditFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreditFee.SelectedText = "";
            this.txtCreditFee.SelectionLength = 0;
            this.txtCreditFee.SelectionStart = 0;
            this.txtCreditFee.ShortcutsEnabled = true;
            this.txtCreditFee.Size = new System.Drawing.Size(146, 23);
            this.txtCreditFee.TabIndex = 20;
            this.txtCreditFee.Text = "Credit free";
            this.txtCreditFee.UseSelectable = true;
            this.txtCreditFee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreditFee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCreditName
            // 
            // 
            // 
            // 
            this.txtCreditName.CustomButton.Image = null;
            this.txtCreditName.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtCreditName.CustomButton.Name = "";
            this.txtCreditName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCreditName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreditName.CustomButton.TabIndex = 1;
            this.txtCreditName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreditName.CustomButton.UseSelectable = true;
            this.txtCreditName.CustomButton.Visible = false;
            this.txtCreditName.Lines = new string[] {
        "Credit name"};
            this.txtCreditName.Location = new System.Drawing.Point(177, 254);
            this.txtCreditName.MaxLength = 32767;
            this.txtCreditName.Name = "txtCreditName";
            this.txtCreditName.PasswordChar = '\0';
            this.txtCreditName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreditName.SelectedText = "";
            this.txtCreditName.SelectionLength = 0;
            this.txtCreditName.SelectionStart = 0;
            this.txtCreditName.ShortcutsEnabled = true;
            this.txtCreditName.Size = new System.Drawing.Size(146, 23);
            this.txtCreditName.TabIndex = 21;
            this.txtCreditName.Text = "Credit name";
            this.txtCreditName.UseSelectable = true;
            this.txtCreditName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreditName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCreditRate
            // 
            // 
            // 
            // 
            this.txtCreditRate.CustomButton.Image = null;
            this.txtCreditRate.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtCreditRate.CustomButton.Name = "";
            this.txtCreditRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCreditRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreditRate.CustomButton.TabIndex = 1;
            this.txtCreditRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreditRate.CustomButton.UseSelectable = true;
            this.txtCreditRate.CustomButton.Visible = false;
            this.txtCreditRate.Lines = new string[] {
        "Credit rate"};
            this.txtCreditRate.Location = new System.Drawing.Point(177, 209);
            this.txtCreditRate.MaxLength = 32767;
            this.txtCreditRate.Name = "txtCreditRate";
            this.txtCreditRate.PasswordChar = '\0';
            this.txtCreditRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreditRate.SelectedText = "";
            this.txtCreditRate.SelectionLength = 0;
            this.txtCreditRate.SelectionStart = 0;
            this.txtCreditRate.ShortcutsEnabled = true;
            this.txtCreditRate.Size = new System.Drawing.Size(146, 23);
            this.txtCreditRate.TabIndex = 22;
            this.txtCreditRate.Text = "Credit rate";
            this.txtCreditRate.UseSelectable = true;
            this.txtCreditRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreditRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCreditAmount
            // 
            // 
            // 
            // 
            this.txtCreditAmount.CustomButton.Image = null;
            this.txtCreditAmount.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtCreditAmount.CustomButton.Name = "";
            this.txtCreditAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCreditAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreditAmount.CustomButton.TabIndex = 1;
            this.txtCreditAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreditAmount.CustomButton.UseSelectable = true;
            this.txtCreditAmount.CustomButton.Visible = false;
            this.txtCreditAmount.Lines = new string[] {
        "Credit amount"};
            this.txtCreditAmount.Location = new System.Drawing.Point(177, 166);
            this.txtCreditAmount.MaxLength = 32767;
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.PasswordChar = '\0';
            this.txtCreditAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreditAmount.SelectedText = "";
            this.txtCreditAmount.SelectionLength = 0;
            this.txtCreditAmount.SelectionStart = 0;
            this.txtCreditAmount.ShortcutsEnabled = true;
            this.txtCreditAmount.Size = new System.Drawing.Size(146, 23);
            this.txtCreditAmount.TabIndex = 23;
            this.txtCreditAmount.Text = "Credit amount";
            this.txtCreditAmount.UseSelectable = true;
            this.txtCreditAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreditAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridCredits
            // 
            this.dataGridCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCredits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CREDIT_ID,
            this.AMOUNT,
            this.RATE,
            this.NAME1,
            this.FEE,
            this.START_DATE,
            this.STATUS,
            this.OPERATIONAL_BALANCE,
            this.FK_CUSTOMER_ID});
            this.dataGridCredits.Location = new System.Drawing.Point(384, 108);
            this.dataGridCredits.Name = "dataGridCredits";
            this.dataGridCredits.RowHeadersWidth = 62;
            this.dataGridCredits.RowTemplate.Height = 28;
            this.dataGridCredits.Size = new System.Drawing.Size(886, 217);
            this.dataGridCredits.TabIndex = 24;
            this.dataGridCredits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCredits_CellContentClick);
            // 
            // btnAddCredit
            // 
            this.btnAddCredit.Location = new System.Drawing.Point(16, 599);
            this.btnAddCredit.Name = "btnAddCredit";
            this.btnAddCredit.Size = new System.Drawing.Size(75, 23);
            this.btnAddCredit.TabIndex = 25;
            this.btnAddCredit.Text = "Add";
            this.btnAddCredit.UseSelectable = true;
            this.btnAddCredit.Click += new System.EventHandler(this.BtnAddCredit_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(144, 599);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 26;
            this.btnRetrieve.Text = "Retrieve All";
            this.btnRetrieve.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 599);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdateCredits
            // 
            this.btnUpdateCredits.Location = new System.Drawing.Point(265, 599);
            this.btnUpdateCredits.Name = "btnUpdateCredits";
            this.btnUpdateCredits.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCredits.TabIndex = 28;
            this.btnUpdateCredits.Text = "Update";
            this.btnUpdateCredits.UseSelectable = true;
            this.btnUpdateCredits.Click += new System.EventHandler(this.BtnUpdateCredits_Click);
            // 
            // txtOperationalBalance
            // 
            // 
            // 
            // 
            this.txtOperationalBalance.CustomButton.Image = null;
            this.txtOperationalBalance.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtOperationalBalance.CustomButton.Name = "";
            this.txtOperationalBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOperationalBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOperationalBalance.CustomButton.TabIndex = 1;
            this.txtOperationalBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOperationalBalance.CustomButton.UseSelectable = true;
            this.txtOperationalBalance.CustomButton.Visible = false;
            this.txtOperationalBalance.Lines = new string[] {
        "Balance"};
            this.txtOperationalBalance.Location = new System.Drawing.Point(213, 481);
            this.txtOperationalBalance.MaxLength = 32767;
            this.txtOperationalBalance.Name = "txtOperationalBalance";
            this.txtOperationalBalance.PasswordChar = '\0';
            this.txtOperationalBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOperationalBalance.SelectedText = "";
            this.txtOperationalBalance.SelectionLength = 0;
            this.txtOperationalBalance.SelectionStart = 0;
            this.txtOperationalBalance.ShortcutsEnabled = true;
            this.txtOperationalBalance.Size = new System.Drawing.Size(146, 23);
            this.txtOperationalBalance.TabIndex = 29;
            this.txtOperationalBalance.Text = "Balance";
            this.txtOperationalBalance.UseSelectable = true;
            this.txtOperationalBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOperationalBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CX_NAME});
            this.dataGridCustomers.Location = new System.Drawing.Point(508, 371);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.RowHeadersWidth = 62;
            this.dataGridCustomers.RowTemplate.Height = 28;
            this.dataGridCustomers.Size = new System.Drawing.Size(762, 160);
            this.dataGridCustomers.TabIndex = 30;
            this.dataGridCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCustomers_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // CX_NAME
            // 
            this.CX_NAME.HeaderText = "Name";
            this.CX_NAME.MinimumWidth = 8;
            this.CX_NAME.Name = "CX_NAME";
            this.CX_NAME.Width = 150;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(21, 540);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(77, 19);
            this.metroLabel9.TabIndex = 31;
            this.metroLabel9.Text = "CustomerId";
            // 
            // txtFkCustomerId
            // 
            // 
            // 
            // 
            this.txtFkCustomerId.CustomButton.Image = null;
            this.txtFkCustomerId.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtFkCustomerId.CustomButton.Name = "";
            this.txtFkCustomerId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFkCustomerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFkCustomerId.CustomButton.TabIndex = 1;
            this.txtFkCustomerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFkCustomerId.CustomButton.UseSelectable = true;
            this.txtFkCustomerId.CustomButton.Visible = false;
            this.txtFkCustomerId.Lines = new string[] {
        "Customer Id"};
            this.txtFkCustomerId.Location = new System.Drawing.Point(177, 536);
            this.txtFkCustomerId.MaxLength = 32767;
            this.txtFkCustomerId.Name = "txtFkCustomerId";
            this.txtFkCustomerId.PasswordChar = '\0';
            this.txtFkCustomerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFkCustomerId.SelectedText = "";
            this.txtFkCustomerId.SelectionLength = 0;
            this.txtFkCustomerId.SelectionStart = 0;
            this.txtFkCustomerId.ShortcutsEnabled = true;
            this.txtFkCustomerId.Size = new System.Drawing.Size(146, 23);
            this.txtFkCustomerId.TabIndex = 32;
            this.txtFkCustomerId.Text = "Customer Id";
            this.txtFkCustomerId.UseSelectable = true;
            this.txtFkCustomerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFkCustomerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CREDIT_ID
            // 
            this.CREDIT_ID.HeaderText = "Credit id";
            this.CREDIT_ID.MinimumWidth = 8;
            this.CREDIT_ID.Name = "CREDIT_ID";
            this.CREDIT_ID.Width = 150;
            // 
            // AMOUNT
            // 
            this.AMOUNT.HeaderText = "Amount";
            this.AMOUNT.MinimumWidth = 8;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Width = 150;
            // 
            // RATE
            // 
            this.RATE.HeaderText = "Rate";
            this.RATE.MinimumWidth = 8;
            this.RATE.Name = "RATE";
            this.RATE.Width = 150;
            // 
            // NAME1
            // 
            this.NAME1.HeaderText = "Name";
            this.NAME1.MinimumWidth = 8;
            this.NAME1.Name = "NAME1";
            this.NAME1.Width = 150;
            // 
            // FEE
            // 
            this.FEE.HeaderText = "Fee";
            this.FEE.MinimumWidth = 8;
            this.FEE.Name = "FEE";
            this.FEE.Width = 150;
            // 
            // START_DATE
            // 
            this.START_DATE.HeaderText = "Start Date";
            this.START_DATE.MinimumWidth = 8;
            this.START_DATE.Name = "START_DATE";
            this.START_DATE.Width = 150;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "Status";
            this.STATUS.MinimumWidth = 8;
            this.STATUS.Name = "STATUS";
            this.STATUS.Width = 150;
            // 
            // OPERATIONAL_BALANCE
            // 
            this.OPERATIONAL_BALANCE.HeaderText = "Operational balance";
            this.OPERATIONAL_BALANCE.MinimumWidth = 8;
            this.OPERATIONAL_BALANCE.Name = "OPERATIONAL_BALANCE";
            this.OPERATIONAL_BALANCE.Width = 150;
            // 
            // FK_CUSTOMER_ID
            // 
            this.FK_CUSTOMER_ID.HeaderText = "Customer Id";
            this.FK_CUSTOMER_ID.MinimumWidth = 8;
            this.FK_CUSTOMER_ID.Name = "FK_CUSTOMER_ID";
            this.FK_CUSTOMER_ID.Width = 150;
            // 
            // CreditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 686);
            this.Controls.Add(this.txtFkCustomerId);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dataGridCustomers);
            this.Controls.Add(this.txtOperationalBalance);
            this.Controls.Add(this.btnUpdateCredits);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnAddCredit);
            this.Controls.Add(this.dataGridCredits);
            this.Controls.Add(this.txtCreditAmount);
            this.Controls.Add(this.txtCreditRate);
            this.Controls.Add(this.txtCreditName);
            this.Controls.Add(this.txtCreditFee);
            this.Controls.Add(this.txtCreditId);
            this.Controls.Add(this.ComboBoxStatus);
            this.Controls.Add(this.CreditStartDate);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CreditsForm";
            this.Text = "CreditsForm";
            this.Load += new System.EventHandler(this.CreditsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredits)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime CreditStartDate;
        private MetroFramework.Controls.MetroComboBox ComboBoxStatus;
        private MetroFramework.Controls.MetroTextBox txtCreditId;
        private MetroFramework.Controls.MetroTextBox txtCreditFee;
        private MetroFramework.Controls.MetroTextBox txtCreditName;
        private MetroFramework.Controls.MetroTextBox txtCreditRate;
        private MetroFramework.Controls.MetroTextBox txtCreditAmount;
        private System.Windows.Forms.DataGridView dataGridCredits;
        private MetroFramework.Controls.MetroButton btnAddCredit;
        private MetroFramework.Controls.MetroButton btnRetrieve;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdateCredits;
        private MetroFramework.Controls.MetroTextBox txtOperationalBalance;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CX_NAME;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtFkCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDIT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn START_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATIONAL_BALANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_CUSTOMER_ID;
    }
}