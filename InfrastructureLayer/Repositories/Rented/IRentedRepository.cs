using System.Collections.Generic;
using DomainLayer.Rented;


namespace InfrastructureLayer.Repositories
{
    public interface IRentedRepository
    {
        void Add(Rented rented);
        void Update(Rented rented);
        void Delete(Rented rented);
        IEnumerable<Rented> GetAll();
        Rented GetById(int id);
    }
}
