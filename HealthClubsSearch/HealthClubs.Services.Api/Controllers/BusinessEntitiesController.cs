using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HealthClubs.Data.Store.Contracts;

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
    }
}
