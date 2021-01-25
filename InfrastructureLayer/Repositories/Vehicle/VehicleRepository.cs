using CarRentals;
using DomainLayer;
using ServiceLayer.Services.VehicleServices;
using System;
using System.Collections.Generic;

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
            Vehicle vehicle2Delete = _context.Vehicles.Find(vehicle.VehicleRego);
            _context.Vehicles.Remove(vehicle2Delete);
            _context.SaveChanges();

        }
        public void Update(Vehicle vehicle)
        {
            Vehicle vehicle2Update = _context.Vehicles.Find(vehicle.VehicleRego);
            vehicle2Update = vehicle;
            _context.SaveChanges();
        }
        public Vehicle GetById(int id)
        {
            Vehicle vehicle = _context.Vehicles.Find(id);
            return vehicle;

        }
        public IEnumerable<Vehicle> GetAll()
        {
            var vehicle = _context.Vehicles;
            return vehicle;

        }






    }
}
