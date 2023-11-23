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
    public partial class MainForm : Form
    {
        private UserAccount _user;

        public MainForm()
        {
            InitializeComponent();
            ResetForm();
            Authorize();
        }

        private void roleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var roleForm = new RoleForm();
            roleForm.ShowDialog(this);
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewOrders = new OrderForm();
            viewOrders.ShowDialog(this);
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm();
            inventoryForm.ShowDialog(this);
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var publisherForm = new PublisherForm();
            publisherForm.ShowDialog(this);
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var authorForm = new AuthorForm();
            authorForm.ShowDialog(this);
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookForm = new BookForm();
            bookForm.ShowDialog(this);
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.ShowDialog(this);
        }

        private void userAcountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userAccountForm = new UserAccountForm();
            userAccountForm.ShowDialog(this);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            customerForm.ShowDialog(this);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var userAccountDb = new UserAccountDb();
            _user = userAccountDb.GetByUserName(textBoxUsername.Text);
            if (_user == null)
            {
                MessageBox.Show("Username is invalid", "Sign in error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_user.Password != textBoxPassword.Text)
            {
                MessageBox.Show("Password is invalid", "Sign in error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ResetForm();
            Authorize();
        }

        private void buttonSignout_Click(object sender, EventArgs e)
        {
            _user = null;
            Authorize();
            ResetForm();
        }

        private void ResetForm()
        {
            if (_user != null)
            {
                labelLoginUser.Text = $"{_user.Employee.Name} signed in as {_user.Role.Title}";
                buttonSignIn.Visible = false;
                buttonSignout.Visible = true;
            }
            else
            {
                labelLoginUser.Text = "";
                buttonSignIn.Visible = true;
                buttonSignout.Visible = false;
            }
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }

        private void Authorize()
        {
            if (_user == null)
            {
                RevokeAuthorization();
                return;
            }
            if (_user.Role.Title == Role.MIS_MANAGER_ROLE)
            {
                AuthorizeMisManager();
                return;
            }
            if (_user.Role.Title == Role.SALES_MANAGER_ROLE)
            {
                AuthorizeSalesManager();
                return;
            }
            if (_user.Role.Title == Role.INVENTORY_MANAGER_ROLE)
            {
                AuthorizeInventoryManager();
                return;
            }
            if (_user.Role.Title == Role.ORDER_CLERK_ROLE)
            {
                AuthorizeOrderClerk();
                return;
            }
            AuthorizeAccountant();
        }

        private void AuthorizeAccountant()
        {
            orderToolStripMenuItem.Visible = false;
            customerToolStripMenuItem.Visible = false;
            inventoryToolStripMenuItem.Visible = false;
            publisherToolStripMenuItem.Visible = false;
            authorToolStripMenuItem.Visible = false;
            bookToolStripMenuItem.Visible = false;
            organizationToolStripMenuItem.Visible = false;
            invoiceToolStripMenuItem.Visible = true;
        }

        private void AuthorizeOrderClerk()
        {
            orderToolStripMenuItem.Visible = true;
            customerToolStripMenuItem.Visible = false;
            inventoryToolStripMenuItem.Visible = false;
            publisherToolStripMenuItem.Visible = false;
            authorToolStripMenuItem.Visible = false;
            bookToolStripMenuItem.Visible = false;
            organizationToolStripMenuItem.Visible = false;
            invoiceToolStripMenuItem.Visible = false;
        }

        private void AuthorizeInventoryManager()
        {
            orderToolStripMenuItem.Visible = false;
            customerToolStripMenuItem.Visible = false;
            inventoryToolStripMenuItem.Visible = true;
            publisherToolStripMenuItem.Visible = true;
            authorToolStripMenuItem.Visible = true;
            bookToolStripMenuItem.Visible = true;
            organizationToolStripMenuItem.Visible = false;
            invoiceToolStripMenuItem.Visible = false;
        }

        private void AuthorizeSalesManager()
        {
            orderToolStripMenuItem.Visible = false;
            customerToolStripMenuItem.Visible = true;
            inventoryToolStripMenuItem.Visible = false;
            publisherToolStripMenuItem.Visible = false;
            authorToolStripMenuItem.Visible = false;
            bookToolStripMenuItem.Visible = false;
            organizationToolStripMenuItem.Visible = false;
            invoiceToolStripMenuItem.Visible = false;
        }

        private void AuthorizeMisManager()
        {
            orderToolStripMenuItem.Visible = false;
            customerToolStripMenuItem.Visible = false;
            inventoryToolStripMenuItem.Visible = false;
            publisherToolStripMenuItem.Visible = false;
            authorToolStripMenuItem.Visible = false;
            bookToolStripMenuItem.Visible = false;
            organizationToolStripMenuItem.Visible = true;
            invoiceToolStripMenuItem.Visible = false;
        }

        private void RevokeAuthorization()
        {
            orderToolStripMenuItem.Visible = false;
            customerToolStripMenuItem.Visible = false;
            inventoryToolStripMenuItem.Visible = false;
            publisherToolStripMenuItem.Visible = false;
            authorToolStripMenuItem.Visible = false;
            bookToolStripMenuItem.Visible = false;
            organizationToolStripMenuItem.Visible = false;
            invoiceToolStripMenuItem.Visible = false;
        }
    }
}
