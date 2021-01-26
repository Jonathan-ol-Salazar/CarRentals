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

        public void Add(Vehicle vehicle)
        {
            _vehicleRepository.Add(vehicle);
        }

        public void Delete(Vehicle vehicle)
        {
            _vehicleRepository.Delete(vehicle);
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _vehicleRepository.GetAll();
        }

        public Vehicle GetById(int id)
        {
            return _vehicleRepository.GetById(id);
        }

        public void Update(Vehicle vehicle)
        {
            _vehicleRepository.Update(vehicle);
        }
    }
}
