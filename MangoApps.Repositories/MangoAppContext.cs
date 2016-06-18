using MangoApps.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Repositories
{
    public class MangoContext : DbContext
    {
        public DbSet<CustomerBase> Customers { get; set; }

        public MangoContext()
	    //: base("Server=.\\SQLSERVER2012;Database=Myand;User Id=sa;Password=indramayu") <== Sample
            : base("Server=.\YourServer;Database=YourDB;User Id=YourUser;Password=YourPassword")
        {
        }
    }
}

