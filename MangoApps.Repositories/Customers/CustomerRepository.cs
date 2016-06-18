using MangoApps.Domain.Customers;
using MyandFramework.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Repositories.Customers
{
    public class CustomerRepository : Repository<CustomerBase, MangoContext>, ICustomerRepository, IDisposable
    {
        public CustomerBase GetCustPkpByName(string name)
        {
            return context.Customers.Single(x => x.CustomerName == name && x.PKPStatus == "PKP");
        }

        public CustomerBase GetCustNonPkpByName(string name)
        {
            return context.Customers.Single(x => x.CustomerName == name && x.PKPStatus == "NonPKP");
        }

        public IEnumerable<CustomerBase> SearchCustPkp(string key)
        {
            return context.Customers.Where(x => x.CustomerName.Contains(key) && x.PKPStatus == "PKP");
        }

        public IEnumerable<CustomerBase> SearchCustNonPkp(string key)
        {
            return context.Customers.Where(x => x.CustomerName.Contains(key) && x.PKPStatus == "NonPKP");
        }

        protected override DbSet<CustomerBase> GetDbSet()
        {
            return context.Customers;
        }

        public IEnumerable<CustomerBase> Search(string key)
        {
            return context.Customers.Where(x => x.CustomerName.Contains(key) || x.PKPStatus == key);
        }
    }
}
