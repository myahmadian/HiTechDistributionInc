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
    public partial class EmployeeForm : Form
    {
        private Employee _employee;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ResetEmployees();
        }

        private void BindEmployee()
        {
            textBoxFirstName.Text = _employee.FirstName;
            textBoxLastName.Text = _employee.LastName;
            textBoxPhoneNumber.Text = _employee.PhoneNumber;
            textBoxEmail.Text = _employee.Email;
        }

        private void ResetEmployee()
        {
            _employee = new Employee();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetEmployees();
        }

        private void ResetEmployees()
        {
            textBoxFilterEmployee.Clear();
            dataGridViewEmployees.DataSource = null;
            ResetEmployee();
            BindEmployee();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PrepareEmployee();

            var validator = new EmployeeValidator();
            var error = validator.Validate(_employee);

            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var employeeDB = new EmployeeDb();
            employeeDB.Save(_employee);

            ResetEmployees();
        }

        private void PrepareEmployee()
        {
            _employee.FirstName = textBoxFirstName.Text;
            _employee.LastName = textBoxLastName.Text;
            _employee.PhoneNumber = textBoxPhoneNumber.Text;
            _employee.Email = textBoxEmail.Text;
        }

        private void buttonFilterEmployees_Click(object sender, EventArgs e)
        {
            var employeeDb = new EmployeeDb();
            var employees = employeeDb.GetEmployeesByFilter(textBoxFilterEmployee.Text);
            BindEmployees(employees);
        }

        private void BindEmployees(List<Employee> employees)
        {
            dataGridViewEmployees.DataSource = employees;

            dataGridViewEmployees.Columns["Id"].Visible = false;
            dataGridViewEmployees.Columns["IsNew"].Visible = false;
            dataGridViewEmployees.Columns["FirstName"].Visible = false;
            dataGridViewEmployees.Columns["LastName"].Visible = false;
            dataGridViewEmployees.Columns["PhoneNumber"].Visible = true;
            dataGridViewEmployees.Columns["Name"].ReadOnly = true;
            dataGridViewEmployees.Columns["Email"].ReadOnly = true;
        }

        private void dataGridViewEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var employeeId = Convert.ToInt32(dataGridViewEmployees.Rows[e.RowIndex].Cells["Id"].Value);
            var employeeDb = new EmployeeDb();
            _employee = employeeDb.GetById(employeeId);

            BindEmployee();
        }

        private void buttonListAllEmployees_Click(object sender, EventArgs e)
        {
            var employeeDb = new EmployeeDb();
            var employees = employeeDb.GetAll();
            BindEmployees(employees);
        }
    }
}
