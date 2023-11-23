using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.DAL
{
    public class InventoryDb
    {
        private EntityFrameworkDbContext _context;

        public InventoryDb(EntityFrameworkDbContext context)
        {
            _context = context;
        }

        public List<Inventory> GetAll()
        {
            return _context.Inventories.ToList();
        }

        public Inventory GetById(int inventoryId)
        {
            return _context.Inventories.Find(inventoryId);
        }

        public void Save(Inventory inventory)
        {
            if (inventory.Id == 0)
            {
                _context.Inventories.Add(inventory);
            }
            _context.SaveChanges();
        }

        public Inventory GetByBookId(int bookId)
        {
            return _context.Inventories
                .Where(i => i.Book.Id == bookId)
                .SingleOrDefault();
        }
    }
}
