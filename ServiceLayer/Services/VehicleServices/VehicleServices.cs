using DomainLayer;
using InfrastructureLayer.Repositories;
using System;
using System.Collections.Generic;

namespace ServiceLayer.Services.VehicleServices
{
    class VehicleServices : IVehicleRepository
    {
        private IVehicleRepository _vehicleRepository;

        public VehicleServices(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public void Add(Vehicle customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Vehicle customer)
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

        public void Update(Vehicle customer)
        {
            throw new NotImplementedException();
        }
    }
}
