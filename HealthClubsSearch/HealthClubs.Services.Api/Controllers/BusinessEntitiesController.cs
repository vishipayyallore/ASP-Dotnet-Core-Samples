using System.Collections.Generic;
using HealthClubs.Services.Api.DAL.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HealthClubs.Services.Api.Controllers
{
    [Route("api/[controller]")]
    public class BusinessEntitiesController : Controller
    {

        private IBusinessRepository _businessRepository;

        public BusinessEntitiesController(IBusinessRepository businessRepository)
        {
            _businessRepository = businessRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var businessEntities =_businessRepository.GetBusinessEntities();
            return new string[] { "value1", "value2" };
        }

    }
}
