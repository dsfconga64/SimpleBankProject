namespace CenfoBankUI2
{
    partial class Form1
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
            this.btnCustomerForm = new MetroFramework.Controls.MetroButton();
            this.btnCreditsForm = new MetroFramework.Controls.MetroButton();
            this.btnAccountForm = new MetroFramework.Controls.MetroButton();
            this.btnAddressForm = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCustomerForm
            // 
            this.btnCustomerForm.Location = new System.Drawing.Point(190, 115);
            this.btnCustomerForm.Name = "btnCustomerForm";
            this.btnCustomerForm.Size = new System.Drawing.Size(101, 42);
            this.btnCustomerForm.TabIndex = 0;
            this.btnCustomerForm.Text = "Customer";
            this.btnCustomerForm.UseSelectable = true;
            this.btnCustomerForm.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // btnCreditsForm
            // 
            this.btnCreditsForm.Location = new System.Drawing.Point(436, 115);
            this.btnCreditsForm.Name = "btnCreditsForm";
            this.btnCreditsForm.Size = new System.Drawing.Size(106, 42);
            this.btnCreditsForm.TabIndex = 1;
            this.btnCreditsForm.Text = "Credits";
            this.btnCreditsForm.UseSelectable = true;
            this.btnCreditsForm.Click += new System.EventHandler(this.BtnCreditsForm_Click);
            // 
            // btnAccountForm
            // 
            this.btnAccountForm.Location = new System.Drawing.Point(190, 195);
            this.btnAccountForm.Name = "btnAccountForm";
            this.btnAccountForm.Size = new System.Drawing.Size(101, 42);
            this.btnAccountForm.TabIndex = 2;
            this.btnAccountForm.Text = "Accounts";
            this.btnAccountForm.UseSelectable = true;
            this.btnAccountForm.Click += new System.EventHandler(this.BtnAccountForm_Click);
            // 
            // btnAddressForm
            // 
            this.btnAddressForm.Location = new System.Drawing.Point(436, 195);
            this.btnAddressForm.Name = "btnAddressForm";
            this.btnAddressForm.Size = new System.Drawing.Size(106, 42);
            this.btnAddressForm.TabIndex = 3;
            this.btnAddressForm.Text = "Addresses";
            this.btnAddressForm.UseSelectable = true;
            this.btnAddressForm.Click += new System.EventHandler(this.BtnAddressForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddressForm);
            this.Controls.Add(this.btnAccountForm);
            this.Controls.Add(this.btnCreditsForm);
            this.Controls.Add(this.btnCustomerForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCustomerForm;
        private MetroFramework.Controls.MetroButton btnCreditsForm;
        private MetroFramework.Controls.MetroButton btnAccountForm;
        private MetroFramework.Controls.MetroButton btnAddressForm;
    }
}

