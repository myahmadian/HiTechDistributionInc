
namespace HiTechDistributionInc.GUI
{
    partial class EmployeeForm
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
            this.textBoxFilterEmployee = new System.Windows.Forms.TextBox();
            this.buttonFilterEmployees = new System.Windows.Forms.Button();
            this.labelFilterAuthor = new System.Windows.Forms.Label();
            this.buttonListAllEmployees = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFilterEmployee
            // 
            this.textBoxFilterEmployee.Location = new System.Drawing.Point(102, 325);
            this.textBoxFilterEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterEmployee.Name = "textBoxFilterEmployee";
            this.textBoxFilterEmployee.Size = new System.Drawing.Size(252, 31);
            this.textBoxFilterEmployee.TabIndex = 50;
            // 
            // buttonFilterEmployees
            // 
            this.buttonFilterEmployees.Location = new System.Drawing.Point(398, 300);
            this.buttonFilterEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFilterEmployees.Name = "buttonFilterEmployees";
            this.buttonFilterEmployees.Size = new System.Drawing.Size(196, 69);
            this.buttonFilterEmployees.TabIndex = 49;
            this.buttonFilterEmployees.Text = "Filter Employees";
            this.buttonFilterEmployees.UseVisualStyleBackColor = true;
            this.buttonFilterEmployees.Click += new System.EventHandler(this.buttonFilterEmployees_Click);
            // 
            // labelFilterAuthor
            // 
            this.labelFilterAuthor.AutoSize = true;
            this.labelFilterAuthor.Location = new System.Drawing.Point(22, 329);
            this.labelFilterAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterAuthor.Name = "labelFilterAuthor";
            this.labelFilterAuthor.Size = new System.Drawing.Size(74, 25);
            this.labelFilterAuthor.TabIndex = 48;
            this.labelFilterAuthor.Text = "Name:";
            // 
            // buttonListAllEmployees
            // 
            this.buttonListAllEmployees.Location = new System.Drawing.Point(614, 300);
            this.buttonListAllEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListAllEmployees.Name = "buttonListAllEmployees";
            this.buttonListAllEmployees.Size = new System.Drawing.Size(196, 69);
            this.buttonListAllEmployees.TabIndex = 47;
            this.buttonListAllEmployees.Text = "List All Employees";
            this.buttonListAllEmployees.UseVisualStyleBackColor = true;
            this.buttonListAllEmployees.Click += new System.EventHandler(this.buttonListAllEmployees_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(26, 388);
            this.dataGridViewEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 82;
            this.dataGridViewEmployees.RowTemplate.Height = 33;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(784, 262);
            this.dataGridViewEmployees.TabIndex = 46;
            this.dataGridViewEmployees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmployees_RowHeaderMouseClick);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(552, 75);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(208, 31);
            this.textBoxEmail.TabIndex = 45;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(398, 156);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(196, 69);
            this.buttonReset.TabIndex = 44;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(614, 156);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 69);
            this.buttonSave.TabIndex = 43;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(412, 81);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 25);
            this.labelEmail.TabIndex = 42;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(552, 15);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(208, 31);
            this.textBoxLastName.TabIndex = 41;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(192, 17);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(208, 31);
            this.textBoxFirstName.TabIndex = 40;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(412, 21);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(121, 25);
            this.labelLastName.TabIndex = 39;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(22, 23);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(122, 25);
            this.labelFirstName.TabIndex = 38;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(190, 75);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(208, 31);
            this.textBoxPhoneNumber.TabIndex = 52;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(22, 81);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(161, 25);
            this.labelPhoneNumber.TabIndex = 51;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 675);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxFilterEmployee);
            this.Controls.Add(this.buttonFilterEmployees);
            this.Controls.Add(this.labelFilterAuthor);
            this.Controls.Add(this.buttonListAllEmployees);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilterEmployee;
        private System.Windows.Forms.Button buttonFilterEmployees;
        private System.Windows.Forms.Label labelFilterAuthor;
        private System.Windows.Forms.Button buttonListAllEmployees;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
    }
}