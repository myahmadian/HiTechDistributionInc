
namespace HiTechDistributionInc.GUI
{
    partial class PublisherForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxFilterPublisher = new System.Windows.Forms.TextBox();
            this.buttonFilterPublisher = new System.Windows.Forms.Button();
            this.labelFilterPublisher = new System.Windows.Forms.Label();
            this.buttonListAllPublishers = new System.Windows.Forms.Button();
            this.dataGridViewPublishers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(305, 60);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(98, 36);
            this.buttonReset.TabIndex = 30;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(305, 21);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 36);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(82, 21);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(193, 20);
            this.textBoxName.TabIndex = 25;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 21);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name:";
            // 
            // textBoxFilterPublisher
            // 
            this.textBoxFilterPublisher.Location = new System.Drawing.Point(48, 139);
            this.textBoxFilterPublisher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilterPublisher.Name = "textBoxFilterPublisher";
            this.textBoxFilterPublisher.Size = new System.Drawing.Size(128, 20);
            this.textBoxFilterPublisher.TabIndex = 42;
            // 
            // buttonFilterPublisher
            // 
            this.buttonFilterPublisher.Location = new System.Drawing.Point(196, 126);
            this.buttonFilterPublisher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFilterPublisher.Name = "buttonFilterPublisher";
            this.buttonFilterPublisher.Size = new System.Drawing.Size(98, 36);
            this.buttonFilterPublisher.TabIndex = 41;
            this.buttonFilterPublisher.Text = "Filter Publishers";
            this.buttonFilterPublisher.UseVisualStyleBackColor = true;
            this.buttonFilterPublisher.Click += new System.EventHandler(this.buttonFilterPublisher_Click);
            // 
            // labelFilterPublisher
            // 
            this.labelFilterPublisher.AutoSize = true;
            this.labelFilterPublisher.Location = new System.Drawing.Point(8, 140);
            this.labelFilterPublisher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterPublisher.Name = "labelFilterPublisher";
            this.labelFilterPublisher.Size = new System.Drawing.Size(38, 13);
            this.labelFilterPublisher.TabIndex = 40;
            this.labelFilterPublisher.Text = "Name:";
            // 
            // buttonListAllPublishers
            // 
            this.buttonListAllPublishers.Location = new System.Drawing.Point(305, 126);
            this.buttonListAllPublishers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonListAllPublishers.Name = "buttonListAllPublishers";
            this.buttonListAllPublishers.Size = new System.Drawing.Size(98, 36);
            this.buttonListAllPublishers.TabIndex = 39;
            this.buttonListAllPublishers.Text = "List All Publishers";
            this.buttonListAllPublishers.UseVisualStyleBackColor = true;
            this.buttonListAllPublishers.Click += new System.EventHandler(this.buttonListAllPublishers_Click);
            // 
            // dataGridViewPublishers
            // 
            this.dataGridViewPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublishers.Location = new System.Drawing.Point(11, 171);
            this.dataGridViewPublishers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPublishers.Name = "dataGridViewPublishers";
            this.dataGridViewPublishers.RowHeadersWidth = 82;
            this.dataGridViewPublishers.RowTemplate.Height = 33;
            this.dataGridViewPublishers.Size = new System.Drawing.Size(392, 136);
            this.dataGridViewPublishers.TabIndex = 38;
            this.dataGridViewPublishers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPublishers_RowHeaderMouseClick);
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 319);
            this.Controls.Add(this.textBoxFilterPublisher);
            this.Controls.Add(this.buttonFilterPublisher);
            this.Controls.Add(this.labelFilterPublisher);
            this.Controls.Add(this.buttonListAllPublishers);
            this.Controls.Add(this.dataGridViewPublishers);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PublisherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePublisher";
            this.Load += new System.EventHandler(this.CreatePublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxFilterPublisher;
        private System.Windows.Forms.Button buttonFilterPublisher;
        private System.Windows.Forms.Label labelFilterPublisher;
        private System.Windows.Forms.Button buttonListAllPublishers;
        private System.Windows.Forms.DataGridView dataGridViewPublishers;
    }
}