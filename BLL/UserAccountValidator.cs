using HiTechDistributionInc.BLL;
using System;
using System.ComponentModel.DataAnnotations;

namespace HiTechDistributionInc.BLL
{
    public class UserAccountValidator
    {
        public string Validate(UserAccount userAccount)
        {
            if (userAccount == null)
            {
                throw new ArgumentNullException(nameof(userAccount));
            }

            if (string.IsNullOrWhiteSpace(userAccount.Username))
            {
                return "Please provide username";
            }

            if (string.IsNullOrWhiteSpace(userAccount.Password))
            {
                return "Please provide password";
            }

            if (userAccount.Employee == null || userAccount.Employee.IsNew)
            {
                return "Please provide employee";
            }

            if (userAccount.Role == null || userAccount.Role.IsNew)
            {
                return "Please provide role";
            }

            return null;
        }
    }
}