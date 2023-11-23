using HiTechDistributionInc.BLL;
using System;

namespace HiTechDistributionInc.BLL
{
    public class RoleValidator
    {
        public string Validate(Role role)
        {
            if (role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            if (string.IsNullOrWhiteSpace(role.Title))
            {
                return "Please provide a title";
            }

            return null;
        }
    }
}