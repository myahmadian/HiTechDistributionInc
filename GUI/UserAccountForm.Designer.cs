
namespace HiTechDistributionInc.GUI
{
    partial class UserAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEmployee = new System.Windows.Forms.Label();
            this.textBoxFilterUserAccount = new System.Windows.Forms.TextBox();
            this.buttonFilterUserAccounts = new System.Windows.Forms.Button();
            this.labelFilterUserAccount = new System.Windows.Forms.Label();
            this.buttonListAllUserAccounts = new System.Windows.Forms.Button();
            this.dataGridViewUserAccounts = new System.Windows.Forms.DataGridView();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(22, 75);
            this.labelEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(113, 25);
            this.labelEmployee.TabIndex = 66;
            this.labelEmployee.Text = "Employee:";
            // 
            // textBoxFilterUserAccount
            // 
            this.textBoxFilterUserAccount.Location = new System.Drawing.Point(134, 317);
            this.textBoxFilterUserAccount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFilterUserAccount.Name = "textBoxFilterUserAccount";
            this.textBoxFilterUserAccount.Size = new System.Drawing.Size(220, 31);
            this.textBoxFilterUserAccount.TabIndex = 65;
            // 
            // buttonFilterUserAccounts
            // 
            this.buttonFilterUserAccounts.Location = new System.Drawing.Point(398, 294);
            this.buttonFilterUserAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFilterUserAccounts.Name = "buttonFilterUserAccounts";
            this.buttonFilterUserAccounts.Size = new System.Drawing.Size(196, 69);
            this.buttonFilterUserAccounts.TabIndex = 64;
            this.buttonFilterUserAccounts.Text = "Filter User Accounts";
            this.buttonFilterUserAccounts.UseVisualStyleBackColor = true;
            this.buttonFilterUserAccounts.Click += new System.EventHandler(this.buttonFilterUserAccounts_Click);
            // 
            // labelFilterUserAccount
            // 
            this.labelFilterUserAccount.AutoSize = true;
            this.labelFilterUserAccount.Location = new System.Drawing.Point(22, 323);
            this.labelFilterUserAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterUserAccount.Name = "labelFilterUserAccount";
            this.labelFilterUserAccount.Size = new System.Drawing.Size(116, 25);
            this.labelFilterUserAccount.TabIndex = 63;
            this.labelFilterUserAccount.Text = "Username:";
            // 
            // buttonListAllUserAccounts
            // 
            this.buttonListAllUserAccounts.Location = new System.Drawing.Point(614, 294);
            this.buttonListAllUserAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListAllUserAccounts.Name = "buttonListAllUserAccounts";
            this.buttonListAllUserAccounts.Size = new System.Drawing.Size(196, 69);
            this.buttonListAllUserAccounts.TabIndex = 62;
            this.buttonListAllUserAccounts.Text = "List All User Accounts";
            this.buttonListAllUserAccounts.UseVisualStyleBackColor = true;
            this.buttonListAllUserAccounts.Click += new System.EventHandler(this.buttonListAllUserAccounts_Click);
            // 
            // dataGridViewUserAccounts
            // 
            this.dataGridViewUserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserAccounts.Location = new System.Drawing.Point(26, 383);
            this.dataGridViewUserAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUserAccounts.Name = "dataGridViewUserAccounts";
            this.dataGridViewUserAccounts.RowHeadersWidth = 82;
            this.dataGridViewUserAccounts.RowTemplate.Height = 33;
            this.dataGridViewUserAccounts.Size = new System.Drawing.Size(784, 262);
            this.dataGridViewUserAccounts.TabIndex = 61;
            this.dataGridViewUserAccounts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUserAccounts_RowHeaderMouseClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(398, 150);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(196, 69);
            this.buttonReset.TabIndex = 59;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(614, 150);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 69);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(478, 77);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(62, 25);
            this.labelRole.TabIndex = 57;
            this.labelRole.Text = "Role:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(598, 12);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(208, 31);
            this.textBoxPassword.TabIndex = 56;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(146, 12);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(208, 31);
            this.textBoxUsername.TabIndex = 55;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(478, 17);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(112, 25);
            this.labelPassword.TabIndex = 54;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(22, 17);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(116, 25);
            this.labelUsername.TabIndex = 53;
            this.labelUsername.Text = "Username:";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(146, 71);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(208, 33);
            this.comboBoxEmployee.TabIndex = 68;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(598, 71);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(208, 33);
            this.comboBoxRole.TabIndex = 69;
            // 
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 671);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.textBoxFilterUserAccount);
            this.Controls.Add(this.buttonFilterUserAccounts);
            this.Controls.Add(this.labelFilterUserAccount);
            this.Controls.Add(this.buttonListAllUserAccounts);
            this.Controls.Add(this.dataGridViewUserAccounts);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAccountForm";
            this.Load += new System.EventHandler(this.UserAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.TextBox textBoxFilterUserAccount;
        private System.Windows.Forms.Button buttonFilterUserAccounts;
        private System.Windows.Forms.Label labelFilterUserAccount;
        private System.Windows.Forms.Button buttonListAllUserAccounts;
        private System.Windows.Forms.DataGridView dataGridViewUserAccounts;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxRole;
    }
}