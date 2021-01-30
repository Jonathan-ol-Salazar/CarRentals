using CarRentals;
using DomainLayer;
using DomainLayer.Vehicles;
using System.Collections.Generic;
using System.Linq;

namespace InfrastructureLayer.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private Context _context;
        public VehicleRepository(Context context)
        {
            _context = context;
        }


        public void Add(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public void Delete(Vehicle vehicle)
        {
            Vehicle vehicle2Delete = _context.Vehicles.Find(vehicle.Rego);
            _context.Vehicles.Remove(vehicle2Delete);
            _context.SaveChanges();

        }
        public void Update(Vehicle vehicle)
        {
            Vehicle vehicle2Update = _context.Vehicles.Find(vehicle.Rego);
            vehicle2Update = vehicle;
            _context.SaveChanges();
        }
        public Vehicle GetByRego(string rego)
        {
            Vehicle vehicle = _context.Vehicles.Find(rego);
            return vehicle;

        }
        public IEnumerable<Vehicle> GetAll()
        {
            var vehicles = _context.Vehicles;
            return vehicles;

        }
        public IEnumerable<Vehicle> GetRented()
        {
            var vehicles = _context.Vehicles.Where(x => x.IsRented == true);
            return vehicles;
        }
        public IEnumerable<Vehicle> GetNotRented()
        {
            var vehicles = _context.Vehicles.Where(x => x.IsRented == false);
            return vehicles;
        }
    }
}
