using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.DAL
{
    public class EntityFrameworkDbContext : DbContext
    {
        static EntityFrameworkDbContext()
        {
            Database.SetInitializer(new EntityFrameworkDbInitializer());
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
