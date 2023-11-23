
namespace HiTechDistributionInc.GUI
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblShippingDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxShippingDate = new System.Windows.Forms.MaskedTextBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.lblIsCanceled = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownPayment = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIsCanceled = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonListAllOrders = new System.Windows.Forms.Button();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.labelTotalBeforeTaxes = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.numericUpDownTotal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGrandTotal = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonDeleteOrderDetail = new System.Windows.Forms.Button();
            this.buttonAddOrderDetail = new System.Windows.Forms.Button();
            this.labelBook = new System.Windows.Forms.Label();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.groupBoxOrderDetail = new System.Windows.Forms.GroupBox();
            this.comboBoxSearchCustomer = new System.Windows.Forms.ComboBox();
            this.buttonListCustomerOrders = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrandTotal)).BeginInit();
            this.groupBoxOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBoxOrderDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToOrderColumns = true;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(35, 952);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 82;
            this.dataGridViewOrders.RowTemplate.Height = 33;
            this.dataGridViewOrders.Size = new System.Drawing.Size(890, 415);
            this.dataGridViewOrders.TabIndex = 4;
            this.dataGridViewOrders.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrders_RowHeaderMouseClick);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(22, 47);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(123, 25);
            this.lblOrderDate.TabIndex = 0;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblShippingDate
            // 
            this.lblShippingDate.AutoSize = true;
            this.lblShippingDate.Location = new System.Drawing.Point(22, 101);
            this.lblShippingDate.Name = "lblShippingDate";
            this.lblShippingDate.Size = new System.Drawing.Size(153, 25);
            this.lblShippingDate.TabIndex = 1;
            this.lblShippingDate.Text = "Shipping Date:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(548, 47);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(110, 25);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(682, 47);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(177, 33);
            this.comboBoxCustomer.TabIndex = 4;
            // 
            // maskedTextBoxOrderDate
            // 
            this.maskedTextBoxOrderDate.Enabled = false;
            this.maskedTextBoxOrderDate.Location = new System.Drawing.Point(177, 47);
            this.maskedTextBoxOrderDate.Mask = "0000/00/00";
            this.maskedTextBoxOrderDate.Name = "maskedTextBoxOrderDate";
            this.maskedTextBoxOrderDate.Size = new System.Drawing.Size(149, 31);
            this.maskedTextBoxOrderDate.TabIndex = 5;
            this.maskedTextBoxOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxShippingDate
            // 
            this.maskedTextBoxShippingDate.Location = new System.Drawing.Point(177, 95);
            this.maskedTextBoxShippingDate.Mask = "0000/00/00";
            this.maskedTextBoxShippingDate.Name = "maskedTextBoxShippingDate";
            this.maskedTextBoxShippingDate.Size = new System.Drawing.Size(149, 31);
            this.maskedTextBoxShippingDate.TabIndex = 6;
            this.maskedTextBoxShippingDate.ValidatingType = typeof(System.DateTime);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(548, 101);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(102, 25);
            this.labelPayment.TabIndex = 9;
            this.labelPayment.Text = "Payment:";
            // 
            // lblIsCanceled
            // 
            this.lblIsCanceled.AutoSize = true;
            this.lblIsCanceled.Location = new System.Drawing.Point(22, 158);
            this.lblIsCanceled.Name = "lblIsCanceled";
            this.lblIsCanceled.Size = new System.Drawing.Size(85, 25);
            this.lblIsCanceled.TabIndex = 12;
            this.lblIsCanceled.Text = "Cancel:";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(548, 161);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(79, 25);
            this.lblOrderStatus.TabIndex = 23;
            this.lblOrderStatus.Text = "Status:";
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(682, 158);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(177, 33);
            this.comboBoxOrderStatus.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownPayment);
            this.groupBox1.Controls.Add(this.comboBoxOrderStatus);
            this.groupBox1.Controls.Add(this.lblOrderStatus);
            this.groupBox1.Controls.Add(this.checkBoxIsCanceled);
            this.groupBox1.Controls.Add(this.lblIsCanceled);
            this.groupBox1.Controls.Add(this.labelPayment);
            this.groupBox1.Controls.Add(this.maskedTextBoxShippingDate);
            this.groupBox1.Controls.Add(this.maskedTextBoxOrderDate);
            this.groupBox1.Controls.Add(this.comboBoxCustomer);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Controls.Add(this.lblShippingDate);
            this.groupBox1.Controls.Add(this.lblOrderDate);
            this.groupBox1.Location = new System.Drawing.Point(35, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 220);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // numericUpDownPayment
            // 
            this.numericUpDownPayment.DecimalPlaces = 2;
            this.numericUpDownPayment.Location = new System.Drawing.Point(682, 101);
            this.numericUpDownPayment.Name = "numericUpDownPayment";
            this.numericUpDownPayment.Size = new System.Drawing.Size(149, 31);
            this.numericUpDownPayment.TabIndex = 25;
            this.numericUpDownPayment.ThousandsSeparator = true;
            // 
            // checkBoxIsCanceled
            // 
            this.checkBoxIsCanceled.AutoSize = true;
            this.checkBoxIsCanceled.Location = new System.Drawing.Point(177, 158);
            this.checkBoxIsCanceled.Name = "checkBoxIsCanceled";
            this.checkBoxIsCanceled.Size = new System.Drawing.Size(28, 27);
            this.checkBoxIsCanceled.TabIndex = 13;
            this.checkBoxIsCanceled.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonListAllOrders
            // 
            this.buttonListAllOrders.Location = new System.Drawing.Point(729, 871);
            this.buttonListAllOrders.Name = "buttonListAllOrders";
            this.buttonListAllOrders.Size = new System.Drawing.Size(196, 70);
            this.buttonListAllOrders.TabIndex = 1;
            this.buttonListAllOrders.Text = "List All Orders";
            this.buttonListAllOrders.UseVisualStyleBackColor = true;
            this.buttonListAllOrders.Click += new System.EventHandler(this.buttonListAllOrders_Click);
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.AllowUserToAddRows = false;
            this.dataGridViewOrderDetails.AllowUserToDeleteRows = false;
            this.dataGridViewOrderDetails.AllowUserToOrderColumns = true;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(35, 47);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.ReadOnly = true;
            this.dataGridViewOrderDetails.RowHeadersWidth = 82;
            this.dataGridViewOrderDetails.RowTemplate.Height = 33;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(428, 250);
            this.dataGridViewOrderDetails.TabIndex = 5;
            this.dataGridViewOrderDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrderDetails_RowHeaderMouseClick);
            // 
            // labelTotalBeforeTaxes
            // 
            this.labelTotalBeforeTaxes.AutoSize = true;
            this.labelTotalBeforeTaxes.Location = new System.Drawing.Point(30, 321);
            this.labelTotalBeforeTaxes.Name = "labelTotalBeforeTaxes";
            this.labelTotalBeforeTaxes.Size = new System.Drawing.Size(200, 25);
            this.labelTotalBeforeTaxes.TabIndex = 11;
            this.labelTotalBeforeTaxes.Text = "Total Before Taxes:";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Location = new System.Drawing.Point(30, 358);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(131, 25);
            this.labelGrandTotal.TabIndex = 12;
            this.labelGrandTotal.Text = "Grand Total:";
            // 
            // numericUpDownTotal
            // 
            this.numericUpDownTotal.DecimalPlaces = 2;
            this.numericUpDownTotal.Location = new System.Drawing.Point(314, 321);
            this.numericUpDownTotal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTotal.Name = "numericUpDownTotal";
            this.numericUpDownTotal.ReadOnly = true;
            this.numericUpDownTotal.Size = new System.Drawing.Size(149, 31);
            this.numericUpDownTotal.TabIndex = 11;
            this.numericUpDownTotal.ThousandsSeparator = true;
            // 
            // numericUpDownGrandTotal
            // 
            this.numericUpDownGrandTotal.DecimalPlaces = 2;
            this.numericUpDownGrandTotal.Location = new System.Drawing.Point(314, 358);
            this.numericUpDownGrandTotal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownGrandTotal.Name = "numericUpDownGrandTotal";
            this.numericUpDownGrandTotal.ReadOnly = true;
            this.numericUpDownGrandTotal.Size = new System.Drawing.Size(149, 31);
            this.numericUpDownGrandTotal.TabIndex = 13;
            this.numericUpDownGrandTotal.ThousandsSeparator = true;
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.Controls.Add(this.numericUpDownGrandTotal);
            this.groupBoxOrderDetails.Controls.Add(this.numericUpDownTotal);
            this.groupBoxOrderDetails.Controls.Add(this.labelGrandTotal);
            this.groupBoxOrderDetails.Controls.Add(this.labelTotalBeforeTaxes);
            this.groupBoxOrderDetails.Controls.Add(this.dataGridViewOrderDetails);
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(431, 286);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(494, 440);
            this.groupBoxOrderDetails.TabIndex = 18;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "Order Details";
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Location = new System.Drawing.Point(28, 894);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(110, 25);
            this.labelSearchCustomer.TabIndex = 11;
            this.labelSearchCustomer.Text = "Customer:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(729, 764);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 70);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity:";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(122, 50);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(149, 31);
            this.numericUpDownQuantity.TabIndex = 8;
            // 
            // buttonDeleteOrderDetail
            // 
            this.buttonDeleteOrderDetail.Location = new System.Drawing.Point(19, 245);
            this.buttonDeleteOrderDetail.Name = "buttonDeleteOrderDetail";
            this.buttonDeleteOrderDetail.Size = new System.Drawing.Size(196, 70);
            this.buttonDeleteOrderDetail.TabIndex = 8;
            this.buttonDeleteOrderDetail.Text = "Delete Order Detail";
            this.buttonDeleteOrderDetail.UseVisualStyleBackColor = true;
            this.buttonDeleteOrderDetail.Click += new System.EventHandler(this.buttonDeleteOrderDetail_Click);
            // 
            // buttonAddOrderDetail
            // 
            this.buttonAddOrderDetail.Location = new System.Drawing.Point(19, 169);
            this.buttonAddOrderDetail.Name = "buttonAddOrderDetail";
            this.buttonAddOrderDetail.Size = new System.Drawing.Size(196, 70);
            this.buttonAddOrderDetail.TabIndex = 9;
            this.buttonAddOrderDetail.Text = "Add Order Detail";
            this.buttonAddOrderDetail.UseVisualStyleBackColor = true;
            this.buttonAddOrderDetail.Click += new System.EventHandler(this.buttonAddOrderDetail_Click);
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(22, 114);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(67, 25);
            this.labelBook.TabIndex = 10;
            this.labelBook.Text = "Book:";
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(122, 114);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(240, 33);
            this.comboBoxBook.TabIndex = 8;
            // 
            // groupBoxOrderDetail
            // 
            this.groupBoxOrderDetail.Controls.Add(this.comboBoxBook);
            this.groupBoxOrderDetail.Controls.Add(this.labelBook);
            this.groupBoxOrderDetail.Controls.Add(this.buttonAddOrderDetail);
            this.groupBoxOrderDetail.Controls.Add(this.buttonDeleteOrderDetail);
            this.groupBoxOrderDetail.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxOrderDetail.Controls.Add(this.label1);
            this.groupBoxOrderDetail.Location = new System.Drawing.Point(35, 286);
            this.groupBoxOrderDetail.Name = "groupBoxOrderDetail";
            this.groupBoxOrderDetail.Size = new System.Drawing.Size(378, 332);
            this.groupBoxOrderDetail.TabIndex = 19;
            this.groupBoxOrderDetail.TabStop = false;
            this.groupBoxOrderDetail.Text = "Order Detail";
            // 
            // comboBoxSearchCustomer
            // 
            this.comboBoxSearchCustomer.FormattingEnabled = true;
            this.comboBoxSearchCustomer.Location = new System.Drawing.Point(157, 891);
            this.comboBoxSearchCustomer.Name = "comboBoxSearchCustomer";
            this.comboBoxSearchCustomer.Size = new System.Drawing.Size(177, 33);
            this.comboBoxSearchCustomer.TabIndex = 21;
            this.comboBoxSearchCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchCustomer_SelectedIndexChanged);
            // 
            // buttonListCustomerOrders
            // 
            this.buttonListCustomerOrders.Location = new System.Drawing.Point(507, 871);
            this.buttonListCustomerOrders.Name = "buttonListCustomerOrders";
            this.buttonListCustomerOrders.Size = new System.Drawing.Size(196, 70);
            this.buttonListCustomerOrders.TabIndex = 22;
            this.buttonListCustomerOrders.Text = "List Customer Orders";
            this.buttonListCustomerOrders.UseVisualStyleBackColor = true;
            this.buttonListCustomerOrders.Click += new System.EventHandler(this.buttonListCustomerOrders_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(507, 764);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(196, 70);
            this.buttonReset.TabIndex = 23;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(964, 1402);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonListCustomerOrders);
            this.Controls.Add(this.labelSearchCustomer);
            this.Controls.Add(this.comboBoxSearchCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOrderDetails);
            this.Controls.Add(this.groupBoxOrderDetail);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonListAllOrders);
            this.MinimumSize = new System.Drawing.Size(26, 1400);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrandTotal)).EndInit();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBoxOrderDetail.ResumeLayout(false);
            this.groupBoxOrderDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblShippingDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOrderDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxShippingDate;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label lblIsCanceled;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxIsCanceled;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonListAllOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Label labelTotalBeforeTaxes;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownGrandTotal;
        private System.Windows.Forms.GroupBox groupBoxOrderDetails;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonDeleteOrderDetail;
        private System.Windows.Forms.Button buttonAddOrderDetail;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.GroupBox groupBoxOrderDetail;
        private System.Windows.Forms.ComboBox comboBoxSearchCustomer;
        private System.Windows.Forms.Button buttonListCustomerOrders;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.NumericUpDown numericUpDownPayment;
    }
}