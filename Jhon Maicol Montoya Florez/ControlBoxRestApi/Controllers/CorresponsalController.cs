using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CorresponsalService;
using System.Net.Http;
using System.Net.Http.Headers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControlBoxRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorresponsalController : ControllerBase
    {
        ActivityLogger logger = new ActivityLogger("./LogActivity.log");
        CorresponsalesClient corresponsalesClient = new CorresponsalesClient();
        // GET: api/<CorresponsalController>
        [HttpGet]
        public IEnumerable<corresponsal> Get()
        { 
            return corresponsalesClient.GetDataCorresponsal();
        }

        // GET api/<CorresponsalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CorresponsalController>
        [HttpPost]
        public string Post([FromBody] corresponsal cor)
        {
            return corresponsalesClient.AddDataCorresponsal(cor);
        }

        // PUT api/<CorresponsalController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] corresponsal cor)
        {
            return corresponsalesClient.UpdateDataCorresponsal(cor);
        }

        // DELETE api/<CorresponsalController>/5
        [HttpDelete("{id}")]
        public string Delete(corresponsal cor)
        {
            return corresponsalesClient.DeleteCorresponsal(cor);
        }
    }
}
