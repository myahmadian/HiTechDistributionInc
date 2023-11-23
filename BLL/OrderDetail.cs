using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiTechDistributionInc.BLL
{
    public class OrderDetail
    {
        public const int MIN_QUANTITY = 1;

        public OrderDetail()
        {
            Quantity = MIN_QUANTITY;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual Order Order { get; set; }

        public virtual Book Book { get; set; }

        public int Quantity { get; set; }

        public decimal Total
        {
            get
            {
                return Quantity * Book.UnitPrice;
            }
        }
    }
}