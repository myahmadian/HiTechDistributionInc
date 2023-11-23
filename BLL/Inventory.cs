using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.BLL
{
    public class Inventory
    {
        public const int MIN_QUANTITY_ON_HAND = 0;

        public Inventory()
        {
            QuantityOnHand = MIN_QUANTITY_ON_HAND;
        }

        public int Id { get; set; }

        public virtual Book Book { get; set; }

        public int QuantityOnHand { get; set; }

        public void IncreaseBy(int quantity)
        {
            QuantityOnHand += quantity;
        }

        public void DecreaseBy(int quantity)
        {
            QuantityOnHand -= quantity;
        }
    }
}
