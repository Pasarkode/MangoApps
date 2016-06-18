using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Domain.Customers
{
    public class CustomerPKP : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address is required");
            }
            if (Gender.Length == 0)
            {
                throw new Exception("Gender is required");
            }
            if (PKPStatus.Length == 0)
            {
                throw new Exception("PKPStatus is required");
            }
            if (Tempo > 30)
            {
                throw new Exception("Tempo should not be more then 30");
            }
            if (Discount >= 50m)
            {
                throw new Exception("Tempo should not be more then 50%");
            }
        }

        public override string PKPStatus
        {
            get
            {
                return "PKP";
            }
            set
            {
                _pkpStatus = value;
            }
        }
    }

    public class CustomerNonPKP : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address is required");
            }
            if (Gender.Length == 0)
            {
                throw new Exception("Gender is required");
            }
            if (PKPStatus.Length == 0)
            {
                throw new Exception("PKPStatus is required");
            }
            if (Tempo >= 10)
            {
                throw new Exception("Tempo should not be more then 10");
            }
            if (Discount >= 10m)
            {
                throw new Exception("Tempo should not be more then 10%");
            }
        }
        public override string PKPStatus
        {
            get
            {
                return "NonPKP";
            }
            set
            {
                _pkpStatus = value;
            }
        }
    }

}
