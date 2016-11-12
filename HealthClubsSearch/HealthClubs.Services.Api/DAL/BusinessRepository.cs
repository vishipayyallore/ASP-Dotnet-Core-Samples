using System;
using System.Collections.Generic;
using System.Linq;
using HealthClubs.Services.Api.DAL.Contracts;
using HealthClubs.Data.Core.Models;

namespace HealthClubs.Services.Api.DAL
{
    public class BusinessRepository : IBusinessRepository
    {

        #region Variables.
        private readonly BusinessDbContext _businessDb;
        private bool _disposed = false;
        #endregion

        public BusinessRepository(BusinessDbContext businessDb)
        {
            _businessDb = businessDb;
        }

        #region Methods.
        public IEnumerable<Business> GetBusinessEntities()
        {
            return _businessDb.Businesses.ToList();
        }
        #endregion

        #region Disposing Methods.
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _businessDb.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
