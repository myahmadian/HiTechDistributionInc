using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.BLL
{
    // Aggregate root
    public class Book
    {
        public const int MIN_YEAR_PUBLISHED = 1950;
        public const int MIN_EDITION = 1;
        public const decimal MIN_UNIT_PRICE = 0;

        public Book()
        {
            Category = BookCategory.Programming;
            YearPublished = MIN_YEAR_PUBLISHED;
            Edition = MIN_EDITION;
            UnitPrice = MIN_UNIT_PRICE;
            Authors = new List<Author>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Isbn { get; set; }

        public string Title { get; set; }

        public BookCategory Category { get; set; }

        public virtual Publisher Publisher { get; set; }

        public int YearPublished { get; set; }

        public int Edition { get; set; }

        public decimal UnitPrice { get; set; }

        public List<Author> Authors { get; set; }

        public string TitleEdition
        {
            get
            {
                return $"{Title}-{Edition}";
            }
        }

        public override string ToString()
        {
            return TitleEdition;
        }

        public void AddAuthor(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException(nameof(author));
            }
            Authors.Add(author);
        }

        internal void DeleteAuthor(int index)
        {
            var author = Authors[index];
            Authors.Remove(author);
        }
    }
}
