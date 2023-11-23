using HiTechDistributionInc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.BLL
{
    public class OrderValidator
    {
        private readonly EntityFrameworkDbContext _context;

        public OrderValidator()
        {
            _context = new EntityFrameworkDbContext();
        }

        public string Validate(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            var orderDb = new OrderDb(_context);
            var originalOrder = orderDb.GetById(order.Id);

            if (order.IsNew)
            {
                // User is trying to create a canceled order which is not allowed
                if (order.IsCanceled)
                {
                    return "Cannot create a canceled order";
                }
            }
            else
            {
                // We won't allow any modification to either a canceled or a confirmed order.
                if (!originalOrder.CanChange)
                {
                    return "Cannot change the order";
                }
                else
                {
                    // User is trying to cancel the order and we should allow regardless of any validation error the order might have
                    // This is safe because a canceled order never updates the inventory and credit limit
                    if (order.IsCanceled)
                    {
                        return null;
                    }

                    // Cannot change order date
                    if (order.OrderDate != originalOrder.OrderDate)
                    {
                        return "Cannot change order date";
                    }

                    // Cannot change customer
                    if (order.Customer.Id != originalOrder.Customer.Id)
                    {
                        return "Cannot change customer";
                    }
                }
            }

            // User is trying to confirm the order which is not allowed
            // An order is only confirmed through OrderOperation
            if (order.IsConfirmed)
            {
                return "Invalid order status";
            }

            // Order date cannot be in the past or future
            if (order.OrderDate == default)
            {
                return "Please enter Order Date";
            }
            else if (order.OrderDate != DateTime.Today)
            {
                return "Order date is invalid";
            }

            // An order is always created for a customer
            if (order.Customer == null)
            {
                return "Please enter the Customer";
            }

            // There is no way an order has no details
            if (order.OrderDetails == null || order.OrderDetails.Count == 0)
            {
                return $"Order details must be provided";
            }
            else
            {
                // Quantity of each order detail should be valid
                foreach (var orderDetail in order.OrderDetails)
                {
                    if (orderDetail.Quantity < OrderDetail.MIN_QUANTITY)
                    {
                        return $"Quantity for {orderDetail.Book} is invalid";
                    }
                }

                // Payment should match the grand total if user enters any payment
                if (order.Payment != null && order.Payment != order.GetGrandTotal())
                {
                    return "Invalid payment";
                }

                if (order.ShippingDate != null)
                {
                    // Shipping date can only match the current date and we cannot ship in the past or future
                    // This is because we need to update the inventory and customer credit limit
                    // It is impossible to do so if we are shipping in the past or future
                    // When a clerk ships the order he/she updates the shipping date
                    // This will update the inventory and customer credit limit respectively
                    if (order.ShippingDate != DateTime.Today)
                    {
                        return "Invalid shipping date";
                    }

                    // If the grand total exceeds the customer credit limit the order cannot ship
                    if (order.Customer.CreditLimit < order.GetGrandTotal())
                    {
                        return "Insufficient fund";
                    }

                    // We won't allow shipping of an unpaid order
                    if (order.Payment == null)
                    {
                        return "Cannot ship an unpaid order";
                    }

                    // If the inventory for either of the items included in order details is insufficient the order cannot ship
                    var inventoryDb = new InventoryDb(_context);
                    foreach (var orderDetail in order.OrderDetails)
                    {
                        var inventory = inventoryDb.GetByBookId(orderDetail.Book.Id);
                        if (inventory.QuantityOnHand < orderDetail.Quantity)
                        {
                            return $"{orderDetail.Book} has no inventory";
                        }
                    }
                }
            }
            return null;
        }
    }
}
