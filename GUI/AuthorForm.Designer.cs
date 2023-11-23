
namespace HiTechDistributionInc.GUI
{
    partial class AuthorForm
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxIFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.buttonListAllAuthors = new System.Windows.Forms.Button();
            this.buttonFilterAuthors = new System.Windows.Forms.Button();
            this.labelFilterAuthor = new System.Windows.Forms.Label();
            this.textBoxFilterAuthor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(403, 176);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(196, 70);
            this.buttonReset.TabIndex = 30;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(621, 176);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 70);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(28, 96);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 25);
            this.labelEmail.TabIndex = 28;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(558, 36);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(259, 31);
            this.textBoxLastName.TabIndex = 26;
            // 
            // textBoxIFirstName
            // 
            this.textBoxIFirstName.Location = new System.Drawing.Point(154, 39);
            this.textBoxIFirstName.Name = "textBoxIFirstName";
            this.textBoxIFirstName.Size = new System.Drawing.Size(207, 31);
            this.textBoxIFirstName.TabIndex = 25;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(418, 39);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(121, 25);
            this.labelLastName.TabIndex = 24;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(28, 39);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(122, 25);
            this.labelFirstName.TabIndex = 23;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(154, 96);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(207, 31);
            this.textBoxEmail.TabIndex = 31;
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(33, 409);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.RowHeadersWidth = 82;
            this.dataGridViewAuthors.RowTemplate.Height = 33;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(784, 261);
            this.dataGridViewAuthors.TabIndex = 32;
            this.dataGridViewAuthors.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAuthors_RowHeaderMouseClick);
            // 
            // buttonListAllAuthors
            // 
            this.buttonListAllAuthors.Location = new System.Drawing.Point(621, 322);
            this.buttonListAllAuthors.Name = "buttonListAllAuthors";
            this.buttonListAllAuthors.Size = new System.Drawing.Size(196, 70);
            this.buttonListAllAuthors.TabIndex = 33;
            this.buttonListAllAuthors.Text = "List All Authors";
            this.buttonListAllAuthors.UseVisualStyleBackColor = true;
            this.buttonListAllAuthors.Click += new System.EventHandler(this.buttonListAllAuthors_Click);
            // 
            // buttonFilterAuthors
            // 
            this.buttonFilterAuthors.Location = new System.Drawing.Point(403, 322);
            this.buttonFilterAuthors.Name = "buttonFilterAuthors";
            this.buttonFilterAuthors.Size = new System.Drawing.Size(196, 70);
            this.buttonFilterAuthors.TabIndex = 36;
            this.buttonFilterAuthors.Text = "Filter Authors";
            this.buttonFilterAuthors.UseVisualStyleBackColor = true;
            this.buttonFilterAuthors.Click += new System.EventHandler(this.buttonFilterAuthors_Click);
            // 
            // labelFilterAuthor
            // 
            this.labelFilterAuthor.AutoSize = true;
            this.labelFilterAuthor.Location = new System.Drawing.Point(28, 350);
            this.labelFilterAuthor.Name = "labelFilterAuthor";
            this.labelFilterAuthor.Size = new System.Drawing.Size(74, 25);
            this.labelFilterAuthor.TabIndex = 34;
            this.labelFilterAuthor.Text = "Name:";
            // 
            // textBoxFilterAuthor
            // 
            this.textBoxFilterAuthor.Location = new System.Drawing.Point(108, 347);
            this.textBoxFilterAuthor.Name = "textBoxFilterAuthor";
            this.textBoxFilterAuthor.Size = new System.Drawing.Size(253, 31);
            this.textBoxFilterAuthor.TabIndex = 37;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 705);
            this.Controls.Add(this.textBoxFilterAuthor);
            this.Controls.Add(this.buttonFilterAuthors);
            this.Controls.Add(this.labelFilterAuthor);
            this.Controls.Add(this.buttonListAllAuthors);
            this.Controls.Add(this.dataGridViewAuthors);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxIFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxIFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.Button buttonListAllAuthors;
        private System.Windows.Forms.Button buttonFilterAuthors;
        private System.Windows.Forms.Label labelFilterAuthor;
        private System.Windows.Forms.TextBox textBoxFilterAuthor;
    }
}