using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.BLL
{
    // Aggregate root
    public class UserAccount
    {
        public const string DEFAULT_PASSWORD = "123456";

        public UserAccount()
        {
            Password = DEFAULT_PASSWORD;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Employee Employee { get; set; }

        public Role Role { get; set; }
    }
}
