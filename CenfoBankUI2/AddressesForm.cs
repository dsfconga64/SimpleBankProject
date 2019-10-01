using ConsoleApp1;
using Entities_POJO;
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
    public partial class AddressesForm : MetroFramework.Forms.MetroForm
    {
        AddressManagement addressManagement = new AddressManagement();
        Address address = new Address();
        CustomerManagement customerManagement = new CustomerManagement();
        public AddressesForm()
        {
            InitializeComponent();
        }

        private void AddressesForm_Load(object sender, EventArgs e)
        {
            var lstAddresses = addressManagement.RetrieveAll();
            var count1 = 0;

            foreach (var b in lstAddresses)
            {
                count1++;
                dataGridAddresses.Rows.Add(b.AddresId, b.Province, b.Town, b.District, b.Fk_Customer_ID);
            }
            var lstCustomers = customerManagement.RetrieveAll();
            var count = 0;

            foreach (var c in lstCustomers)
            {
                count++;

                dataGridCustomers.Rows.Add(c.Id, c.Name);
            }
        }

        private void BtnAddAdress_Click(object sender, EventArgs e)
        {
            try
            {
                var info = txtProvince.Text.ToString() + ',' + txtTown.Text.ToString() + ',' + txtDisctrict.Text.ToString() + ',' + txtCustomerId.Text.ToString();
                var infoArray = info.Split(',');
                address = new Address(infoArray);
                addressManagement.Create(address);

                MessageBox.Show("Address added");

            }
            catch (Exception es)
            {

                MessageBox.Show("Values missing or entered wrong" + es);
            }
        }

        private void DataGridAddresses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= -1)
            {
                DataGridViewRow rows = this.dataGridAddresses.Rows[e.RowIndex];
                txtAddressId.Text = rows.Cells["ADDRESS_ID"].Value.ToString();
                txtProvince.Text = rows.Cells["PROVINCE"].Value.ToString();
                txtTown.Text = rows.Cells["TOWN"].Value.ToString();
                txtDisctrict.Text = rows.Cells["DISCTRICT"].Value.ToString();
                txtCustomerId.Text = rows.Cells["FK_CUSTOMER_ID"].Value.ToString();
            }

        }

        private void DataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                DataGridViewRow rows = this.dataGridCustomers.Rows[e.RowIndex];
                txtCustomerId.Text = rows.Cells["ID"].Value.ToString();

            }
        }

        private void BtnUpdateAdress_Click(object sender, EventArgs e)
        {
            try
            {
                address.AddresId = Int32.Parse(txtAddressId.Text.ToString());
                address.Province = txtProvince.Text.ToString();
                address.Town = txtTown.Text.ToString();
                address.District = txtDisctrict.Text.ToString();
                address.Fk_Customer_ID = txtCustomerId.Text.ToString();

                addressManagement.Update(address);

                dataGridAddresses.Rows.Clear();
                dataGridCustomers.Rows.Clear();

                AddressesForm_Load(null, null);


                MessageBox.Show("Hey updated here my man");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDeleteAddress_Click(object sender, EventArgs e)
        {
            address.AddresId = Int32.Parse(txtAddressId.Text.ToString());

            addressManagement.Delete(address);

            MessageBox.Show("Credit Deleted ");

            dataGridAddresses.Rows.Clear();
            dataGridCustomers.Rows.Clear();

            AddressesForm_Load(null, null);
        }
    }
}
