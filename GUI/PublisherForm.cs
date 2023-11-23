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
    public partial class PublisherForm : Form
    {
        private EntityFrameworkDbContext _context;
        private Publisher _publisher;

        public PublisherForm()
        {
            _context = new EntityFrameworkDbContext();
            InitializeComponent();
        }

        private void CreatePublisher_Load(object sender, EventArgs e)
        {
            ResetPublishers();
        }
        private void BindPublisher()
        {
            textBoxName.Text = _publisher.Name;
        }

        private void ResetPublisher()
        {
            _publisher = new Publisher();
            textBoxName.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetPublishers();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PreparePublisher();

            var validator = new PublisherValidator();
            var error = validator.Validate(_publisher);

            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var publisherDb = new PublisherDb(_context);
            publisherDb.Save(_publisher);

            ResetPublishers();
        }

        private void ResetPublishers()
        {
            textBoxFilterPublisher.Clear();
            dataGridViewPublishers.DataSource = null;
            ResetPublisher();
            BindPublisher();
        }

        private void PreparePublisher()
        {
            _publisher.Name = textBoxName.Text;
        }

        private void buttonFilterPublisher_Click(object sender, EventArgs e)
        {
            var publisherDb = new PublisherDb(_context);
            var publishers = publisherDb.GetPublishersByFilter(textBoxFilterPublisher.Text);
            BindPublishers(publishers);
        }

        private void BindPublishers(List<Publisher> publishers)
        {
            dataGridViewPublishers.DataSource = publishers;

            dataGridViewPublishers.Columns["Id"].Visible = false;
            dataGridViewPublishers.Columns["Name"].ReadOnly = true;
        }

        private void buttonListAllPublishers_Click(object sender, EventArgs e)
        {
            var publisherDb = new PublisherDb(_context);
            var publishers = publisherDb.GetAll();
            BindPublishers(publishers);
        }

        private void dataGridViewPublishers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var publisherId = Convert.ToInt32(dataGridViewPublishers.Rows[e.RowIndex].Cells["Id"].Value);
            var publisherDb = new PublisherDb(_context);
            _publisher = publisherDb.GetById(publisherId);

            BindPublisher();
        }
    }
}
