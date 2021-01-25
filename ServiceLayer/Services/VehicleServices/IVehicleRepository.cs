using DomainLayer;
using System.Collections.Generic;

namespace ServiceLayer.Services.VehicleServices
{
    public interface IVehicleRepository
    {
        void Add(IVehicle customer);
        void Update(IVehicle customer);
        void Delete(IVehicle customer);
        IEnumerable<Vehicle> GetAll();
        Vehicle GetById(int id);
    }
}
