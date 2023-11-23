using HiTechDistributionInc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.BLL
{
    public class OrderOperation
    {
        private EntityFrameworkDbContext _efContext;
        private DataAdapterDbContext _daContext;

        public OrderOperation()
        {
            _efContext = new EntityFrameworkDbContext();
            _daContext = new DataAdapterDbContext();
        }

        public void UpdateInventoryAndCustomerCredit(int orderId)
        {
            if (orderId <= 0)
            {
                throw new ArgumentException("Invalid order id", nameof(orderId));
            }

            var orderDb = new OrderDb(_efContext);
            var order = orderDb.GetById(orderId);
            if (!order.CanConfirm)
            {
                return;
            }

            UpdateInventory(order);
            UpdateCustomerCredit(order);
            order.Status = OrderStatus.Confirmed;
            orderDb.Save(order);
        }

        private void UpdateInventory(Order order)
        {
            var inventoryDb = new InventoryDb(_efContext);
            foreach (var orderDetail in order.OrderDetails)
            {
                var inventory = inventoryDb.GetByBookId(orderDetail.Book.Id);
                inventory.DecreaseBy(orderDetail.Quantity);
                inventoryDb.Save(inventory);
            }
        }

        private void UpdateCustomerCredit(Order order)
        {
            var customerDb = new CustomerDb(_daContext);
            var customer = customerDb.GetById(order.Customer.Id);
            customer.DecreaseCreditLimitBy(order.GetGrandTotal());
            customerDb.AddOrUpdate(customer);

            customerDb.Save();
        }
    }
}
