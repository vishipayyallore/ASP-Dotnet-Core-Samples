using System;
using System.Collections.Generic;

namespace Sales.Data.Core.Models
{
    public class Product
    {
        public Product() { }

        #region Properties
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public decimal Rating { get; set; }

        public string Link { get; set; }

        public int PurchaseByCount { get; set; }

        public int LikesCount { get; set; }

        public string Tags { get; set; }
        #endregion
    }
}
