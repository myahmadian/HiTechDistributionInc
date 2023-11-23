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
    public partial class UserAccountForm : Form
    {
        private UserAccount _userAccount;

        public UserAccountForm()
        {
            InitializeComponent();
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {
            BindEmployees();
            BindRoles();
            ResetUserAccounts();
        }

        private void BindEmployees()
        {
            var employeeDb = new EmployeeDb();
            var employees = employeeDb.GetAll();
            comboBoxEmployee.DataSource = employees;
            comboBoxEmployee.DisplayMember = "Name";
            comboBoxEmployee.ValueMember = "Id";
        }

        private void BindRoles()
        {
            var roleDb = new RoleDb();
            var roles = roleDb.GetAll();
            comboBoxRole.DataSource = roles;
            comboBoxRole.DisplayMember = "Title";
            comboBoxRole.ValueMember = "Id";
        }

        private void BindUserAccount()
        {
            textBoxUsername.Text = _userAccount.Username;
            textBoxPassword.Text = _userAccount.Password;
            if (_userAccount.Employee != null)
            {
                comboBoxEmployee.SelectedValue = _userAccount.Employee.Id;
            }
            if (_userAccount.Role != null)
            {
                comboBoxRole.SelectedValue = _userAccount.Role.Id;
            }
        }

        private void ResetUserAccount()
        {
            _userAccount = new UserAccount();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            comboBoxEmployee.SelectedIndex = -1;
            comboBoxRole.SelectedIndex = -1;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetUserAccounts();
        }

        private void ResetUserAccounts()
        {
            textBoxFilterUserAccount.Clear();
            dataGridViewUserAccounts.DataSource = null;
            ResetUserAccount();
            BindUserAccount();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PrepareUserAccount();

            var validator = new UserAccountValidator();
            var error = validator.Validate(_userAccount);

            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userAccountDb = new UserAccountDb();
            userAccountDb.Save(_userAccount);

            ResetUserAccounts();
        }

        private void PrepareUserAccount()
        {
            _userAccount.Username = textBoxUsername.Text;
            _userAccount.Password = textBoxPassword.Text;
            if (comboBoxEmployee.SelectedValue != null)
            {
                var employeeDb = new EmployeeDb();
                var employeeId = (int)comboBoxEmployee.SelectedValue;
                var employee = employeeDb.GetById(employeeId);
                _userAccount.Employee = employee;
            }
            if (comboBoxRole.SelectedValue != null)
            {
                var roleDb = new RoleDb();
                var roleId = (int)comboBoxRole.SelectedValue;
                var role = roleDb.GetById(roleId);
                _userAccount.Role = role;
            }
        }

        private void buttonFilterUserAccounts_Click(object sender, EventArgs e)
        {
            var userAccountDb = new UserAccountDb();
            var userAccounts = userAccountDb.GetUserAccountsByFilter(textBoxFilterUserAccount.Text);
            BindUserAccounts(userAccounts);
        }

        private void BindUserAccounts(List<UserAccount> userAccounts)
        {
            dataGridViewUserAccounts.DataSource = userAccounts;

            dataGridViewUserAccounts.Columns["Id"].Visible = false;
            dataGridViewUserAccounts.Columns["Username"].ReadOnly = true;
            dataGridViewUserAccounts.Columns["password"].Visible = false;
            dataGridViewUserAccounts.Columns["Employee"].ReadOnly = true;
            dataGridViewUserAccounts.Columns["Role"].ReadOnly = true;
        }

        private void dataGridViewUserAccounts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var userAccountId = Convert.ToInt32(dataGridViewUserAccounts.Rows[e.RowIndex].Cells["Id"].Value);
            var userAccountDb = new UserAccountDb();
            _userAccount = userAccountDb.GetById(userAccountId);

            BindUserAccount();
        }

        private void buttonListAllUserAccounts_Click(object sender, EventArgs e)
        {
            var userAccountDb = new UserAccountDb();
            var userAccounts = userAccountDb.GetAll();
            BindUserAccounts(userAccounts);
        }
    }
}
