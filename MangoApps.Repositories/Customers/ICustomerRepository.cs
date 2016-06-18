using MangoApps.Domain.Customers;
using MyandFramework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Repositories.Customers
{
    public interface ICustomerRepository : IRepository<CustomerBase>, IDisposable
    {
        CustomerBase GetCustPkpByName(string name);
        CustomerBase GetCustNonPkpByName(string name);
        IEnumerable<CustomerBase> SearchCustPkp(string key);
        IEnumerable<CustomerBase> SearchCustNonPkp(string key);

    }
}
