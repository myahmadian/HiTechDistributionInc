using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.BLL
{
    // Aggregate root
    public class Customer
    {
        public const int MIN_CREDIT_LIMIT = 0;

        public Customer()
        {
            CreditLimit = MIN_CREDIT_LIMIT;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public decimal CreditLimit { get; set; }

        public void DecreaseCreditLimitBy(decimal value)
        {
            CreditLimit -= value;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
