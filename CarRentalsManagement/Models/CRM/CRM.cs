using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class CRM : Customer
    {

        // Globals
        List<Customer> customers;
        string crmFile;

        public CRM()
        {

        }
        public bool AddCustomer(Customer customer)
        {
            return false;
        }
        public bool RemoveCustomer(Customer customer, Fleet fleet)
        {
            return false;

        }
        public bool RemoveCustomer(int customerID, Fleet fleet)
        {
            return false;

        }
        public List<Customer> GetCustomers()
        {
            return new List<Customer>();
        }
        public void SaveToFile()
        {

        }
        public void LoadFromFile()
        {

        }
    }
}
