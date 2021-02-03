using DomainLayer.Vehicles;
using System.Collections.Generic;

namespace InfrastructureLayer.Repositories
{
    public interface IVehicleRepository
    {
        void Add(Vehicle vehicle);
        void Update(Vehicle vehicle);
        void Delete(Vehicle vehicle);
        IEnumerable<Vehicle> GetAll();
        IEnumerable<Vehicle> GetRented();
        IEnumerable<Vehicle> GetNotRented();
        IEnumerable<Vehicle> Query(string query);

        Vehicle GetByRego(string rego);


    }
}
