using CarRentalsManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services.VehicleServices
{
    interface IVehicleRepository
    {
        void Add(IVehicle customer);
        void Update(IVehicle customer);
        void Delete(IVehicle customer);
        IEnumerable<Vehicle> GetAll();
        Vehicle GetById(int id);
    }
}
