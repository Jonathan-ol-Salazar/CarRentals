using System.Collections.Generic;
using System.Linq;
using CarRentals;
using DomainLayer;
using DomainLayer.Customers;

namespace InfrastructureLayer.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private Context _context;
        public CustomerRepository(Context context)
        {
            _context = context;
        }


        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            Customer customer2Delete = _context.Customers.Find(customer.CustomerID);
            _context.Customers.Remove(customer2Delete);
            _context.SaveChanges();

        }
        public void Update(Customer customer)
        {
            Customer customer2Update = _context.Customers.Find(customer.CustomerID);
            customer2Update = customer;
            _context.SaveChanges();
        }
        public Customer GetById(int id)
        {
            Customer customer = _context.Customers.Find(id);
            return customer;

        }
        public IEnumerable<Customer> GetAll()
        {
            var customer = _context.Customers;
            return customer;

        }

        public IEnumerable<Customer> GetNotRenting()
        {
            var customer = _context.Customers.Where(x => x.IsRenting == false);
            return customer;
        }
    }
}
