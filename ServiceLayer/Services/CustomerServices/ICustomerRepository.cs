using DomainLayer;
using System.Collections.Generic;

namespace ServiceLayer.Services.CustomerServices
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
