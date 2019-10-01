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
    public partial class CreditsForm : MetroFramework.Forms.MetroForm
    {
        Credit credits = new Credit();
        CreditMangement mngCre = new CreditMangement();
        CustomerManagement mng = new CustomerManagement();
        public CreditsForm()
        {
            InitializeComponent();
        }

        private void CreditsForm_Load(object sender, EventArgs e)
        {
            var lsttCredits = mngCre.RetrieveAll();
            var count1 = 0;

            foreach (var cre in lsttCredits)
            {
                count1++;
                dataGridCredits.Rows.Add(cre.CreditId, cre.Amount, cre.Rate, cre.Name, cre.Fee, cre.StartDate, cre.Status, cre.OperationalBalance, cre.FK_CUSTOMER_ID);
            }

            var lstCustomers = mng.RetrieveAll();
            var count = 0;

            foreach (var c in lstCustomers)
            {
                count++;

                dataGridCustomers.Rows.Add(c.Id, c.Name);
            }

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddCredit_Click(object sender, EventArgs e)
        {
            try
            {
                var info = txtCreditAmount.Text.ToString() + ',' + txtCreditRate.Text.ToString() + ',' + txtCreditName.Text.ToString() + ',' + txtCreditFee.Text.ToString() + ',' + CreditStartDate.Value.ToString("yyyy-MM-dd") + ',' + ComboBoxStatus.SelectedItem.ToString() + ',' + txtOperationalBalance.Text.ToString()+','+txtFkCustomerId.Text.ToString();
                var infoArray = info.Split(',');
                credits = new Credit(infoArray);
                mngCre.Create(credits);
                MessageBox.Show("Credit created");

            }
            catch (Exception es)
            {

                MessageBox.Show("Bad Values or missing values" + es);
            }

        }

        private void DataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -2)
            {
                DataGridViewRow rows = this.dataGridCustomers.Rows[e.RowIndex];
                txtFkCustomerId.Text = rows.Cells["Id"].Value.ToString();


            }
        }

        private void BtnUpdateCredits_Click(object sender, EventArgs e)
        {
            try
            {
                credits.CreditId = Int32.Parse(txtCreditId.Text.ToString());
                credits.Amount = double.Parse(txtCreditAmount.Text.ToString());
                credits.Rate = double.Parse(txtCreditRate.Text.ToString());
                credits.Name = txtCreditName.Text.ToString();
                credits.Fee = double.Parse(txtCreditFee.Text.ToString());
                credits.StartDate = DateTime.Parse(CreditStartDate.Value.ToString());
                credits.Status = ComboBoxStatus.SelectedItem.ToString();
                credits.OperationalBalance = double.Parse(txtOperationalBalance.Text.ToString());
                credits.FK_CUSTOMER_ID = txtFkCustomerId.Text.ToString();

                mngCre.Update(credits);

                dataGridCredits.Rows.Clear();
                dataGridCustomers.Rows.Clear();

                CreditsForm_Load(null, null);


                MessageBox.Show("Hey updated here my man");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Missing Values" + ex);
            }
        }

        private void DataGridCredits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                DataGridViewRow rows = this.dataGridCredits.Rows[e.RowIndex];
                txtCreditId.Text = rows.Cells["CREDIT_ID"].Value.ToString();

                txtCreditAmount.Text = rows.Cells["AMOUNT"].Value.ToString();
                txtCreditRate.Text = rows.Cells["RATE"].Value.ToString();
                txtCreditName.Text = rows.Cells["NAME1"].Value.ToString();

                

                DateTime creStartDate= DateTime.Parse(rows.Cells["START_DATE"].Value.ToString());

                CreditStartDate.Value = creStartDate;

                txtCreditFee.Text = rows.Cells["FEE"].Value.ToString();
                ComboBoxStatus.SelectedIndex = ComboBoxStatus.FindStringExact(rows.Cells["STATUS"].Value.ToString());
                txtOperationalBalance.Text = rows.Cells["OPERATIONAL_BALANCE"].Value.ToString();
                txtFkCustomerId.Text = rows.Cells["FK_CUSTOMER_ID"].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                credits.CreditId = Int32.Parse(txtCreditId.Text.ToString());

                mngCre.Delete(credits);

                MessageBox.Show("Credit Deleted ");

                dataGridCredits.Rows.Clear();
                dataGridCustomers.Rows.Clear();

                CreditsForm_Load(null, null);

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Credit do not exist " + ex.ToString());
            }
        }
    }
}
