
namespace HiTechDistributionInc.GUI
{
    partial class RoleForm
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
            this.textBoxFilterRole = new System.Windows.Forms.TextBox();
            this.buttonFilterRole = new System.Windows.Forms.Button();
            this.labelFilterRole = new System.Windows.Forms.Label();
            this.buttonListAllRoles = new System.Windows.Forms.Button();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFilterRole
            // 
            this.textBoxFilterRole.Location = new System.Drawing.Point(96, 265);
            this.textBoxFilterRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterRole.Name = "textBoxFilterRole";
            this.textBoxFilterRole.Size = new System.Drawing.Size(252, 31);
            this.textBoxFilterRole.TabIndex = 51;
            // 
            // buttonFilterRole
            // 
            this.buttonFilterRole.Location = new System.Drawing.Point(392, 240);
            this.buttonFilterRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFilterRole.Name = "buttonFilterRole";
            this.buttonFilterRole.Size = new System.Drawing.Size(196, 69);
            this.buttonFilterRole.TabIndex = 50;
            this.buttonFilterRole.Text = "Filter Roles";
            this.buttonFilterRole.UseVisualStyleBackColor = true;
            this.buttonFilterRole.Click += new System.EventHandler(this.buttonFilterRole_Click);
            // 
            // labelFilterRole
            // 
            this.labelFilterRole.AutoSize = true;
            this.labelFilterRole.Location = new System.Drawing.Point(16, 267);
            this.labelFilterRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterRole.Name = "labelFilterRole";
            this.labelFilterRole.Size = new System.Drawing.Size(59, 25);
            this.labelFilterRole.TabIndex = 49;
            this.labelFilterRole.Text = "Title:";
            // 
            // buttonListAllRoles
            // 
            this.buttonListAllRoles.Location = new System.Drawing.Point(610, 240);
            this.buttonListAllRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListAllRoles.Name = "buttonListAllRoles";
            this.buttonListAllRoles.Size = new System.Drawing.Size(196, 69);
            this.buttonListAllRoles.TabIndex = 48;
            this.buttonListAllRoles.Text = "List All Roles";
            this.buttonListAllRoles.UseVisualStyleBackColor = true;
            this.buttonListAllRoles.Click += new System.EventHandler(this.buttonListAllRoles_Click);
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.Location = new System.Drawing.Point(22, 327);
            this.dataGridViewRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.RowHeadersWidth = 82;
            this.dataGridViewRoles.RowTemplate.Height = 33;
            this.dataGridViewRoles.Size = new System.Drawing.Size(784, 262);
            this.dataGridViewRoles.TabIndex = 47;
            this.dataGridViewRoles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRoles_RowHeaderMouseClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(610, 113);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(196, 69);
            this.buttonReset.TabIndex = 46;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(610, 38);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 69);
            this.buttonSave.TabIndex = 45;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(164, 38);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(382, 31);
            this.textBoxTitle.TabIndex = 44;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(36, 38);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 25);
            this.labelTitle.TabIndex = 43;
            this.labelTitle.Text = "Title:";
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 610);
            this.Controls.Add(this.textBoxFilterRole);
            this.Controls.Add(this.buttonFilterRole);
            this.Controls.Add(this.labelFilterRole);
            this.Controls.Add(this.buttonListAllRoles);
            this.Controls.Add(this.dataGridViewRoles);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoleForm";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilterRole;
        private System.Windows.Forms.Button buttonFilterRole;
        private System.Windows.Forms.Label labelFilterRole;
        private System.Windows.Forms.Button buttonListAllRoles;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
    }
}