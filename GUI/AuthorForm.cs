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
    public partial class AuthorForm : Form
    {
        private EntityFrameworkDbContext _context;
        private Author _author;

        public AuthorForm()
        {
            _context = new EntityFrameworkDbContext();
            InitializeComponent();
        }

        private void CreateAuthor_Load(object sender, EventArgs e)
        {
            ResetAuthors();
        }

        private void BindAuthor()
        {
            textBoxIFirstName.Text = _author.FirstName;
            textBoxLastName.Text = _author.LastName;
            textBoxEmail.Text = _author.Email;
        }

        private void ResetAuthor()
        {
            _author = new Author();
            textBoxIFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetAuthors();
        }

        private void ResetAuthors()
        {
            textBoxFilterAuthor.Clear();
            dataGridViewAuthors.DataSource = null;
            ResetAuthor();
            BindAuthor();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PrepareAuthor();

            var validator = new AuthorValidator();
            var error = validator.Validate(_author);

            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var authorDB = new AuthorDb(_context);
            authorDB.Save(_author);

            ResetAuthors();
        }

        private void PrepareAuthor()
        {
            _author.FirstName = textBoxIFirstName.Text;
            _author.LastName = textBoxLastName.Text;
            _author.Email = textBoxEmail.Text;
        }

        private void buttonFilterAuthors_Click(object sender, EventArgs e)
        {
            var authorDb = new AuthorDb(_context);
            var authors = authorDb.GetAuthorsByFilter(textBoxFilterAuthor.Text);
            BindAuthors(authors);
        }

        private void BindAuthors(List<Author> authors)
        {
            dataGridViewAuthors.DataSource = authors;

            dataGridViewAuthors.Columns["Id"].Visible = false;
            dataGridViewAuthors.Columns["FirstName"].Visible = false;
            dataGridViewAuthors.Columns["LastName"].Visible = false;
            dataGridViewAuthors.Columns["Name"].ReadOnly = true;
            dataGridViewAuthors.Columns["Email"].ReadOnly = true;
        }

        private void dataGridViewAuthors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var authorId = Convert.ToInt32(dataGridViewAuthors.Rows[e.RowIndex].Cells["Id"].Value);
            var authorDb = new AuthorDb(_context);
            _author = authorDb.GetById(authorId);

            BindAuthor();
        }

        private void buttonListAllAuthors_Click(object sender, EventArgs e)
        {
            var authorDb = new AuthorDb(_context);
            var authors = authorDb.GetAll();
            BindAuthors(authors);
        }
    }
}
