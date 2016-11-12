using System;
using System.Collections.Generic;
using HealthClubs.Data.Core.Models;

namespace HealthClubs.Services.Api.DAL.Contracts
{

    public interface IBusinessRepository : IDisposable
    {
        IEnumerable<Business> GetBusinessEntities();
    }

}
