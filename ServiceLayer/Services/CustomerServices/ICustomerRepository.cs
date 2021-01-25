using DomainLayer;
using System.Collections.Generic;

namespace ServiceLayer.Services.CustomerServices
{
    public interface ICustomerRepository
    {
        void Add(ICustomer customer);
        void Update(ICustomer customer);
        void Delete(ICustomer customer);
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);

    }
}
