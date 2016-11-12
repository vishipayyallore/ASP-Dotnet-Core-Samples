using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthClubs.Data.Core.Models;

namespace HealthClubs.Services.Api.DAL.ViewModels
{
    public class BusinessesViewModel
    {

        public BusinessesViewModel() { }

        #region Properties
        public Guid Id { get; set; }

        public List<Business> Businesses { get; set; }
        #endregion
    }
}
