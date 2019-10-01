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

    public partial class cxForm : MetroFramework.Forms.MetroForm
    {
        cxForm pcxForm;
        Customer cx = new Customer();
        CustomerManagement mng = new CustomerManagement();
        public cxForm()
        {
            InitializeComponent();
        }

        private void CxForm_Load(object sender, EventArgs e)
        {
            var lstCustomers = mng.RetrieveAll();
            var count = 0;
            foreach (var c in lstCustomers)
            {
                count++;
                
                dataGridView1.Rows.Add(c.Id,c.Name,c.LastName,c.Age,c.BornDate,c.CivilStatus,c.Gender);
            }

        }

        private void MetroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var info = txtCustomerId.Text.ToString() + ',' + txtCustomerName.Text.ToString() +','+txtCustomerLastName.Text.ToString()+ ',' + numericCustomerAge.Value.ToString() + ',' + DateTimeCustomer.Value.ToString("yyyy-MM-dd") + ',' + CivilComboBoxCustomer.SelectedItem.ToString() + ',' + GenderComboBoxCustomer.SelectedItem.ToString();
                var infoArray = info.Split(',');
                cx = new Customer(infoArray);
                mng.Create(cx);
                MessageBox.Show("Customer created");
                
            }
            catch (Exception es)
            {

                throw;
            }
            

           


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                DataGridViewRow rows = this.dataGridView1.Rows[e.RowIndex];
                txtCustomerId.Text = rows.Cells["Id"].Value.ToString();
                
                txtCustomerName.Text = rows.Cells["Name"].Value.ToString();
                txtCustomerLastName.Text = rows.Cells["LAST_NAME"].Value.ToString();
                int age = Int32.Parse(rows.Cells["AGE"].Value.ToString());
                numericCustomerAge.Value = age;

                DateTime cxDateBorn = DateTime.Parse(rows.Cells["BORN_DATE"].Value.ToString());

                DateTimeCustomer.Value = cxDateBorn;

                CivilComboBoxCustomer.SelectedIndex = CivilComboBoxCustomer.FindStringExact(rows.Cells["CIVIL_STATUS"].Value.ToString());
                GenderComboBoxCustomer.SelectedIndex = GenderComboBoxCustomer.FindStringExact(rows.Cells["GENDER"].Value.ToString());
            }
           

            



        }

        //private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex == -1)
        //    {
        //        txtCustomerId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    }
        //}
        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            cx.Id = txtCustomerId.Text.ToString();
            cx.Name = txtCustomerName.Text.ToString();
            cx.LastName = txtCustomerLastName.Text.ToString();
            cx.Age = Int32.Parse(numericCustomerAge.Value.ToString());
            cx.BornDate = DateTime.Parse(DateTimeCustomer.Value.ToString("yyyy-MM-dd"));
            cx.CivilStatus = CivilComboBoxCustomer.SelectedItem.ToString();
            cx.Gender = GenderComboBoxCustomer.SelectedItem.ToString();

            mng.Update(cx);

            dataGridView1.Rows.Clear();

            CxForm_Load(null, null);

            MessageBox.Show("Customer was updated");
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                cx.Id = txtCustomerId.Text.ToString();

                mng.Delete(cx);

                MessageBox.Show("Customer Deleted ");

            }
            catch (SqlException ex) 
            {

                MessageBox.Show("Please delete the credits,addresses,accounts associated " + ex.ToString());
            }
            
        }
    }
}
