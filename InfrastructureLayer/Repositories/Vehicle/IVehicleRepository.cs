using DomainLayer;
using DomainLayer.Vehicles;
using System.Collections.Generic;

namespace InfrastructureLayer.Repositories
{
    public interface IVehicleRepository
    {
        void Add(Vehicle customer);
        void Update(Vehicle customer);
        void Delete(Vehicle customer);
        IEnumerable<Vehicle> GetAll();
        Vehicle GetById(int id);
    }
}
