using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.DAL
{
    public class EntityFrameworkDbInitializer : CreateDatabaseIfNotExists<EntityFrameworkDbContext>
    {
        protected override void Seed(EntityFrameworkDbContext context)
        {
            AddCustomers(context);
            AddPublishersBooksInventories(context);
            AddEmployeesUserAccountsRoles(context);
            base.Seed(context);
        }

        private static void AddCustomers(EntityFrameworkDbContext context)
        {
            var alireza = new Customer { Name = "Alireza", Address = "imaginary address", City = "Montreal", PostalCode = "h1t 4a1", Email = "alireza@gmail.com", PhoneNumber = "5147464364", CreditLimit = 2500 };
            context.Customers.Add(alireza);
        }

        private static void AddPublishersBooksInventories(EntityFrameworkDbContext context)
        {
            // Authors
            var denisRitchi = new Author { FirstName = "Denis", LastName = "Ritchi", Email = "denis.ritchi@gmail.com" };
            context.Authors.Add(denisRitchi);
            var williamStallings = new Author { FirstName = "William", LastName = "Stallings", Email = "william.stallings@gmail.com" };
            context.Authors.Add(williamStallings);
            var andrewTanenbaum = new Author { FirstName = "Andrew", LastName = "Tanenbaum", Email = "andrew.tanenbaum@gmail.com" };
            context.Authors.Add(andrewTanenbaum);

            // Publishers
            var wrox = new Publisher { Name = "Wrox" };
            context.Publishers.Add(wrox);
            var prenticeHall = new Publisher { Name = "Prentice Hall" };
            context.Publishers.Add(prenticeHall);

            // Books
            var pythonProgramming1 = new Book
            {
                Title = "Python Programming",
                Isbn = "123",
                Category = BookCategory.Programming,
                Publisher = wrox,
                YearPublished = 2010,
                Edition = 1,
                UnitPrice = 15.40M
            };
            denisRitchi.Books.Add(pythonProgramming1);
            pythonProgramming1.Authors.Add(denisRitchi);
            context.Books.Add(pythonProgramming1);

            var pythonProgramming2 = new Book
            {
                Title = "Python Programming",
                Isbn = "123",
                Category = BookCategory.Programming,
                Publisher = wrox,
                YearPublished = 2015,
                Edition = 2,
                UnitPrice = 19.99M
            };
            denisRitchi.Books.Add(pythonProgramming2);
            pythonProgramming2.Authors.Add(denisRitchi);
            context.Books.Add(pythonProgramming2);

            var computerArchitecture = new Book
            {
                Title = "Computer Architecture",
                Isbn = "456",
                Category = BookCategory.Architecture,
                Publisher = prenticeHall,
                YearPublished = 2005,
                Edition = 1,
                UnitPrice = 20.50M
            };
            williamStallings.Books.Add(computerArchitecture);
            computerArchitecture.Authors.Add(williamStallings);
            context.Books.Add(computerArchitecture);

            var databaseDesign1 = new Book
            {
                Title = "Database Design",
                Isbn = "789",
                Category = BookCategory.Database,
                Publisher = prenticeHall,
                YearPublished = 2007,
                Edition = 1,
                UnitPrice = 17.65M
            };
            williamStallings.Books.Add(databaseDesign1);
            databaseDesign1.Authors.Add(williamStallings);
            andrewTanenbaum.Books.Add(databaseDesign1);
            databaseDesign1.Authors.Add(andrewTanenbaum);
            context.Books.Add(databaseDesign1);

            var databaseDesign2 = new Book
            {
                Title = "Database Design",
                Isbn = "789",
                Category = BookCategory.Database,
                Publisher = prenticeHall,
                YearPublished = 2017,
                Edition = 2,
                UnitPrice = 22.50M
            };
            williamStallings.Books.Add(databaseDesign2);
            databaseDesign2.Authors.Add(williamStallings);
            andrewTanenbaum.Books.Add(databaseDesign2);
            databaseDesign2.Authors.Add(andrewTanenbaum);
            context.Books.Add(databaseDesign2);

            var databaseDesign3 = new Book
            {
                Title = "Database Design",
                Isbn = "789",
                Category = BookCategory.Database,
                Publisher = prenticeHall,
                YearPublished = 2021,
                Edition = 3,
                UnitPrice = 25M
            };
            williamStallings.Books.Add(databaseDesign3);
            databaseDesign3.Authors.Add(williamStallings);
            andrewTanenbaum.Books.Add(databaseDesign3);
            databaseDesign3.Authors.Add(andrewTanenbaum);
            context.Books.Add(databaseDesign3);

            // Inventories
            var inventorypythonProgramming1 = new Inventory { Book = pythonProgramming1, QuantityOnHand = 500 };
            context.Inventories.Add(inventorypythonProgramming1);
            var inventorypythonProgramming2 = new Inventory { Book = pythonProgramming2, QuantityOnHand = 1000 };
            context.Inventories.Add(inventorypythonProgramming2);
            var inventoryComputerArchitecture = new Inventory { Book = computerArchitecture, QuantityOnHand = 700 };
            context.Inventories.Add(inventoryComputerArchitecture);
            var inventorydatabaseDesign1 = new Inventory { Book = databaseDesign1, QuantityOnHand = 300 };
            context.Inventories.Add(inventorydatabaseDesign1);
            var inventorydatabaseDesign2 = new Inventory { Book = databaseDesign2, QuantityOnHand = 500 };
            context.Inventories.Add(inventorydatabaseDesign2);
            var inventorydatabaseDesign3 = new Inventory { Book = databaseDesign3, QuantityOnHand = 1000 };
            context.Inventories.Add(inventorydatabaseDesign3);
        }

        private void AddEmployeesUserAccountsRoles(EntityFrameworkDbContext context)
        {
            // Roles
            var misManager = new Role { Title = Role.MIS_MANAGER_ROLE };
            context.Roles.Add(misManager);
            var salesManager = new Role { Title = Role.SALES_MANAGER_ROLE };
            context.Roles.Add(salesManager);
            var inventoryManager = new Role { Title = Role.INVENTORY_MANAGER_ROLE };
            context.Roles.Add(inventoryManager);
            var orderClerk = new Role { Title = Role.ORDER_CLERK_ROLE };
            context.Roles.Add(orderClerk);
            var accountant = new Role { Title = Role.ACCOUNTANT_ROLE };
            context.Roles.Add(accountant);

            // Employees
            var henryBrown = new Employee { FirstName = "Henry", LastName = "Brown", Email = "henry.brown@gmail.com", PhoneNumber = "4388753245" };
            context.Employees.Add(henryBrown);
            var thomasMoor = new Employee { FirstName = "Thomas", LastName = "Moor", Email = "thomas.moor@gmail.com", PhoneNumber = "4388753255" };
            context.Employees.Add(thomasMoor);
            var peterWang = new Employee { FirstName = "Peter", LastName = "Wang", Email = "peter.wang@gmail.com", PhoneNumber = "4388753260" };
            context.Employees.Add(peterWang);
            var jenniferBouchard = new Employee { FirstName = "Jennifer", LastName = "Bouchard", Email = "jennifer.bouchard@gmail.com", PhoneNumber = "4388753265" };
            context.Employees.Add(jenniferBouchard);
            var maryBrown = new Employee { FirstName = "Mary", LastName = "Brown", Email = "mary.brown@gmail.com", PhoneNumber = "4388753270" };
            context.Employees.Add(maryBrown);
            var kimHoaNguyen = new Employee { FirstName = "Kim", LastName = "Hoa Nguyen", Email = "kim.hoanguyen@gmail.com", PhoneNumber = "4388753275" };
            context.Employees.Add(kimHoaNguyen);

            //  User Accounts
            var henryBrownAccount = new UserAccount { Employee = henryBrown, Username = "henry.brown", Role = misManager };
            context.UserAccounts.Add(henryBrownAccount);
            var thomasMoorAccount = new UserAccount { Employee = thomasMoor, Username = "thomas.moor", Role = salesManager };
            context.UserAccounts.Add(thomasMoorAccount);
            var peterWangAccount = new UserAccount { Employee = peterWang, Username = "peter.wang", Role = inventoryManager };
            context.UserAccounts.Add(peterWangAccount);
            var jenniferBouchardAccount = new UserAccount { Employee = jenniferBouchard, Username = "jennifer.bouchard", Role = orderClerk };
            context.UserAccounts.Add(jenniferBouchardAccount);
            var maryBrownAccount = new UserAccount { Employee = maryBrown, Username = "mary.brown", Role = orderClerk };
            context.UserAccounts.Add(maryBrownAccount);
            var kimHoaNguyenAccount = new UserAccount { Employee = kimHoaNguyen, Username = "kim.hoanguyen", Role = accountant };
            context.UserAccounts.Add(kimHoaNguyenAccount);
        }
    }
}
