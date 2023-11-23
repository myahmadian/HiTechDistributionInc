using HiTechDistributionInc.BLL;
using System;
using System.ComponentModel.DataAnnotations;

namespace HiTechDistributionInc.BLL
{
    public class CustomerValidator
    {
        public string Validate(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            if (string.IsNullOrWhiteSpace(customer.Name))
            {
                return "Please provide name";
            }

            if (string.IsNullOrWhiteSpace(customer.Address))
            {
                return "Please provide address";
            }

            if (string.IsNullOrWhiteSpace(customer.City))
            {
                return "Please provide city";
            }

            if (string.IsNullOrWhiteSpace(customer.PostalCode))
            {
                return "Please provide postal code";
            }

            if (string.IsNullOrWhiteSpace(customer.PhoneNumber))
            {
                return "Please provide phone number";
            }

            if (!new EmailAddressAttribute().IsValid(customer.Email))
            {
                return "Please provide a valid email";
            }

            return null;
        }
    }
}