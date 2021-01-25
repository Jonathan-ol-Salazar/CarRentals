using CarRentals;
using DomainLayer;
using InfrastructureLayer.Repositories;
using System;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Context context = new Context();
            CustomerRepository customerRepository = new CustomerRepository(context);

            Customer customer = new Customer
            {
                FirstName = "Bob",
                LastName = "Fog"
            };

            customerRepository.Add(customer);


            Console.WriteLine("Hello World!");

            VehicleRepository vehicleRepository = new VehicleRepository(context);

            Vehicle vehicle = new Vehicle
            {
                VehicleRego = "Yeet",
                Make = "Ferrari",
                Model= "458 Pista"
            };

            vehicleRepository.Add(vehicle);
        }
    }
}
