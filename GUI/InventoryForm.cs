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
    public partial class InventoryForm : Form
    {
        private EntityFrameworkDbContext _context;
        private Inventory _inventory;

        public InventoryForm()
        {
            _context = new EntityFrameworkDbContext();
            InitializeComponent();
        }

        private void CreateInventory_Load(object sender, EventArgs e)
        {
            SetElementBoundaries();
            BindBooks();
            ResetInventory();
            BindInventory();
        }

        private void BindBooks()
        {
            var bookDb = new BookDb(_context);
            var books = bookDb.GetAll();
            comboBoxBook.DataSource = books;
            comboBoxBook.DisplayMember = "TitleEdition";
            comboBoxBook.ValueMember = "Id";
        }

        private void SetElementBoundaries()
        {
            numericUpDownQuantityOnHand.Minimum = 0;
            numericUpDownQuantityOnHand.Maximum = int.MaxValue;
        }

        private void BindInventory()
        {
            if (_inventory.Book != null)
            {
                comboBoxBook.SelectedValue = _inventory.Book.Id;
            }
            numericUpDownQuantityOnHand.Value = _inventory.QuantityOnHand;
        }

        private void ResetInventory()
        {
            _inventory = new Inventory();
            comboBoxBook.SelectedIndex = -1;
            numericUpDownQuantityOnHand.Value = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PrepareInventory();

            var validator = new InventoryValidator();
            var error = validator.Validate(_inventory);

            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var inventoryDb = new InventoryDb(_context);
            inventoryDb.Save(_inventory);

            Close();
        }

        private void PrepareInventory()
        {
            if (comboBoxBook.SelectedValue != null)
            {
                var bookDb = new BookDb(_context);
                var bookId = (int)comboBoxBook.SelectedValue;
                var book = bookDb.GetById(bookId);
                _inventory.Book = book;
            }
            _inventory.QuantityOnHand = (int)numericUpDownQuantityOnHand.Value;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetInventory();
            BindInventory();
        }

        private void comboBoxBook_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var inventoryDb = new InventoryDb(_context);
            var bookId = (int)comboBoxBook.SelectedValue;
            var inventory = inventoryDb.GetByBookId(bookId);
            if (inventory != null)
            {
                _inventory = inventory;
                BindInventory();
            }
        }
    }
}
