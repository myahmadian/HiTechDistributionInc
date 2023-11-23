using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HiTechDistributionInc.DAL
{
    public class BookDb
    {
        private EntityFrameworkDbContext _context;

        public BookDb(EntityFrameworkDbContext context)
        {
            _context = context;
        }

        public List<Book> GetAll()
        {
            return _context.Books
                .Include(b => b.Publisher)
                .Include(b => b.Authors)
                .ToList();
        }

        public Book GetById(int bookId)
        {
            return _context.Books.Find(bookId);
        }

        public void Save(Book book)
        {
            if (book.Id == 0)
            {
                _context.Books.Add(book);
            }
            _context.SaveChanges();
        }

        public List<Book> GetBooksByFilter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return new List<Book>();
            }
            return _context.Books
                .Include(b => b.Publisher)
                .Include(b => b.Authors)
                .Where(b => b.Title.Contains(text))
                .ToList();
        }
    }
}
