using DomainLayer.Customers;
using DomainLayer.Rented;
using DomainLayer.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace CarRentals
{
    public class Context : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rented> Rented{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8EUPV7O.\SQLEXPRESS;Database=CarRentalsDB;Trusted_Connection=True;");
        }

    }
}
