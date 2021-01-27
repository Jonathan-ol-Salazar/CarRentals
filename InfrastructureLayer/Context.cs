using DomainLayer.Customers;
using DomainLayer.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace CarRentals
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8EUPV7O.\SQLEXPRESS;Database=CarRentalsDB;Trusted_Connection=True;");
        }

    }
}
