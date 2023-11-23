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
    public partial class OrderForm : Form
    {
        private Order _order;
        private EntityFrameworkDbContext _efContext;
        private DataAdapterDbContext _daContext;

        public OrderForm()
        {
            InitializeComponent();
            _efContext = new EntityFrameworkDbContext();
            _daContext = new DataAdapterDbContext();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            SetElementBoundaries();
            BindCustomers();
            BindSearchCustomers();
            BindOrderStatuses();
            BindBooks();
            ResetOrders();
            ChangeElementsMode();
        }

        private void SetElementBoundaries()
        {
            numericUpDownPayment.Minimum = Order.MIN_PAYMENT;
            numericUpDownPayment.Maximum = decimal.MaxValue;
            numericUpDownQuantity.Minimum = OrderDetail.MIN_QUANTITY;
            numericUpDownQuantity.Maximum = int.MaxValue;
            numericUpDownTotal.Minimum = 0;
            numericUpDownTotal.Maximum = decimal.MaxValue;
            numericUpDownGrandTotal.Minimum = 0;
            numericUpDownGrandTotal.Maximum = decimal.MaxValue;
        }

        private void BindOrderStatuses()
        {
            comboBoxOrderStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            comboBoxOrderStatus.SelectedIndex = -1;
        }

        private void BindBooks()
        {
            var bookDb = new BookDb(_efContext);
            var books = bookDb.GetAll();
            comboBoxBook.DataSource = books;
            comboBoxBook.DisplayMember = "TitleEdition";
            comboBoxBook.ValueMember = "Id";
            comboBoxBook.SelectedIndex = -1;
        }

        private void BindCustomers()
        {
            var customerDb = new CustomerDb(_daContext);
            var customers = customerDb.GetAll();
            comboBoxCustomer.DataSource = customers;
            comboBoxCustomer.DisplayMember = "Name";
            comboBoxCustomer.ValueMember = "Id";
            comboBoxCustomer.SelectedIndex = -1;
        }

        private void BindSearchCustomers()
        {
            var customerDb = new CustomerDb(_daContext);
            var customers = customerDb.GetAll();
            comboBoxSearchCustomer.DataSource = customers;
            comboBoxSearchCustomer.DisplayMember = "Name";
            comboBoxSearchCustomer.ValueMember = "Id";
            comboBoxSearchCustomer.SelectedIndex = -1;
        }

        private void buttonListAllOrders_Click(object sender, EventArgs e)
        {
            var orderDb = new OrderDb(_efContext);
            var orders = orderDb.GetAll();
            BindOrders(orders);
        }

        private void buttonListCustomerOrders_Click(object sender, EventArgs e)
        {
            var orderDb = new OrderDb(_efContext);
            if (comboBoxSearchCustomer.SelectedValue == null)
            {
                return;
            }
            var customerId = (int)comboBoxSearchCustomer.SelectedValue;
            var orders = orderDb.GetOrdersByCustomerId(customerId);
            BindOrders(orders);
        }

        private void BindOrders(List<Order> orders)
        {
            dataGridViewOrders.DataSource = orders;

            dataGridViewOrders.Columns["Id"].Visible = false;
            dataGridViewOrders.Columns["OrderDate"].ReadOnly = true;
            dataGridViewOrders.Columns["ShippingDate"].ReadOnly = true;
            dataGridViewOrders.Columns["Customer"].ReadOnly = true;
            dataGridViewOrders.Columns["Status"].ReadOnly = true;
            dataGridViewOrders.Columns["IsCanceled"].ReadOnly = true;
        }

        private void BindOrder()
        {
            maskedTextBoxOrderDate.Text = _order.OrderDate.ToString("yyyy/MM/dd");
            if (_order.Customer != null)
            {
                comboBoxCustomer.SelectedValue = _order.Customer.Id;
            }
            if (_order.ShippingDate != null)
            {
                maskedTextBoxShippingDate.Text = _order.ShippingDate.Value.ToString("yyyy/MM/dd");
            }
            if (_order.Payment != null)
            {
                numericUpDownPayment.Value = _order.Payment.Value;
            }
            else
            {
                numericUpDownPayment.Value = default;
            }
            checkBoxIsCanceled.Checked = _order.IsCanceled;
            comboBoxOrderStatus.SelectedItem = _order.Status;
            BindTotal();
            BindOrderDetails();
            ChangeElementsMode();
        }

        private void ChangeElementsMode()
        {
            if (!_order.CanChange)
            {
                maskedTextBoxOrderDate.Enabled = false;
                comboBoxCustomer.Enabled = false;
                maskedTextBoxShippingDate.Enabled = false;
                numericUpDownPayment.Enabled = false;
                checkBoxIsCanceled.Enabled = false;
                comboBoxOrderStatus.Enabled = false;
                numericUpDownQuantity.Enabled = false;
                comboBoxBook.Enabled = false;
                buttonAddOrderDetail.Enabled = false;
                buttonDeleteOrderDetail.Enabled = false;
                buttonSave.Enabled = false;
                return;
            }
            maskedTextBoxOrderDate.Enabled = false;
            comboBoxCustomer.Enabled = true;
            maskedTextBoxShippingDate.Enabled = true;
            numericUpDownPayment.Enabled = true;
            checkBoxIsCanceled.Enabled = true;
            comboBoxOrderStatus.Enabled = false;
            numericUpDownQuantity.Enabled = true;
            comboBoxBook.Enabled = true;
            buttonAddOrderDetail.Enabled = true;
            buttonDeleteOrderDetail.Enabled = true;
            buttonSave.Enabled = true; 
        }

        private void BindTotal()
        {
            numericUpDownTotal.Value = _order.GetOrderTotal();
            numericUpDownGrandTotal.Value = _order.GetGrandTotal();
        }

        private void BindOrderDetails()
        {
            var bindingSourdce = new BindingSource();
            bindingSourdce.DataSource = _order.OrderDetails;
            dataGridViewOrderDetails.DataSource = bindingSourdce;
            dataGridViewOrderDetails.Columns["Id"].Visible = false;
            dataGridViewOrderDetails.Columns["Order"].Visible = false;
            dataGridViewOrderDetails.Columns["Book"].ReadOnly = true;
            dataGridViewOrderDetails.Columns["Quantity"].ReadOnly = true;
        }

        private void dataGridViewOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var orderId = Convert.ToInt32(dataGridViewOrders.Rows[e.RowIndex].Cells["Id"].Value);
            var orderDb = new OrderDb(_efContext);
            _order = orderDb.GetById(orderId);

            BindOrder();
        }

        private void dataGridViewOrderDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var orderDetail = _order.OrderDetails[e.RowIndex];

            BindOrderDetail(orderDetail);
        }

        private void BindOrderDetail(OrderDetail orderDetail)
        {
            numericUpDownQuantity.Value = orderDetail.Quantity;
            comboBoxBook.SelectedValue = orderDetail.Book.Id;
        }

        private void ResetOrderDetail()
        {
            numericUpDownQuantity.Value = OrderDetail.MIN_QUANTITY;
            comboBoxBook.SelectedIndex = -1;
        }

        private void buttonAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (comboBoxBook.SelectedValue == null)
            {
                return;
            }
            var bookDb = new BookDb(_efContext);
            var bookId = (int)comboBoxBook.SelectedValue;
            var book = bookDb.GetById(bookId);
            var quantity = (int)numericUpDownQuantity.Value;
            _order.AddOrderDetail(book, quantity);
            BindOrderDetails();
            ResetOrderDetail();
            BindTotal();
        }

        private void buttonDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            foreach (var row in dataGridViewOrderDetails.SelectedRows)
            {
                var index = ((DataGridViewRow)row).Index;
                _order.DeleteOrderDetail(index);
            }
            BindOrderDetails();
            ResetOrderDetail();
            BindTotal();
        }

        private void PrepareOrder()
        {
            if (maskedTextBoxOrderDate.Text != null)
            {
                DateTime result;
                var isParsed = DateTime.TryParse(maskedTextBoxOrderDate.Text, out result);
                if (isParsed)
                {
                    _order.OrderDate = result;
                }
                else
                {
                    MessageBox.Show("Invalid order date", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (comboBoxCustomer.SelectedValue != null)
            {
                var customerId = (int)comboBoxCustomer.SelectedValue;
                var customerDb = new CustomerDb(_daContext);
                var customer = customerDb.GetById(customerId);
                _order.Customer = customer;
            }
            if (maskedTextBoxShippingDate.Text != null && maskedTextBoxShippingDate.Text != "    /  /")
            {
                DateTime result;
                var isParsed = DateTime.TryParse(maskedTextBoxShippingDate.Text, out result);
                if (isParsed)
                {
                    _order.ShippingDate = result;
                }
                else
                {
                    MessageBox.Show("Invalid shipping date", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (numericUpDownPayment.Value != 0)
            {
                _order.Payment = numericUpDownPayment.Value;
            }
            _order.IsCanceled = checkBoxIsCanceled.Checked;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PrepareOrder();

            var validator = new OrderValidator();
            var error = validator.Validate(_order);
            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var orderDb = new OrderDb(_efContext);
            orderDb.Save(_order);
            _efContext = new EntityFrameworkDbContext();

            var orderOperation = new OrderOperation();
            orderOperation.UpdateInventoryAndCustomerCredit(_order.Id);

            ResetOrders();
            ChangeElementsMode();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetOrders();
        }

        public void ResetOrders()
        {
            comboBoxSearchCustomer.SelectedIndex = -1;
            dataGridViewOrders.DataSource = null;
            ResetOrder();
            BindOrder();
        }

        public void ResetOrder()
        {
            _order = new Order();
            maskedTextBoxOrderDate.Clear();
            comboBoxCustomer.SelectedIndex = -1;
            maskedTextBoxShippingDate.Clear();
            numericUpDownPayment.Value = 0;
            checkBoxIsCanceled.Checked = false;
            comboBoxOrderStatus.SelectedIndex = -1;
            ResetOrderDetails();
        }

        public void ResetOrderDetails()
        {
            dataGridViewOrderDetails.DataSource = null;
            ResetOrderDetail();
        }

        private void comboBoxSearchCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
