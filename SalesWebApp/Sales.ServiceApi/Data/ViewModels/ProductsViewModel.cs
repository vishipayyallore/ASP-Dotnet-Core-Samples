using System;
using System.Collections.Generic;
using Sales.Data.Core.Models;

namespace Sales.ServiceApi.Data.ViewModels
{
    public class ProductsViewModel
    {
        #region Properties
        public Guid Id { get; set; }

        public List<Product> Products { get; set; }
        #endregion
    }
}
