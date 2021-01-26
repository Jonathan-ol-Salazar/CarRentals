using DomainLayer;
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
