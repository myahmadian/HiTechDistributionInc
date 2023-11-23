using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HiTechDistributionInc.DAL
{
    public class OrderDb
    {
        private EntityFrameworkDbContext _context;

        public OrderDb(EntityFrameworkDbContext context)
        {
            _context = context;
        }

        public List<Order> GetAll()
        {
            return _context.Orders
                .Include(o => o.Customer)
                .ToList();
        }

        public Order GetById(int orderId)
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderDetails
                    .Select(od => od.Book)
                    .Select(b => b.Publisher))
                .SingleOrDefault(o => o.Id == orderId);
        }

        public OrderDetail GetOrderDetailById(int orderDetailId)
        {
            return _context.Orders
                .SelectMany(o => o.OrderDetails)
                .Include(od => od.Book)
                .Include(od => od.Book.Publisher)
                .SingleOrDefault(od => od.Id == orderDetailId);
        }

        public List<Order> GetOrdersByCustomerId(int customerId)
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Where(o => o.Customer.Id == customerId)
                .ToList();
        }

        public void Save(Order order)
        {
            if (order.Id == 0)
            {
                _context.Orders.Add(order);
            }
            _context.SaveChanges();
        }
    }
}
