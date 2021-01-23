using CarRentalsManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services.CustomerServices
{
    class CustomerServices : ICustomerRepository
    {
        private ICustomerRepository _customerRepository;

        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

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
