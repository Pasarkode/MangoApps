using MyandFramework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Domain.Customers
{
    public abstract class CustomerBase : EntityBase, ICustomer
    {
        public CustomerBase()
        {
            init();
        }

        public virtual void Validate() {
            throw new NotImplementedException();
        }

        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Tempo { get; set; }
        public decimal Discount { get; set; }

        protected string _pkpStatus = "X";
        public virtual string PKPStatus
        {
            get
            {
                return "X";
            }
            set
            {
                _pkpStatus = value;
            }
        }

        public void init()
        {
            CustomerName = "";
            Gender = "";
            Address = "";
            PKPStatus = "";
            Tempo = 0;
            Discount = 0m;
        }

    }
}
