using System;

namespace HealthClubs.Data.Core.Models
{
    public class Shop
    {
        public Shop() { }

        #region Properties
        public Guid Id { get; set; }

        public string BusinessName { get; set; }

        public string BusinessType { get; set; }

        public string Link { get; set; }

        public string Address { get; set; }

        public decimal Rating { get; set; }
        #endregion
    }
}
