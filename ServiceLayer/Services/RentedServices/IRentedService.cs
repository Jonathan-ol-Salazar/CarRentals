using InfrastructureLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services
{
    public interface IRentedService : IRentedRepository
    {
        double TotalDailyRate();
    }
}
