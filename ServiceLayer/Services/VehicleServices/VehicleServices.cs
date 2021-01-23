using CarRentalsManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services.VehicleServices
{
    class VehicleServices : IVehicleRepository
    {
        private IVehicleRepository _vehicleRepository;

        public VehicleServices(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public void Add(IVehicle customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(IVehicle customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> GetAll()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IVehicle customer)
        {
            throw new NotImplementedException();
        }
    }
}
