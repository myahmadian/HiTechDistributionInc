using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.BLL
{
    // Aggregate root
    public class Order
    {
        public const decimal TAX_RATE = 0.15M;
        public const decimal MIN_PAYMENT = 0;

        public Order()
        {
            OrderDate = DateTime.Today;
            OrderDetails = new List<OrderDetail>();
            Status = OrderStatus.Pending;
            IsCanceled = false;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShippingDate { get; set; }

        public virtual Customer Customer { get; set; }

        public OrderStatus Status { get; set; }

        public bool IsCanceled { get; set; }

        public decimal? Payment { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public bool IsNew
        {
            get
            {
                return Id <= 0;
            }
        }

        public bool IsConfirmed
        { 
            get
            {
                if (Status == OrderStatus.Confirmed)
                {
                    return true;
                }
                return false;
            }
        }

        public bool CanChange
        {
            get
            {
                if (IsCanceled)
                {
                    return false;
                }
                if (IsConfirmed)
                {
                    return false;
                }
                return true;
            }
        }

        public bool CanConfirm
        {
            get
            {
                if (!CanChange)
                {
                    return false;
                }
                if (Payment == null || Payment == 0)
                {
                    return false;
                }
                if (Payment != GetGrandTotal())
                {
                    return false;
                }
                if (ShippingDate == null || ShippingDate != DateTime.Today)
                {
                    return false;
                }
                return true;
            }
        }

        public decimal GetOrderTotal()
        {
            decimal total = 0;
            foreach (var orderDetail in OrderDetails)
            {
                total = total + orderDetail.Total;
            }
            return total;
        }

        public decimal GetTaxTotal()
        {
            return GetOrderTotal() * TAX_RATE;
        }

        public decimal GetGrandTotal()
        {
            decimal grandTotal = GetTaxTotal() + GetOrderTotal();
            return decimal.Round(grandTotal, 2, MidpointRounding.AwayFromZero);
        }

        public void AddOrderDetail(Book book, int quantity)
        {
            var orderDetail = new OrderDetail();
            orderDetail.Order = this;
            orderDetail.Book = book;
            orderDetail.Quantity = quantity;

            OrderDetails.Add(orderDetail);
        }

        public void DeleteOrderDetail(int index)
        {
            var orderDetail = OrderDetails[index];
            OrderDetails.Remove(orderDetail);
        }
    }
}
