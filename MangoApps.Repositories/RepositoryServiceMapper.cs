using MangoApps.Repositories.Customers;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Repositories
{
    public static class RepositoryServiceMapper<TRepo>
    {
        static IUnityContainer container;
        public static TRepo getRepo(string Daltype)
        {
            if (container == null)
            {
                container = new UnityContainer();
                container.RegisterType<ICustomerRepository, CustomerRepository>("Customer");

            }
            return (TRepo)container.Resolve<TRepo>(Daltype);
        }
    }
}
