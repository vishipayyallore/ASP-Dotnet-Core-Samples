using System;
using System.Collections.Generic;
using HealthClubs.Data.Core.Models;

namespace HealthClubs.Data.Store.Contracts
{

    public interface IBusinessRepository : IDisposable
    {
        IEnumerable<Business> GetBusinessEntities();
    }

}
