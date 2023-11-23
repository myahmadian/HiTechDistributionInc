using HiTechDistributionInc.BLL;
using System;

namespace HiTechDistributionInc.BLL
{
    public class InventoryValidator
    {
        public string Validate(Inventory inventory)
        {
            if (inventory == null)
            {
                throw new ArgumentNullException(nameof(inventory));
            }

            if (inventory.Book == null)
            {
                return "Please provide a book";
            }

            if (inventory.QuantityOnHand < Inventory.MIN_QUANTITY_ON_HAND)
            {
                return $"Quantity on hand should be greater than {Inventory.MIN_QUANTITY_ON_HAND}";
            }

            return null;
        }
    }
}