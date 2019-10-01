namespace CenfoBankUI
{
    partial class CenfoBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CenfoBank));
            this.goTOuserControl = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // goTOuserControl
            // 
            this.goTOuserControl.BackColor = System.Drawing.Color.MediumAquamarine;
            this.goTOuserControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goTOuserControl.BackgroundImage")));
            this.goTOuserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goTOuserControl.Location = new System.Drawing.Point(159, 184);
            this.goTOuserControl.Name = "goTOuserControl";
            this.goTOuserControl.Size = new System.Drawing.Size(121, 77);
            this.goTOuserControl.TabIndex = 2;
            this.goTOuserControl.UseSelectable = true;
            this.goTOuserControl.Click += new System.EventHandler(this.GoTOuserControl_Click);
            // 
            // CenfoBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(929, 657);
            this.Controls.Add(this.goTOuserControl);
            this.Name = "CenfoBank";
            this.Text = "CenfoBanCenfoBank";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton goTOuserControl;
    }
}

