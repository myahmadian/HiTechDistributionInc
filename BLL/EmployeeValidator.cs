using HiTechDistributionInc.BLL;
using System;
using System.ComponentModel.DataAnnotations;

namespace HiTechDistributionInc.BLL
{
    public class EmployeeValidator
    {
        public string Validate(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            if (string.IsNullOrWhiteSpace(employee.FirstName))
            {
                return "Please provide first name";
            }

            if (string.IsNullOrWhiteSpace(employee.LastName))
            {
                return "Please provide last name";
            }

            if (string.IsNullOrWhiteSpace(employee.PhoneNumber))
            {
                return "Please provide phone number";
            }

            if (!new EmailAddressAttribute().IsValid(employee.Email))
            {
                return "Please provide a valid email";
            }

            return null;
        }
    }
}