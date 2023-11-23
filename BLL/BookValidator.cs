using HiTechDistributionInc.BLL;
using System;

namespace HiTechDistributionInc.BLL
{
    public class BookValidator
    {
        public string Validate(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            if (string.IsNullOrWhiteSpace(book.Isbn))
            {
                return "Please provide ISBN";
            }

            if (string.IsNullOrWhiteSpace(book.Title))
            {
                return "Please provide title";
            }

            if (book.Publisher == null)
            {
                return "Please provide a publisher";
            }

            if (book.YearPublished < Book.MIN_YEAR_PUBLISHED)
            {
                return $"Year published should be greater than or equal to {Book.MIN_YEAR_PUBLISHED}";
            }

            if (book.YearPublished > DateTime.Today.Year)
            {
                return $"Year published cannot be in future";
            }

            if (book.Edition < Book.MIN_EDITION)
            {
                return $"Edition should be greater than {Book.MIN_EDITION}";
            }

            if (book.UnitPrice < 1)
            {
                return $"Unit price should be greater than {Book.MIN_UNIT_PRICE}";
            }

            if (book.Authors == null || book.Authors.Count == 0)
            {
                return "Please add authors";
            }

            return null;
        }
    }
}