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
    public partial class BookForm : Form
    {
        private EntityFrameworkDbContext _context;
        private Book _book;

        public BookForm()
        {
            _context = new EntityFrameworkDbContext();
            InitializeComponent();
        }

        private void CreateBook_Load(object sender, EventArgs e)
        {
            SetElementBoundaries();
            BindCategory();
            BindPublishers();
            BindAuthors();
            ResetBooks();
        }

        private void SetElementBoundaries()
        {
            numericUpDownYearPublished.Minimum = Book.MIN_YEAR_PUBLISHED;
            numericUpDownYearPublished.Maximum = int.MaxValue;
            numericUpDownEdition.Minimum = Book.MIN_EDITION;
            numericUpDownEdition.Maximum = int.MaxValue;
            numericUpDownUnitPrice.Minimum = Book.MIN_UNIT_PRICE;
            numericUpDownUnitPrice.Maximum = decimal.MaxValue;
        }

        private void BindPublishers()
        {
            var publisherDb = new PublisherDb(_context);
            var publishers = publisherDb.GetAll();
            comboBoxPublisher.DataSource = publishers;
            comboBoxPublisher.DisplayMember = "Name";
            comboBoxPublisher.ValueMember = "Id";
        }

        private void BindAuthors()
        {
            var authorDb = new AuthorDb(_context);
            var authors = authorDb.GetAll();
            comboBoxAuthor.DataSource = authors;
            comboBoxAuthor.DisplayMember = "Name";
            comboBoxAuthor.ValueMember = "Id";
        }

        private void BindBook()
        {
            textBoxIsbn.Text = _book.Isbn;
            textBoxTitle.Text = _book.Title;
            comboBoxCategory.SelectedItem = _book.Category;
            numericUpDownYearPublished.Value = _book.YearPublished;
            if (_book.Publisher != null)
            {
                comboBoxPublisher.SelectedValue = _book.Publisher.Id;
            }
            numericUpDownEdition.Value = _book.Edition;
            numericUpDownUnitPrice.Value = _book.UnitPrice;
            BindBookAuthors();
        }

        private void BindBookAuthors()
        {
            var bindingSourdce = new BindingSource();
            bindingSourdce.DataSource = _book.Authors;
            dataGridViewAuthors.DataSource = bindingSourdce;
            dataGridViewAuthors.Columns["Id"].Visible = false;
            dataGridViewAuthors.Columns["FirstName"].ReadOnly = true;
            dataGridViewAuthors.Columns["LastName"].ReadOnly = true;
            dataGridViewAuthors.Columns["Email"].ReadOnly = true;
        }

        private void ResetBook()
        {
            _book = new Book();
            textBoxIsbn.Clear();
            textBoxTitle.Clear();
            comboBoxCategory.SelectedIndex = -1;
            numericUpDownYearPublished.Value = Book.MIN_YEAR_PUBLISHED;
            comboBoxPublisher.SelectedIndex = -1;
            numericUpDownEdition.Value = Book.MIN_EDITION;
            numericUpDownUnitPrice.Value = Book.MIN_UNIT_PRICE;
            ResetAuthors();
        }

        private void ResetAuthors()
        {
            dataGridViewAuthors.DataSource = null;
            ResetAuthor();
        }

        private void ResetAuthor()
        {
            comboBoxAuthor.SelectedIndex = -1;
        }

        private void BindCategory()
        {
            comboBoxCategory.DataSource = Enum.GetValues(typeof(BookCategory));
            comboBoxCategory.SelectedIndex = -1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PrepareBook();

            var validator = new BookValidator();
            var error = validator.Validate(_book);

            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bookDb = new BookDb(_context);
            bookDb.Save(_book);

            ResetBooks();
        }

        private void ResetBooks()
        {
            textBoxFilterBook.Clear();
            dataGridViewBooks.DataSource = null;
            ResetBook();
            BindBook();
        }

        private void PrepareBook()
        {
            _book.Isbn = textBoxIsbn.Text;
            _book.Title = textBoxTitle.Text;
            _book.Category = (BookCategory)comboBoxCategory.SelectedItem;
            _book.YearPublished = (int)numericUpDownYearPublished.Value;
            if (comboBoxPublisher.SelectedValue != null)
            {
                var publisherDb = new PublisherDb(_context);
                var publisherId = (int)comboBoxPublisher.SelectedValue;
                var publisher = publisherDb.GetById(publisherId);
                _book.Publisher = publisher;
            }
            _book.Edition = (int)numericUpDownEdition.Value;
            _book.UnitPrice = numericUpDownUnitPrice.Value;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetBooks();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            if (comboBoxAuthor.SelectedValue == null)
            {
                return;
            }
            var authorDb = new AuthorDb(_context);
            var authorId = (int)comboBoxAuthor.SelectedValue;
            var author = authorDb.GetById(authorId);
            _book.AddAuthor(author);
            author.AddBook(_book);
            BindBookAuthors();
            ResetAuthor();
        }

        private void dataGridViewAuthors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var author = _book.Authors[e.RowIndex];
            BindAuthor(author);
        }

        private void BindAuthor(Author author)
        {
            comboBoxAuthor.SelectedValue = author.Id;
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            foreach (var row in dataGridViewAuthors.SelectedRows)
            {
                var index = ((DataGridViewRow)row).Index;
                _book.DeleteAuthor(index);
            }
            BindBookAuthors();
            ResetAuthor();
        }

        private void buttonFilterBooks_Click(object sender, EventArgs e)
        {
            var bookDb = new BookDb(_context);
            var books = bookDb.GetBooksByFilter(textBoxFilterBook.Text);
            BindBooks(books);
        }

        private void BindBooks(List<Book> books)
        {
            dataGridViewBooks.DataSource = books;

            dataGridViewBooks.Columns["Id"].Visible = false;
            dataGridViewBooks.Columns["Isbn"].ReadOnly = true;
            dataGridViewBooks.Columns["Title"].ReadOnly = true;
            dataGridViewBooks.Columns["Category"].ReadOnly = true;
            dataGridViewBooks.Columns["Publisher"].ReadOnly = true;
            dataGridViewBooks.Columns["YearPublished"].ReadOnly = true;
            dataGridViewBooks.Columns["Edition"].ReadOnly = true;
            dataGridViewBooks.Columns["UnitPrice"].ReadOnly = true;
        }

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            var bookDb = new BookDb(_context);
            var books = bookDb.GetAll();
            BindBooks(books);
        }

        private void dataGridViewBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var bookId = Convert.ToInt32(dataGridViewBooks.Rows[e.RowIndex].Cells["Id"].Value);
            var bookDb = new BookDb(_context);
            _book = bookDb.GetById(bookId);

            BindBook();
        }
    }
}
