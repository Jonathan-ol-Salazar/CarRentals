using DomainLayer.Rented;
using InfrastructureLayer.Repositories;
using System.Collections.Generic;

namespace ServiceLayer.Services
{
    public class RentedService : IRentedRepository
    {
        private IRentedRepository _rentedRepository;

        public RentedService(IRentedRepository rentedRepository)
        {
            _rentedRepository = rentedRepository;
        }

        public void Add(Rented rented)
        {
            _rentedRepository.Add(rented);
        }

        public void Delete(Rented rented)
        {
            _rentedRepository.Delete(rented);
        }

        public IEnumerable<Rented> GetAll()
        {
            return _rentedRepository.GetAll();
        }

        public Rented GetById(int id)
        {
            return _rentedRepository.GetById(id);
        }

        public void Update(Rented rented)
        {
            _rentedRepository.Update(rented);
        }
    }
}
