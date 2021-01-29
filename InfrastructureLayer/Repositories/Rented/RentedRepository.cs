using System;
using System.Collections.Generic;
using System.Text;
using CarRentals;
using DomainLayer.Rented;

namespace InfrastructureLayer.Repositories
{
    public class RentedRepository : IRentedRepository
    {
        private Context _context;
        public RentedRepository(Context context)
        {
            _context = context;
        }


        public void Add(Rented rented)
        {
            _context.Rented.Add(rented);
            _context.SaveChanges();
        }

        public void Delete(Rented rented)
        {
            Rented rented2Delete = _context.Rented.Find(rented.RentID);
            _context.Rented.Remove(rented2Delete);
            _context.SaveChanges();

        }
        public void Update(Rented rented)
        {
            Rented rented2Update = _context.Rented.Find(rented.RentID);
            rented2Update = rented;
            _context.SaveChanges();
        }
        public Rented GetById(int id)
        {
            Rented rented = _context.Rented.Find(id);
            return rented;

        }
        public IEnumerable<Rented> GetAll()
        {
            var renteds = _context.Rented;
            return renteds;

        }





    }
}
