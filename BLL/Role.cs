using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiTechDistributionInc.BLL
{
    // Aggregate root
    public class Role
    {
        public const string MIS_MANAGER_ROLE = "MIS Manager";
        public const string SALES_MANAGER_ROLE = "Sales Manager";
        public const string INVENTORY_MANAGER_ROLE = "Inventory Manager";
        public const string ORDER_CLERK_ROLE = "Order Clerk";
        public const string ACCOUNTANT_ROLE = "Accountant";

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsNew
        {
            get
            {
                return Id <= 0;
            }
        }

        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}