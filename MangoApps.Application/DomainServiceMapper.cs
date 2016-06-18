using MangoApps.Domain.Customers;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Application
{
    public static class DomainServiceMapper<TEntity>
    {
        static IUnityContainer container = null;

        public static TEntity Create(string Type)
        {
            if (container == null)
            {
                container = new UnityContainer();

                container.RegisterType<CustomerBase, CustomerPKP>("PKP");
                container.RegisterType<CustomerBase, CustomerNonPKP>("NonPKP");

            }
            return container.Resolve<TEntity>(Type.ToString());
        }

    }
}
