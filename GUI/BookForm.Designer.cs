
namespace HiTechDistributionInc.GUI
{
    partial class BookForm
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
            this.labelIsbn = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxAuthors = new System.Windows.Forms.GroupBox();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.numericUpDownYearPublished = new System.Windows.Forms.NumericUpDown();
            this.labelYearPublished = new System.Windows.Forms.Label();
            this.numericUpDownEdition = new System.Windows.Forms.NumericUpDown();
            this.labelEdition = new System.Windows.Forms.Label();
            this.numericUpDownUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.textBoxFilterBook = new System.Windows.Forms.TextBox();
            this.buttonFilterBooks = new System.Windows.Forms.Button();
            this.labelFilterBook = new System.Windows.Forms.Label();
            this.buttonListAllBooks = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBoxAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearPublished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(29, 34);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(66, 25);
            this.labelIsbn.TabIndex = 0;
            this.labelIsbn.Text = "ISBN:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(419, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(155, 34);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(207, 31);
            this.textBoxIsbn.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(496, 31);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(266, 31);
            this.textBoxTitle.TabIndex = 3;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(155, 91);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(207, 33);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(29, 91);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(105, 25);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Category:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(617, 604);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 70);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(399, 604);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(196, 70);
            this.buttonReset.TabIndex = 22;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxAuthors
            // 
            this.groupBoxAuthors.Controls.Add(this.comboBoxAuthor);
            this.groupBoxAuthors.Controls.Add(this.labelAuthor);
            this.groupBoxAuthors.Controls.Add(this.buttonAddAuthor);
            this.groupBoxAuthors.Controls.Add(this.buttonDeleteAuthor);
            this.groupBoxAuthors.Controls.Add(this.dataGridViewAuthors);
            this.groupBoxAuthors.Location = new System.Drawing.Point(34, 253);
            this.groupBoxAuthors.Name = "groupBoxAuthors";
            this.groupBoxAuthors.Size = new System.Drawing.Size(779, 290);
            this.groupBoxAuthors.TabIndex = 23;
            this.groupBoxAuthors.TabStop = false;
            this.groupBoxAuthors.Text = "Authors";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(106, 47);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(177, 33);
            this.comboBoxAuthor.TabIndex = 15;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(16, 47);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(81, 25);
            this.labelAuthor.TabIndex = 16;
            this.labelAuthor.Text = "Author:";
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(14, 109);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(196, 70);
            this.buttonAddAuthor.TabIndex = 14;
            this.buttonAddAuthor.Text = "Add Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(14, 185);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(196, 70);
            this.buttonDeleteAuthor.TabIndex = 13;
            this.buttonDeleteAuthor.Text = "Delete Author";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.buttonDeleteAuthor_Click);
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AllowUserToAddRows = false;
            this.dataGridViewAuthors.AllowUserToDeleteRows = false;
            this.dataGridViewAuthors.AllowUserToOrderColumns = true;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(321, 47);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.RowHeadersWidth = 82;
            this.dataGridViewAuthors.RowTemplate.Height = 33;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(427, 208);
            this.dataGridViewAuthors.TabIndex = 0;
            this.dataGridViewAuthors.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAuthors_RowHeaderMouseClick);
            // 
            // numericUpDownYearPublished
            // 
            this.numericUpDownYearPublished.Location = new System.Drawing.Point(613, 89);
            this.numericUpDownYearPublished.Name = "numericUpDownYearPublished";
            this.numericUpDownYearPublished.Size = new System.Drawing.Size(149, 31);
            this.numericUpDownYearPublished.TabIndex = 25;
            // 
            // labelYearPublished
            // 
            this.labelYearPublished.AutoSize = true;
            this.labelYearPublished.Location = new System.Drawing.Point(419, 91);
            this.labelYearPublished.Name = "labelYearPublished";
            this.labelYearPublished.Size = new System.Drawing.Size(165, 25);
            this.labelYearPublished.TabIndex = 24;
            this.labelYearPublished.Text = "Year Published:";
            // 
            // numericUpDownEdition
            // 
            this.numericUpDownEdition.Location = new System.Drawing.Point(613, 141);
            this.numericUpDownEdition.Name = "numericUpDownEdition";
            this.numericUpDownEdition.Size = new System.Drawing.Size(149, 31);
            this.numericUpDownEdition.TabIndex = 27;
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Location = new System.Drawing.Point(419, 143);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(84, 25);
            this.labelEdition.TabIndex = 26;
            this.labelEdition.Text = "Edition:";
            // 
            // numericUpDownUnitPrice
            // 
            this.numericUpDownUnitPrice.DecimalPlaces = 2;
            this.numericUpDownUnitPrice.Location = new System.Drawing.Point(613, 194);
            this.numericUpDownUnitPrice.Name = "numericUpDownUnitPrice";
            this.numericUpDownUnitPrice.Size = new System.Drawing.Size(149, 31);
            this.numericUpDownUnitPrice.TabIndex = 29;
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(419, 196);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(111, 25);
            this.labelUnitPrice.TabIndex = 28;
            this.labelUnitPrice.Text = "Unit Price:";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(29, 147);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(108, 25);
            this.labelPublisher.TabIndex = 30;
            this.labelPublisher.Text = "Publisher:";
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(155, 144);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(207, 33);
            this.comboBoxPublisher.TabIndex = 17;
            // 
            // textBoxFilterBook
            // 
            this.textBoxFilterBook.Location = new System.Drawing.Point(104, 758);
            this.textBoxFilterBook.Name = "textBoxFilterBook";
            this.textBoxFilterBook.Size = new System.Drawing.Size(253, 31);
            this.textBoxFilterBook.TabIndex = 42;
            // 
            // buttonFilterBooks
            // 
            this.buttonFilterBooks.Location = new System.Drawing.Point(399, 733);
            this.buttonFilterBooks.Name = "buttonFilterBooks";
            this.buttonFilterBooks.Size = new System.Drawing.Size(196, 70);
            this.buttonFilterBooks.TabIndex = 41;
            this.buttonFilterBooks.Text = "Filter Books";
            this.buttonFilterBooks.UseVisualStyleBackColor = true;
            this.buttonFilterBooks.Click += new System.EventHandler(this.buttonFilterBooks_Click);
            // 
            // labelFilterBook
            // 
            this.labelFilterBook.AutoSize = true;
            this.labelFilterBook.Location = new System.Drawing.Point(24, 761);
            this.labelFilterBook.Name = "labelFilterBook";
            this.labelFilterBook.Size = new System.Drawing.Size(59, 25);
            this.labelFilterBook.TabIndex = 40;
            this.labelFilterBook.Text = "Title:";
            // 
            // buttonListAllBooks
            // 
            this.buttonListAllBooks.Location = new System.Drawing.Point(617, 733);
            this.buttonListAllBooks.Name = "buttonListAllBooks";
            this.buttonListAllBooks.Size = new System.Drawing.Size(196, 70);
            this.buttonListAllBooks.TabIndex = 39;
            this.buttonListAllBooks.Text = "List All Books";
            this.buttonListAllBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBooks.Click += new System.EventHandler(this.buttonListAllBooks_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(29, 820);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 82;
            this.dataGridViewBooks.RowTemplate.Height = 33;
            this.dataGridViewBooks.Size = new System.Drawing.Size(784, 261);
            this.dataGridViewBooks.TabIndex = 38;
            this.dataGridViewBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBooks_RowHeaderMouseClick);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 1117);
            this.Controls.Add(this.textBoxFilterBook);
            this.Controls.Add(this.buttonFilterBooks);
            this.Controls.Add(this.labelFilterBook);
            this.Controls.Add(this.buttonListAllBooks);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.comboBoxPublisher);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.numericUpDownUnitPrice);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.numericUpDownEdition);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.numericUpDownYearPublished);
            this.Controls.Add(this.labelYearPublished);
            this.Controls.Add(this.groupBoxAuthors);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxIsbn);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelIsbn);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBook";
            this.Load += new System.EventHandler(this.CreateBook_Load);
            this.groupBoxAuthors.ResumeLayout(false);
            this.groupBoxAuthors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearPublished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxAuthors;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.NumericUpDown numericUpDownYearPublished;
        private System.Windows.Forms.Label labelYearPublished;
        private System.Windows.Forms.NumericUpDown numericUpDownEdition;
        private System.Windows.Forms.Label labelEdition;
        private System.Windows.Forms.NumericUpDown numericUpDownUnitPrice;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.TextBox textBoxFilterBook;
        private System.Windows.Forms.Button buttonFilterBooks;
        private System.Windows.Forms.Label labelFilterBook;
        private System.Windows.Forms.Button buttonListAllBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
    }
}