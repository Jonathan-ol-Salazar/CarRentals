using CarRentals;
using DomainLayer;
using DomainLayer.Vehicles;
using System;
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

        public IEnumerable<Vehicle> Query(string query)
        {
            // for enums
            // check if query is a enum before searching context

            // for ints /doubles
            // check if query is correct format

            // for bools
            // check if query is a valid boolean

            var x = (_context.Vehicles.Where(x => x.Make == query));
            var vehicles = _context.Vehicles.Where(x => x.Rego == query);
            vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.Make == query));
            vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.Model == query));
            vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.Year == query));
            vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.Colour == query));
            

            // Enum
            if(Enum.IsDefined(typeof(ClassType), query))
            {
                vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.ClassType == (ClassType)Enum.Parse(typeof(ClassType), query)));
            }
            if(Enum.IsDefined(typeof(TransmissionType), query))
            {
                vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.TransmissionType == (TransmissionType)Enum.Parse(typeof(TransmissionType), query)));
            }
            if(Enum.IsDefined(typeof(FuelType), query))
            {
                vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.FuelType == (FuelType)Enum.Parse(typeof(FuelType), query)));
            }

            // Int or Double
            if(int.TryParse(query, out int intNumber))
            {
                vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.Seats == int.Parse(query)));
            }
            if (double.TryParse(query, out double doubleNumber))
            {
                vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.DailyRate == double.Parse(query)));
            }

            // Boolean
            if (Boolean.TryParse(query, out bool boolStringSeats))
            {
                vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.Sunroof == bool.Parse(query)));
            }
            if (Boolean.TryParse(query, out bool boolStringSunroof))
            {
                vehicles = vehicles.Concat(_context.Vehicles.Where(x => x.GPS == bool.Parse(query)));
            }



            return vehicles;
        }
    }
}
