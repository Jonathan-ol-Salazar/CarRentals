using System;
using System.Collections.Generic;
using System.Text;
using CarRentalsManagement;
using ServiceLayer.Services.CustomerServices;

namespace InfrastructureLayer.Repositories.Customer
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

        public IEnumerable<CarRentalsManagement.Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public CarRentalsManagement.Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ICustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}
