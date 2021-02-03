using DomainLayer.Customers;
using InfrastructureLayer.Repositories;
using Moq;
using System;
using System.Diagnostics.CodeAnalysis;
using NUnit;
using NUnit.Framework;

namespace ServiceLayer.Tests
{
    [ExcludeFromCodeCoverage]
    public class CustomerServiceTests
    {
        [Test]
        public void PassingTest()
        {
            Customer customer = new Customer
            {
                CustomerID = 1,
                TitleType = (TitleType)Enum.Parse(typeof(TitleType), "Mr"),
                FirstName = "",
                LastName = "",
                GenderType = (GenderType)Enum.Parse(typeof(GenderType), "Mr"),
                DOB = ""
            };

            var customerService = new Mock<ICustomerRepository>();
            customerService.Setup(x => x.Add(customer));
            var x = customerService.Object.GetById(customer.CustomerID);
            Assert.Equals(customer, customerService.Object.GetById(customer.CustomerID));
        }

    }
}
