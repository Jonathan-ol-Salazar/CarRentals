using InfrastructureLayer.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using DomainLayer.Models;

namespace ServicesLayer.Tests.Customer
{
    [ExcludeFromCodeCoverage]
    public class CustomerServicesDataAccessTests
    {
        public void PassingTest()
        {
            Customer cutomer = new Customer
            {

            }; 

            var customerService = new Mock<ICustomerRepository>();
            //customerService.Setup(x => x.Add())
        }
    }
}
