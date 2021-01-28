﻿using DomainLayer;
using DomainLayer.Vehicles;
using InfrastructureLayer.Repositories;
using System;
using System.Collections.Generic;

namespace ServiceLayer.Services
{
    public class VehicleService : IVehicleRepository
    {
        private IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
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

        public Vehicle GetByRego(string rego)
        {
            return _vehicleRepository.GetByRego(rego);
        }

        public void Update(Vehicle vehicle)
        {
            _vehicleRepository.Update(vehicle);
        }
    }
}
