using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenfoBankUI2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            cxForm cxFormp = new cxForm();
            cxFormp.Show();
        }

        private void BtnCreditsForm_Click(object sender, EventArgs e)
        {
            CreditsForm creForm = new CreditsForm();
            creForm.Show();
        }

        private void BtnAccountForm_Click(object sender, EventArgs e)
        {
            AccountsForm accountsForm = new AccountsForm();
            accountsForm.Show();
        }

        private void BtnAddressForm_Click(object sender, EventArgs e)
        {
            AddressesForm addressesForm = new AddressesForm();
            addressesForm.Show();
        }
    }
}
