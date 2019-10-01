namespace CenfoBankUI2
{
    partial class cxForm
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
            this.txtCustomerId = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerLastName = new MetroFramework.Controls.MetroTextBox();
            this.numericCustomerAge = new System.Windows.Forms.NumericUpDown();
            this.DateTimeCustomer = new MetroFramework.Controls.MetroDateTime();
            this.CivilComboBoxCustomer = new MetroFramework.Controls.MetroComboBox();
            this.GenderComboBoxCustomer = new MetroFramework.Controls.MetroComboBox();
            this.btnAddCustomer = new MetroFramework.Controls.MetroButton();
            this.btnRetrieveAllCustomers = new MetroFramework.Controls.MetroButton();
            this.btnUpdateCustomer = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BORN_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIVIL_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteCustomer = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericCustomerAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 191);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Last name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 346);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Civil status";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 283);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Born date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 234);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Age";
            this.metroLabel6.Click += new System.EventHandler(this.MetroLabel6_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(316, 97);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Gender";
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
        "Id Customer"};
            this.txtCustomerId.Location = new System.Drawing.Point(173, 97);
            this.txtCustomerId.MaxLength = 32767;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.PasswordChar = '\0';
            this.txtCustomerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerId.SelectedText = "";
            this.txtCustomerId.SelectionLength = 0;
            this.txtCustomerId.SelectionStart = 0;
            this.txtCustomerId.ShortcutsEnabled = true;
            this.txtCustomerId.Size = new System.Drawing.Size(121, 23);
            this.txtCustomerId.TabIndex = 7;
            this.txtCustomerId.Text = "Id Customer";
            this.txtCustomerId.UseSelectable = true;
            this.txtCustomerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[] {
        "Name"};
            this.txtCustomerName.Location = new System.Drawing.Point(173, 142);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(121, 23);
            this.txtCustomerName.TabIndex = 8;
            this.txtCustomerName.Text = "Name";
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerLastName
            // 
            // 
            // 
            // 
            this.txtCustomerLastName.CustomButton.Image = null;
            this.txtCustomerLastName.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtCustomerLastName.CustomButton.Name = "";
            this.txtCustomerLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerLastName.CustomButton.TabIndex = 1;
            this.txtCustomerLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerLastName.CustomButton.UseSelectable = true;
            this.txtCustomerLastName.CustomButton.Visible = false;
            this.txtCustomerLastName.Lines = new string[] {
        "Last Name"};
            this.txtCustomerLastName.Location = new System.Drawing.Point(173, 191);
            this.txtCustomerLastName.MaxLength = 32767;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.PasswordChar = '\0';
            this.txtCustomerLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerLastName.SelectedText = "";
            this.txtCustomerLastName.SelectionLength = 0;
            this.txtCustomerLastName.SelectionStart = 0;
            this.txtCustomerLastName.ShortcutsEnabled = true;
            this.txtCustomerLastName.Size = new System.Drawing.Size(120, 23);
            this.txtCustomerLastName.TabIndex = 9;
            this.txtCustomerLastName.Text = "Last Name";
            this.txtCustomerLastName.UseSelectable = true;
            this.txtCustomerLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // numericCustomerAge
            // 
            this.numericCustomerAge.Location = new System.Drawing.Point(173, 234);
            this.numericCustomerAge.Name = "numericCustomerAge";
            this.numericCustomerAge.Size = new System.Drawing.Size(120, 26);
            this.numericCustomerAge.TabIndex = 10;
            // 
            // DateTimeCustomer
            // 
            this.DateTimeCustomer.Location = new System.Drawing.Point(168, 283);
            this.DateTimeCustomer.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeCustomer.Name = "DateTimeCustomer";
            this.DateTimeCustomer.Size = new System.Drawing.Size(200, 29);
            this.DateTimeCustomer.TabIndex = 11;
            // 
            // CivilComboBoxCustomer
            // 
            this.CivilComboBoxCustomer.FormattingEnabled = true;
            this.CivilComboBoxCustomer.ItemHeight = 23;
            this.CivilComboBoxCustomer.Items.AddRange(new object[] {
            "Casado",
            "Soltero",
            "Divorciado"});
            this.CivilComboBoxCustomer.Location = new System.Drawing.Point(168, 336);
            this.CivilComboBoxCustomer.Name = "CivilComboBoxCustomer";
            this.CivilComboBoxCustomer.Size = new System.Drawing.Size(121, 29);
            this.CivilComboBoxCustomer.TabIndex = 12;
            this.CivilComboBoxCustomer.UseSelectable = true;
            this.CivilComboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.MetroComboBox1_SelectedIndexChanged);
            // 
            // GenderComboBoxCustomer
            // 
            this.GenderComboBoxCustomer.FormattingEnabled = true;
            this.GenderComboBoxCustomer.ItemHeight = 23;
            this.GenderComboBoxCustomer.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.GenderComboBoxCustomer.Location = new System.Drawing.Point(452, 91);
            this.GenderComboBoxCustomer.Name = "GenderComboBoxCustomer";
            this.GenderComboBoxCustomer.Size = new System.Drawing.Size(121, 29);
            this.GenderComboBoxCustomer.TabIndex = 13;
            this.GenderComboBoxCustomer.UseSelectable = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(40, 392);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 14;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseSelectable = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnRetrieveAllCustomers
            // 
            this.btnRetrieveAllCustomers.Location = new System.Drawing.Point(173, 392);
            this.btnRetrieveAllCustomers.Name = "btnRetrieveAllCustomers";
            this.btnRetrieveAllCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieveAllCustomers.TabIndex = 15;
            this.btnRetrieveAllCustomers.Text = "Retrieve All Customers";
            this.btnRetrieveAllCustomers.UseSelectable = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(316, 392);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 16;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseSelectable = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.LAST_NAME,
            this.AGE,
            this.BORN_DATE,
            this.CIVIL_STATUS,
            this.GENDER});
            this.dataGridView1.Location = new System.Drawing.Point(439, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(765, 276);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
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
            // LAST_NAME
            // 
            this.LAST_NAME.HeaderText = "LastName";
            this.LAST_NAME.MinimumWidth = 8;
            this.LAST_NAME.Name = "LAST_NAME";
            this.LAST_NAME.Width = 150;
            // 
            // AGE
            // 
            this.AGE.HeaderText = "Age";
            this.AGE.MinimumWidth = 8;
            this.AGE.Name = "AGE";
            this.AGE.Width = 150;
            // 
            // BORN_DATE
            // 
            this.BORN_DATE.HeaderText = "BornDate";
            this.BORN_DATE.MinimumWidth = 8;
            this.BORN_DATE.Name = "BORN_DATE";
            this.BORN_DATE.Width = 150;
            // 
            // CIVIL_STATUS
            // 
            this.CIVIL_STATUS.HeaderText = "Civil status";
            this.CIVIL_STATUS.MinimumWidth = 8;
            this.CIVIL_STATUS.Name = "CIVIL_STATUS";
            this.CIVIL_STATUS.Width = 150;
            // 
            // GENDER
            // 
            this.GENDER.HeaderText = "Gender";
            this.GENDER.MinimumWidth = 8;
            this.GENDER.Name = "GENDER";
            this.GENDER.Width = 150;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(40, 468);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 18;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseSelectable = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // cxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 664);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnRetrieveAllCustomers);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.GenderComboBoxCustomer);
            this.Controls.Add(this.CivilComboBoxCustomer);
            this.Controls.Add(this.DateTimeCustomer);
            this.Controls.Add(this.numericCustomerAge);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "cxForm";
            this.Text = "cxForm";
            this.Load += new System.EventHandler(this.CxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCustomerAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox txtCustomerId;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroTextBox txtCustomerLastName;
        private System.Windows.Forms.NumericUpDown numericCustomerAge;
        private MetroFramework.Controls.MetroDateTime DateTimeCustomer;
        private MetroFramework.Controls.MetroComboBox CivilComboBoxCustomer;
        private MetroFramework.Controls.MetroComboBox GenderComboBoxCustomer;
        private MetroFramework.Controls.MetroButton btnAddCustomer;
        private MetroFramework.Controls.MetroButton btnRetrieveAllCustomers;
        private MetroFramework.Controls.MetroButton btnUpdateCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BORN_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIVIL_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private MetroFramework.Controls.MetroButton btnDeleteCustomer;
    }
}