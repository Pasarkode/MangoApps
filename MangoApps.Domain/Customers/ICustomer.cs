using MyandFramework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Domain
{
    public interface ICustomer : IEntityBase
    {
        string CustomerName { get; set; }
        string Gender { get; set; }
        string Address { get; set; }
        string PKPStatus { get; set; }
        int Tempo { get; set; }
        decimal Discount { get; set; }
    }
}
