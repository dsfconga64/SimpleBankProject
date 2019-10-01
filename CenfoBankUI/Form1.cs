using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenfoBankUI
{
    public partial class CenfoBank : MetroFramework.Forms.MetroForm
    {

        CxUserControl cxUserCont = new CxUserControl();
        
        
        public CenfoBank()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GoTOuserControl_Click(object sender, EventArgs e)
        {
            this.Controls.Add(cxUserCont);
            goTOuserControl.SendToBack();
            this.BringToFront();

        }

    }
}
