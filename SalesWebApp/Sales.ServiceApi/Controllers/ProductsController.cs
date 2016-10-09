using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
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
        public JsonResult Get()
        {
            var errorOutput = string.Empty;

            try
            {
                var productsList = new ProductsViewModel
                {
                    Products = _dbContext.Products.ToList()
                };
                return Json(productsList);
            }
            catch (Exception errorObject)
            {
                errorOutput = string.Format("{ \"Error Message:\": {0} }", errorObject.StackTrace);
            }
            return Json(errorOutput);
        }

        
        #endregion
    }
}
