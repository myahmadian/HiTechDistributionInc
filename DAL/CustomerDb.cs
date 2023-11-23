using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HiTechDistributionInc.DAL
{
    // Database Programming with ADO.NET in Disconnected Mode
    public class CustomerDb
    {
        private DataAdapterDbContext _context;

        public CustomerDb(DataAdapterDbContext context)
        {
            _context = context;
        }

        // Gets from data table
        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        // Gets from the database
        public List<Customer> FetchAll()
        {
            _context.Customers.Refresh();
            return GetAll();
        }

        // Gets from data table
        public Customer GetById(int customerId)
        {
            return _context.Customers.Find(customerId);
        }

        // Gets from data table
        public List<Customer> GetCustomersByFilter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return new List<Customer>();
            }
            return _context.Customers
                .ToList()
                .Where(a => a.Name.Contains(text))
                .ToList();
        }

        // Adds to or updates the data table
        public void AddOrUpdate(Customer customer)
        {
            _context.Customers.AddOrUpdate(customer);
        }

        // Pushes the changes to the database
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
