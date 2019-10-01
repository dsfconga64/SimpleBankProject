namespace CenfoBankUI
{
    partial class CxUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CxUserControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerId = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dateCustomer = new MetroFramework.Controls.MetroDateTime();
            this.comboCustomerCivilStatus = new MetroFramework.Controls.MetroComboBox();
            this.comboCustomerGender = new MetroFramework.Controls.MetroComboBox();
            this.numCustomerAge = new System.Windows.Forms.NumericUpDown();
            this.btnAddCustomer = new MetroFramework.Controls.MetroButton();
            this.btnRetrieveByIdCustomer = new MetroFramework.Controls.MetroButton();
            this.btnDeleteCustomer = new MetroFramework.Controls.MetroButton();
            this.btnUpdateCustomer = new MetroFramework.Controls.MetroButton();
            this.btnCloseWindowCustomer = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomerAge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(173, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(36, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id cliente:";
            // 
            // txtCustomerId
            // 
            // 
            // 
            // 
            this.txtCustomerId.CustomButton.Image = null;
            this.txtCustomerId.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtCustomerId.CustomButton.Name = "";
            this.txtCustomerId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerId.CustomButton.TabIndex = 1;
            this.txtCustomerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerId.CustomButton.UseSelectable = true;
            this.txtCustomerId.CustomButton.Visible = false;
            this.txtCustomerId.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCustomerId.Lines = new string[] {
        "Customer Id"};
            this.txtCustomerId.Location = new System.Drawing.Point(185, 158);
            this.txtCustomerId.MaxLength = 32767;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.PasswordChar = '\0';
            this.txtCustomerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerId.SelectedText = "";
            this.txtCustomerId.SelectionLength = 0;
            this.txtCustomerId.SelectionStart = 0;
            this.txtCustomerId.ShortcutsEnabled = true;
            this.txtCustomerId.Size = new System.Drawing.Size(204, 23);
            this.txtCustomerId.TabIndex = 3;
            this.txtCustomerId.Text = "Customer Id";
            this.txtCustomerId.UseSelectable = true;
            this.txtCustomerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerId.WaterMarkFont = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtCustomerLastName
            // 
            // 
            // 
            // 
            this.txtCustomerLastName.CustomButton.Image = null;
            this.txtCustomerLastName.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtCustomerLastName.CustomButton.Name = "";
            this.txtCustomerLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerLastName.CustomButton.TabIndex = 1;
            this.txtCustomerLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerLastName.CustomButton.UseSelectable = true;
            this.txtCustomerLastName.CustomButton.Visible = false;
            this.txtCustomerLastName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCustomerLastName.Lines = new string[] {
        "Last name"};
            this.txtCustomerLastName.Location = new System.Drawing.Point(185, 282);
            this.txtCustomerLastName.MaxLength = 32767;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.PasswordChar = '\0';
            this.txtCustomerLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerLastName.SelectedText = "";
            this.txtCustomerLastName.SelectionLength = 0;
            this.txtCustomerLastName.SelectionStart = 0;
            this.txtCustomerLastName.ShortcutsEnabled = true;
            this.txtCustomerLastName.Size = new System.Drawing.Size(204, 23);
            this.txtCustomerLastName.TabIndex = 5;
            this.txtCustomerLastName.Text = "Last name";
            this.txtCustomerLastName.UseSelectable = true;
            this.txtCustomerLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCustomerName.Lines = new string[] {
        "Name"};
            this.txtCustomerName.Location = new System.Drawing.Point(185, 216);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(204, 23);
            this.txtCustomerName.TabIndex = 7;
            this.txtCustomerName.Text = "Name";
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(36, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(32, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(32, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(407, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Civil status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(407, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "Born date:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl.Location = new System.Drawing.Point(407, 268);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(114, 37);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Gender";
            this.lbl.Click += new System.EventHandler(this.Gender_Click);
            // 
            // dateCustomer
            // 
            this.dateCustomer.Location = new System.Drawing.Point(559, 153);
            this.dateCustomer.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateCustomer.Name = "dateCustomer";
            this.dateCustomer.Size = new System.Drawing.Size(200, 29);
            this.dateCustomer.TabIndex = 16;
            // 
            // comboCustomerCivilStatus
            // 
            this.comboCustomerCivilStatus.FormattingEnabled = true;
            this.comboCustomerCivilStatus.ItemHeight = 23;
            this.comboCustomerCivilStatus.Location = new System.Drawing.Point(581, 216);
            this.comboCustomerCivilStatus.Name = "comboCustomerCivilStatus";
            this.comboCustomerCivilStatus.Size = new System.Drawing.Size(183, 29);
            this.comboCustomerCivilStatus.TabIndex = 17;
            this.comboCustomerCivilStatus.UseSelectable = true;
            // 
            // comboCustomerGender
            // 
            this.comboCustomerGender.FormattingEnabled = true;
            this.comboCustomerGender.ItemHeight = 23;
            this.comboCustomerGender.Location = new System.Drawing.Point(576, 276);
            this.comboCustomerGender.Name = "comboCustomerGender";
            this.comboCustomerGender.Size = new System.Drawing.Size(183, 29);
            this.comboCustomerGender.TabIndex = 18;
            this.comboCustomerGender.UseSelectable = true;
            // 
            // numCustomerAge
            // 
            this.numCustomerAge.Location = new System.Drawing.Point(185, 342);
            this.numCustomerAge.Name = "numCustomerAge";
            this.numCustomerAge.Size = new System.Drawing.Size(204, 26);
            this.numCustomerAge.TabIndex = 19;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCustomer.Location = new System.Drawing.Point(39, 422);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 75);
            this.btnAddCustomer.TabIndex = 20;
            this.btnAddCustomer.UseSelectable = true;
            // 
            // btnRetrieveByIdCustomer
            // 
            this.btnRetrieveByIdCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetrieveByIdCustomer.BackgroundImage")));
            this.btnRetrieveByIdCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRetrieveByIdCustomer.Location = new System.Drawing.Point(185, 422);
            this.btnRetrieveByIdCustomer.Name = "btnRetrieveByIdCustomer";
            this.btnRetrieveByIdCustomer.Size = new System.Drawing.Size(100, 75);
            this.btnRetrieveByIdCustomer.TabIndex = 21;
            this.btnRetrieveByIdCustomer.UseSelectable = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.BackgroundImage")));
            this.btnDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(340, 422);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(100, 75);
            this.btnDeleteCustomer.TabIndex = 22;
            this.btnDeleteCustomer.UseSelectable = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomer.BackgroundImage")));
            this.btnUpdateCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(499, 422);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(100, 75);
            this.btnUpdateCustomer.TabIndex = 23;
            this.btnUpdateCustomer.UseSelectable = true;
            // 
            // btnCloseWindowCustomer
            // 
            this.btnCloseWindowCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseWindowCustomer.BackgroundImage")));
            this.btnCloseWindowCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseWindowCustomer.Location = new System.Drawing.Point(689, 3);
            this.btnCloseWindowCustomer.Name = "btnCloseWindowCustomer";
            this.btnCloseWindowCustomer.Size = new System.Drawing.Size(100, 75);
            this.btnCloseWindowCustomer.TabIndex = 24;
            this.btnCloseWindowCustomer.UseSelectable = true;
            this.btnCloseWindowCustomer.Click += new System.EventHandler(this.BtnCloseWindowCustomer_Click);
            // 
            // CxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.btnCloseWindowCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnRetrieveByIdCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.numCustomerAge);
            this.Controls.Add(this.comboCustomerGender);
            this.Controls.Add(this.comboCustomerCivilStatus);
            this.Controls.Add(this.dateCustomer);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CxUserControl";
            this.Size = new System.Drawing.Size(1033, 652);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomerAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtCustomerId;
        private MetroFramework.Controls.MetroTextBox txtCustomerLastName;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl;
        private MetroFramework.Controls.MetroDateTime dateCustomer;
        private MetroFramework.Controls.MetroComboBox comboCustomerCivilStatus;
        private MetroFramework.Controls.MetroComboBox comboCustomerGender;
        private System.Windows.Forms.NumericUpDown numCustomerAge;
        private MetroFramework.Controls.MetroButton btnAddCustomer;
        private MetroFramework.Controls.MetroButton btnRetrieveByIdCustomer;
        private MetroFramework.Controls.MetroButton btnDeleteCustomer;
        private MetroFramework.Controls.MetroButton btnUpdateCustomer;
        private MetroFramework.Controls.MetroButton btnCloseWindowCustomer;
    }
}
