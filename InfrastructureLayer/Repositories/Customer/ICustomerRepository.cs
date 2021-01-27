using DomainLayer;
using DomainLayer.Customers;
using System.Collections.Generic;

namespace InfrastructureLayer.Repositories
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);

    }
}
