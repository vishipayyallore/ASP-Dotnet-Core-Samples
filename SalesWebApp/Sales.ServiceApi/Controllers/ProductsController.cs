using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sales.ServiceApi.Data;
using Sales.ServiceApi.Data.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Sales.ServiceApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {

        #region Variables.
        private readonly ECommerceDbContext _dbContext;
        #endregion

        #region Methods.
        public ProductsController(ECommerceDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<ProductsViewModel> Get()
        {
            return _dbContext.ProductsListViewModels.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion
    }
}
