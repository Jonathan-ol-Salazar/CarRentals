using System.Collections.Generic;
using DomainLayer.Customers;
using InfrastructureLayer.Repositories;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerRepository, ICustomerService
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

        public List<string> GetNotRentingList()
        {
            var customers = _customerRepository.GetNotRenting();
            List<string> customersList = new List<string>();

            foreach (Customer customer in customers)
            {
                customersList.Add(customer.CustomerID.ToString() + " - " + customer.FirstName + " " + customer.LastName);
            }

            return customersList;

        }

        public void Update(Customer customer)
        {
            _customerRepository.Update(customer);
        }

        public IEnumerable<Customer> GetNotRenting()
        {
            return _customerRepository.GetNotRenting();
        }
    }
}
