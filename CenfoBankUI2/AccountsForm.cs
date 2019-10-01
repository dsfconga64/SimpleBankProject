using ConsoleApp1;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenfoBankUI2
{
    public partial class AccountsForm : MetroFramework.Forms.MetroForm
    {
        Customer cx = new Customer();

        Account acc = new Account();
        AccountManagement accountManagement = new AccountManagement();

        CustomerManagement mng = new CustomerManagement();
        public AccountsForm()
        {
            InitializeComponent();
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            var lstAccounts = accountManagement.RetrieveAll();
            var count1 = 0;

            foreach (var a in lstAccounts)
            {
                count1++;
                dataGridAccounts.Rows.Add(a.AccountId, a.AccountName, a.Currency, a.Balance, a.Fk_Customer_Id);
            }

            var lstCustomers = mng.RetrieveAll();
            var count = 0;
            foreach (var c in lstCustomers)
            {
                count++;

                dataGridCustomers1.Rows.Add(c.Id, c.Name);
            }

        }

        private void DataGridAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                DataGridViewRow rows = this.dataGridAccounts.Rows[e.RowIndex];
                txtAccountId.Text = rows.Cells["ACCOUNT_ID"].Value.ToString();
                txtAccountName.Text = rows.Cells["ACCOUNT_NAME"].Value.ToString();
                accountComboBox.SelectedIndex = accountComboBox.FindStringExact(rows.Cells["CURRENCY"].Value.ToString());
                txtBalance.Text = rows.Cells["BALANCE"].Value.ToString();
                txtCustomerId.Text = rows.Cells["FK_CUSTOMER_ID"].Value.ToString();
            }
        }

        private void DataGridCustomers1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -2)
            {
                DataGridViewRow rows = this.dataGridCustomers1.Rows[e.RowIndex];
                txtCustomerId.Text = rows.Cells["CUSTOMER_ID"].Value.ToString();

            }
        }

        private void BtnAddAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                var info = txtAccountName.Text.ToString() + ',' + accountComboBox.SelectedItem.ToString() + ',' + txtBalance.Text.ToString() + ',' + txtCustomerId.Text.ToString();
                var infoArray = info.Split(',');
                acc = new Account(infoArray);
                accountManagement.Create(acc);

                MessageBox.Show("Account added");

            }
            catch (Exception es)
            {

                MessageBox.Show("Values missing or entered wrong" + es);
            }
        }

        private void BtnUpdateAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                acc.AccountId = Int32.Parse(txtAccountId.Text.ToString());
                acc.Currency = accountComboBox.SelectedItem.ToString();
                acc.AccountName = txtAccountName.Text.ToString();
                acc.Balance = double.Parse(txtBalance.Text.ToString());
                acc.Fk_Customer_Id = txtCustomerId.Text.ToString();

                accountManagement.Update(acc);

                dataGridAccounts.Rows.Clear();
                dataGridCustomers1.Rows.Clear();

                AccountsForm_Load(null, null);


                MessageBox.Show("Hey updated here my man");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDeleteAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                acc.AccountId = Int32.Parse(txtAccountId.Text.ToString());

                accountManagement.Delete(acc);

                dataGridCustomers1.Rows.Clear();
                dataGridAccounts.Rows.Clear();

                AccountsForm_Load(null, null);

                MessageBox.Show("Address Deleted ");

            }
            catch (SqlException ex)
            {

                MessageBox.Show("something went wrong " + ex.ToString());
            }
        }
    }
}
