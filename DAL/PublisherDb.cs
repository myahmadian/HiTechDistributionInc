using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HiTechDistributionInc.DAL
{
    public class PublisherDb
    {
        private EntityFrameworkDbContext _context;

        public PublisherDb(EntityFrameworkDbContext context)
        {
            _context = context;
        }

        public List<Publisher> GetAll()
        {
            return _context.Publishers.ToList();
        }

        public Publisher GetById(int publisherId)
        {
            return _context.Publishers.Find(publisherId);
        }

        public void Save(Publisher publisher)
        {
            if (publisher.Id == 0)
            {
                _context.Publishers.Add(publisher);
            }
            _context.SaveChanges();
        }

        public List<Publisher> GetPublishersByFilter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return new List<Publisher>();
            }
            return _context.Publishers
                .Where(p => p.Name.Contains(text))
                .ToList();
        }
    }
}
