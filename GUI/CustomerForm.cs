using HiTechDistributionInc.BLL;
using HiTechDistributionInc.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTechDistributionInc.GUI
{
    public partial class CustomerForm : Form
    {
        private Customer _customer;
        private DataAdapterDbContext _context;

        public CustomerForm()
        {
            InitializeComponent();
            _context = new DataAdapterDbContext();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            SetElementBoundaries();
            ResetCustomers();
        }

        private void SetElementBoundaries()
        {
            numericUpDownCreditLimit.Minimum = Customer.MIN_CREDIT_LIMIT;
            numericUpDownCreditLimit.Maximum = decimal.MaxValue;
        }

        private void BindCustomer()
        {
            textBoxName.Text = _customer.Name;
            textBoxAddress.Text = _customer.Address;
            textBoxCity.Text = _customer.City;
            textBoxPostalCode.Text = _customer.PostalCode;
            textBoxPhoneNumber.Text = _customer.PhoneNumber;
            textBoxEmail.Text = _customer.Email;
            numericUpDownCreditLimit.Value = _customer.CreditLimit;
        }

        private void ResetCustomer()
        {
            _customer = new Customer();
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxCity.Clear();
            textBoxPostalCode.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            numericUpDownCreditLimit.Value = _customer.CreditLimit;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetCustomers();
        }

        private void ResetCustomers()
        {
            textBoxFilterCustomer.Clear();
            dataGridViewCustomers.DataSource = null;
            ResetCustomer();
            BindCustomer();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PrepareCustomer();

            var validator = new CustomerValidator();
            var error = validator.Validate(_customer);

            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customerDB = new CustomerDb(_context);
            customerDB.AddOrUpdate(_customer);

            ResetCustomers();
        }

        private void PrepareCustomer()
        {
            _customer.Name = textBoxName.Text;
            _customer.Address = textBoxAddress.Text;
            _customer.City = textBoxCity.Text;
            _customer.PostalCode = textBoxPostalCode.Text;
            _customer.PhoneNumber = textBoxPhoneNumber.Text;
            _customer.Email = textBoxEmail.Text;
            _customer.CreditLimit = numericUpDownCreditLimit.Value;
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            var customerDB = new CustomerDb(_context);
            customerDB.Save();
            
            ResetCustomers();
        }

        private void buttonFilterCustomers_Click(object sender, EventArgs e)
        {
            var customerDb = new CustomerDb(_context);
            var customers = customerDb.GetCustomersByFilter(textBoxFilterCustomer.Text);
            BindCustomers(customers);
        }

        private void BindCustomers(List<Customer> customers)
        {
            dataGridViewCustomers.DataSource = customers;

            dataGridViewCustomers.Columns["Id"].Visible = false;
            dataGridViewCustomers.Columns["Name"].ReadOnly = true;
            dataGridViewCustomers.Columns["Address"].ReadOnly = true;
            dataGridViewCustomers.Columns["City"].ReadOnly = true;
            dataGridViewCustomers.Columns["PostalCode"].ReadOnly = true;
            dataGridViewCustomers.Columns["PhoneNumber"].Visible = true;
            dataGridViewCustomers.Columns["Email"].ReadOnly = true;
            dataGridViewCustomers.Columns["CreditLimit"].ReadOnly = true;
        }

        private void dataGridViewCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var customerId = Convert.ToInt32(dataGridViewCustomers.Rows[e.RowIndex].Cells["Id"].Value);
            var customerDb = new CustomerDb(_context);
            _customer = customerDb.GetById(customerId);

            BindCustomer();
        }

        private void buttonListAllCustomers_Click(object sender, EventArgs e)
        {
            var customerDb = new CustomerDb(_context);
            var customers = customerDb.GetAll();
            BindCustomers(customers);
        }

        private void buttonFetchAllCustomers_Click(object sender, EventArgs e)
        {
            var customerDb = new CustomerDb(_context);
            var customers = customerDb.FetchAll();
            BindCustomers(customers);
        }
    }
}
