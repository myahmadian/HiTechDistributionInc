using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.DAL
{
    public class DataAdapterDbContext
    {
        public CustomerDbSet Customers { get; private set; }

        public DataAdapterDbContext()
        {
            Customers = new CustomerDbSet();
        }

        public void SaveChanges()
        {
            Customers.SaveChanges();
        }
    }
}
