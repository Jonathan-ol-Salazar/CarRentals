using System;
using System.Collections.Generic;
using DomainLayer;
using DomainLayer.Customers;
using InfrastructureLayer.Repositories;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerRepository
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Add(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerRepository.Delete(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public void Update(Customer customer)
        {
            _customerRepository.Update(customer);
        }
    }
}
