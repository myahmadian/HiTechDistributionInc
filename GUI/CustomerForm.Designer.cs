
namespace HiTechDistributionInc.GUI
{
    partial class CustomerForm
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
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxFilterCustomer = new System.Windows.Forms.TextBox();
            this.buttonFilterCustomers = new System.Windows.Forms.Button();
            this.labelFilterCustomer = new System.Windows.Forms.Label();
            this.buttonListAllCustomers = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCreditLimit = new System.Windows.Forms.Label();
            this.numericUpDownCreditLimit = new System.Windows.Forms.NumericUpDown();
            this.buttonPush = new System.Windows.Forms.Button();
            this.buttonFetchAllCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreditLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(192, 69);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(208, 31);
            this.textBoxCity.TabIndex = 67;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(24, 75);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(55, 25);
            this.labelCity.TabIndex = 66;
            this.labelCity.Text = "City:";
            // 
            // textBoxFilterCustomer
            // 
            this.textBoxFilterCustomer.Location = new System.Drawing.Point(104, 406);
            this.textBoxFilterCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFilterCustomer.Name = "textBoxFilterCustomer";
            this.textBoxFilterCustomer.Size = new System.Drawing.Size(252, 31);
            this.textBoxFilterCustomer.TabIndex = 65;
            // 
            // buttonFilterCustomers
            // 
            this.buttonFilterCustomers.Location = new System.Drawing.Point(400, 381);
            this.buttonFilterCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFilterCustomers.Name = "buttonFilterCustomers";
            this.buttonFilterCustomers.Size = new System.Drawing.Size(196, 69);
            this.buttonFilterCustomers.TabIndex = 64;
            this.buttonFilterCustomers.Text = "Filter Customers";
            this.buttonFilterCustomers.UseVisualStyleBackColor = true;
            this.buttonFilterCustomers.Click += new System.EventHandler(this.buttonFilterCustomers_Click);
            // 
            // labelFilterCustomer
            // 
            this.labelFilterCustomer.AutoSize = true;
            this.labelFilterCustomer.Location = new System.Drawing.Point(24, 410);
            this.labelFilterCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterCustomer.Name = "labelFilterCustomer";
            this.labelFilterCustomer.Size = new System.Drawing.Size(74, 25);
            this.labelFilterCustomer.TabIndex = 63;
            this.labelFilterCustomer.Text = "Name:";
            // 
            // buttonListAllCustomers
            // 
            this.buttonListAllCustomers.Location = new System.Drawing.Point(616, 381);
            this.buttonListAllCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListAllCustomers.Name = "buttonListAllCustomers";
            this.buttonListAllCustomers.Size = new System.Drawing.Size(196, 69);
            this.buttonListAllCustomers.TabIndex = 62;
            this.buttonListAllCustomers.Text = "List All Customers";
            this.buttonListAllCustomers.UseVisualStyleBackColor = true;
            this.buttonListAllCustomers.Click += new System.EventHandler(this.buttonListAllCustomers_Click);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(28, 469);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 82;
            this.dataGridViewCustomers.RowTemplate.Height = 33;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1000, 262);
            this.dataGridViewCustomers.TabIndex = 61;
            this.dataGridViewCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCustomers_RowHeaderMouseClick);
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(616, 71);
            this.textBoxPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(208, 31);
            this.textBoxPostalCode.TabIndex = 60;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(400, 277);
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
            this.buttonSave.Location = new System.Drawing.Point(616, 277);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 69);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(476, 77);
            this.labelPostalCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(135, 25);
            this.labelPostalCode.TabIndex = 57;
            this.labelPostalCode.Text = "Postal Code:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(616, 12);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(404, 31);
            this.textBoxAddress.TabIndex = 56;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(192, 12);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(208, 31);
            this.textBoxName.TabIndex = 55;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(476, 17);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(97, 25);
            this.labelAddress.TabIndex = 54;
            this.labelAddress.Text = "Address:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 17);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 25);
            this.labelName.TabIndex = 53;
            this.labelName.Text = "Name:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(192, 133);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(208, 31);
            this.textBoxPhoneNumber.TabIndex = 71;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(24, 138);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(161, 25);
            this.labelPhoneNumber.TabIndex = 70;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(618, 135);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(208, 31);
            this.textBoxEmail.TabIndex = 69;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(478, 140);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 25);
            this.labelEmail.TabIndex = 68;
            this.labelEmail.Text = "Email:";
            // 
            // labelCreditLimit
            // 
            this.labelCreditLimit.AutoSize = true;
            this.labelCreditLimit.Location = new System.Drawing.Point(24, 200);
            this.labelCreditLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreditLimit.Name = "labelCreditLimit";
            this.labelCreditLimit.Size = new System.Drawing.Size(126, 25);
            this.labelCreditLimit.TabIndex = 72;
            this.labelCreditLimit.Text = "Credit Limit:";
            // 
            // numericUpDownCreditLimit
            // 
            this.numericUpDownCreditLimit.DecimalPlaces = 2;
            this.numericUpDownCreditLimit.Location = new System.Drawing.Point(192, 196);
            this.numericUpDownCreditLimit.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownCreditLimit.Name = "numericUpDownCreditLimit";
            this.numericUpDownCreditLimit.Size = new System.Drawing.Size(148, 31);
            this.numericUpDownCreditLimit.TabIndex = 73;
            this.numericUpDownCreditLimit.ThousandsSeparator = true;
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(832, 277);
            this.buttonPush.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(196, 69);
            this.buttonPush.TabIndex = 74;
            this.buttonPush.Text = "Save to Database";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // buttonFetchAllCustomers
            // 
            this.buttonFetchAllCustomers.Location = new System.Drawing.Point(832, 381);
            this.buttonFetchAllCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchAllCustomers.Name = "buttonFetchAllCustomers";
            this.buttonFetchAllCustomers.Size = new System.Drawing.Size(196, 69);
            this.buttonFetchAllCustomers.TabIndex = 75;
            this.buttonFetchAllCustomers.Text = "Fetch from Database";
            this.buttonFetchAllCustomers.UseVisualStyleBackColor = true;
            this.buttonFetchAllCustomers.Click += new System.EventHandler(this.buttonFetchAllCustomers_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 758);
            this.Controls.Add(this.buttonFetchAllCustomers);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.numericUpDownCreditLimit);
            this.Controls.Add(this.labelCreditLimit);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxFilterCustomer);
            this.Controls.Add(this.buttonFilterCustomers);
            this.Controls.Add(this.labelFilterCustomer);
            this.Controls.Add(this.buttonListAllCustomers);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreditLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxFilterCustomer;
        private System.Windows.Forms.Button buttonFilterCustomers;
        private System.Windows.Forms.Label labelFilterCustomer;
        private System.Windows.Forms.Button buttonListAllCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCreditLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownCreditLimit;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Button buttonFetchAllCustomers;
    }
}