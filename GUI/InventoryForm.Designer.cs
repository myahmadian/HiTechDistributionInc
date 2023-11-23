
namespace HiTechDistributionInc.GUI
{
    partial class InventoryForm
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
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.labelBook = new System.Windows.Forms.Label();
            this.numericUpDownQuantityOnHand = new System.Windows.Forms.NumericUpDown();
            this.labelQuantityOnHand = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityOnHand)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(136, 45);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(264, 33);
            this.comboBoxBook.TabIndex = 17;
            this.comboBoxBook.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBook_SelectionChangeCommitted);
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(46, 48);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(67, 25);
            this.labelBook.TabIndex = 18;
            this.labelBook.Text = "Book:";
            // 
            // numericUpDownQuantityOnHand
            // 
            this.numericUpDownQuantityOnHand.Location = new System.Drawing.Point(666, 45);
            this.numericUpDownQuantityOnHand.Name = "numericUpDownQuantityOnHand";
            this.numericUpDownQuantityOnHand.Size = new System.Drawing.Size(149, 31);
            this.numericUpDownQuantityOnHand.TabIndex = 31;
            // 
            // labelQuantityOnHand
            // 
            this.labelQuantityOnHand.AutoSize = true;
            this.labelQuantityOnHand.Location = new System.Drawing.Point(457, 48);
            this.labelQuantityOnHand.Name = "labelQuantityOnHand";
            this.labelQuantityOnHand.Size = new System.Drawing.Size(185, 25);
            this.labelQuantityOnHand.TabIndex = 30;
            this.labelQuantityOnHand.Text = "Quantity on Hand:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(401, 176);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(196, 70);
            this.buttonReset.TabIndex = 33;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(619, 176);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 70);
            this.buttonSave.TabIndex = 32;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // CreateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 297);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownQuantityOnHand);
            this.Controls.Add(this.labelQuantityOnHand);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.labelBook);
            this.Name = "CreateInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateInventory";
            this.Load += new System.EventHandler(this.CreateInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityOnHand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantityOnHand;
        private System.Windows.Forms.Label labelQuantityOnHand;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
    }
}