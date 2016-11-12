using System;
using System.Collections.Generic;

namespace HealthClubs.Services.Api.DAL.Contracts
{

    public interface IBusinessRepository : IDisposable
    {
        IEnumerable<Business> GetBusinessEntities();
    }

}
