using HiTechDistributionInc.BLL;
using System;
using System.ComponentModel.DataAnnotations;

namespace HiTechDistributionInc.BLL
{
    public class AuthorValidator
    {
        public string Validate(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException(nameof(author));
            }

            if (string.IsNullOrWhiteSpace(author.FirstName))
            {
                return "Please provide first name";
            }

            if (string.IsNullOrWhiteSpace(author.LastName))
            {
                return "Please provide last name";
            }

            if (!new EmailAddressAttribute().IsValid(author.Email))
            {
                return "Please provide a valid email";
            }

            return null;
        }
    }
}