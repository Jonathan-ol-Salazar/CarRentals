using System;
using System.Collections.Generic;
using DomainLayer;
using ServiceLayer.Services.CustomerServices;

namespace InfrastructureLayer.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ICustomer customer)
        {
            throw new NotImplementedException();
        }


    }
}
