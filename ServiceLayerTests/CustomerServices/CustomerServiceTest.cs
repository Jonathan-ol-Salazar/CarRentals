using DomainLayer.Customers;
using InfrastructureLayer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayerTests.CustomerServices
{
    [TestClass]
    public class CustomerServiceTest
    {
        //[TestMethod]
        //public void Add_AddingNewCustomer_ReturnRepoWithCustomer()
        //{
        //    Customer customer = new Customer
        //    {
        //        FirstName = "bob",
        //        LastName = "fog",
        //        DOB = "000/000/000",
        //        GenderType = (GenderType)Enum.Parse(typeof(GenderType), "Male"),
        //        TitleType = (TitleType)Enum.Parse(typeof(TitleType), "Mr")
        //    };
        //    List<Customer> customerList = new List<Customer> { customer };


        //    var repo = new Mock<ICustomerRepository>();
        //    //repo.Setup(cr => cr.Add(customer)).Callback(() => {
        //    //    customerList.Add(customer);
        //    //});

        //    repo.Setup(r => r.Add(customer));

        //    //repo.Setup(x => x.Add(It.IsAny<Customer>())).Callback((Customer customer) => { customerList.Add(customer); });

        //    //repo.Setup(cr => cr.GetAll()).Returns(() => { return customerList; });

        //    CustomerService customerService = new CustomerService(repo.Object);

        //    var result = customerService.GetAll().ToList();
        //    CollectionAssert.AreEquivalent(customerList, result);
        //}


        [TestMethod]
        public void GetAll_WhenCalled_ReturnAllEntries()
        {
            List<Customer> customerList = new List<Customer> { new Customer{
                FirstName = "bob",
                LastName = "fog",
                DOB = "000/000/000",
                GenderType = (GenderType)Enum.Parse(typeof(GenderType), "Male"),
                TitleType = (TitleType)Enum.Parse(typeof(TitleType), "Mr" )
            }};

            var repo = new Mock<ICustomerRepository>();
            repo.Setup(r => r.GetAll()).Returns(customerList);

            CustomerService customerService = new CustomerService(repo.Object);
            var result = customerService.GetAll().ToList();

            CollectionAssert.AreEquivalent(customerList, result);
        }

        [TestMethod]
        public void Delete_DeletingCustomerInRepoWithSingleItem_ReturnEmptyRepo()
        {
            Customer customer = new Customer
            {
                CustomerID = 1,
                FirstName = "bob",
                LastName = "fog",
                DOB = "000/000/000",
                GenderType = (GenderType)Enum.Parse(typeof(GenderType), "Male"),
                TitleType = (TitleType)Enum.Parse(typeof(TitleType), "Mr")
            };

            var repo = new Mock<ICustomerRepository>();
            repo.Setup(r => r.Add(customer));

            CustomerService customerService = new CustomerService(repo.Object);
            customerService.Delete(customer);

            CollectionAssert.AreEquivalent(new List<Customer>(), customerService.GetAll().ToList());

        }

    }
}
