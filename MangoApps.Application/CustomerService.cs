using MangoApps.Domain.Customers;
using MangoApps.Repositories;
using MangoApps.Repositories.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Application
{
    public class CustomerService
    {
        ICustomerRepository _repo;
        IEnumerable<CustomerBase> data;

        public CustomerService(string type)
        {
            _repo = RepositoryServiceMapper<ICustomerRepository>.getRepo(type);
        }
        public CustomerBase Instance(string Type)
        {
            return DomainServiceMapper<CustomerBase>.Create(Type);
        }
        public IEnumerable<CustomerBase> GetAll()
        {
            data = _repo.GetAll();
            return data;
        }
        public CustomerBase GetCustPkpByName(string name)
        {
            return _repo.GetCustPkpByName(name);
        }
        public CustomerBase GetCustNonPkpByName(string name)
        {
            return _repo.GetCustNonPkpByName(name);
        }

        public IEnumerable<CustomerBase> SearchCustPkp(string key)
        {
            data = _repo.SearchCustPkp(key);
            return data;
        }

        public IEnumerable<CustomerBase> SearchCustNonPkp(string key)
        {
            data = _repo.SearchCustNonPkp(key);
            return data;
        }
        public IEnumerable<CustomerBase> Search(string key)
        {
            data = _repo.Search(key);
            return data;
        }
        public CustomerBase GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Save(CustomerBase baseObj)
        {
            baseObj.Validate();
            _repo.Save(baseObj);
        }
        public void Delete(CustomerBase baseObj)
        {
            _repo.Delete(baseObj);
        }
    }
}
