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
    public partial class RoleForm : Form
    {
        private Role _role;

        public RoleForm()
        {
            InitializeComponent();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            ResetRoles();
        }
        private void BindRole()
        {
            textBoxTitle.Text = _role.Title;
        }

        private void ResetRole()
        {
            _role = new Role();
            textBoxTitle.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetRoles();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PrepareRole();

            var validator = new RoleValidator();
            var error = validator.Validate(_role);

            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var roleDb = new RoleDb();
            roleDb.Save(_role);

            ResetRoles();
        }

        private void ResetRoles()
        {
            textBoxFilterRole.Clear();
            dataGridViewRoles.DataSource = null;
            ResetRole();
            BindRole();
        }

        private void PrepareRole()
        {
            _role.Title = textBoxTitle.Text;
        }

        private void buttonFilterRole_Click(object sender, EventArgs e)
        {
            var roleDb = new RoleDb();
            var roles = roleDb.GetRolesByFilter(textBoxFilterRole.Text);
            BindRoles(roles);
        }

        private void BindRoles(List<Role> roles)
        {
            dataGridViewRoles.DataSource = roles;

            dataGridViewRoles.Columns["Id"].Visible = false;
            dataGridViewRoles.Columns["IsNew"].Visible = false;
            dataGridViewRoles.Columns["Title"].ReadOnly = true;
        }

        private void buttonListAllRoles_Click(object sender, EventArgs e)
        {
            var roleDb = new RoleDb();
            var roles = roleDb.GetAll();
            BindRoles(roles);
        }

        private void dataGridViewRoles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var roleId = Convert.ToInt32(dataGridViewRoles.Rows[e.RowIndex].Cells["Id"].Value);
            var roleDb = new RoleDb();
            _role = roleDb.GetById(roleId);

            BindRole();
        }
    }
}
