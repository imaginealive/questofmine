using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using capcode;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    public class CalculateController : Controller
    {
        // GET api/values
        [HttpGet("{sum}")]
        public string Get(double sum)
        {
            var code = new Code();
            return code.calculate(sum);
        }

        // GET api/values/5
        [HttpGet("[action]/{id}")]
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
