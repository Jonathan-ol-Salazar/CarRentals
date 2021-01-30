using InfrastructureLayer.Repositories;
using System.Collections.Generic;

namespace ServiceLayer.Services
{
    public interface ICustomerService : ICustomerRepository
    {
        List<string> GetNotRentingList();

    }
}
