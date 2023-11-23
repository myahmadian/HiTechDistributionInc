using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.DAL
{
    public class AuthorDb
    {
        private EntityFrameworkDbContext _context;

        public AuthorDb(EntityFrameworkDbContext context)
        {
            _context = context;
        }

        public List<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author GetById(int authorId)
        {
            return _context.Authors.Find(authorId);
        }

        public void Save(Author author)
        {
            if (author.Id == 0)
            {
                _context.Authors.Add(author);
            }
            _context.SaveChanges();
        }

        public List<Author> GetAuthorsByFilter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return new List<Author>();
            }
            return _context.Authors
                .Where(a => a.FirstName.Contains(text) || a.LastName.Contains(text))
                .ToList();
        }
    }
}
