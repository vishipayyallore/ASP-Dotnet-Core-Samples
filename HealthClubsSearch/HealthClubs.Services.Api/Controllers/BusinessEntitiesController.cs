using System;
using System.Collections.Generic;
using System.Linq;
using HealthClubs.Services.Api.DAL.Contracts;
using HealthClubs.Services.Api.DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HealthClubs.Services.Api.Controllers
{
    [Route("api/[controller]")]
    public class BusinessEntitiesController : Controller
    {

        private readonly IBusinessRepository _businessRepository;

        public BusinessEntitiesController(IBusinessRepository businessRepository)
        {
            _businessRepository = businessRepository;
        }

        // GET api/BusinessEntities
        [HttpGet]
        public JsonResult Get()
        {
            string errorOutput;

            try
            {
                var businessesList = new BusinessesViewModel
                {
                    Businesses = _businessRepository.GetBusinessEntities().ToList()
                };
                return Json(businessesList);
            }
            catch (Exception errorObject)
            {
                errorOutput = string.Format("{ \"Error Message:\": {0} }", errorObject.StackTrace);
            }
            return Json(errorOutput);
        }

    }
}
