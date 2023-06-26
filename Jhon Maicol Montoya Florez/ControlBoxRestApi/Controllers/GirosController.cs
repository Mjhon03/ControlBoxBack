using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GirosService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControlBoxRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GirosController : ControllerBase
    {
        GirosClient girosClient = new GirosClient();
        // GET: api/<GirosController>
        [HttpGet]
        public IEnumerable<giro> Get([FromQuery] giro gir)
        {
            return girosClient.GetDataGiros(gir);
        }

        // GET api/<GirosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GirosController>
        [HttpPost]
        public string Post([FromBody] giro gir)
        {
            return girosClient.AddDataGiros(gir);
        }

        // PUT api/<GirosController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] giro gir)
        {
            return girosClient.UpdateDataGiros(gir);
        }

        // DELETE api/<GirosController>/5
        [HttpDelete()]
        public string Delete([FromQuery] giro gir)
        {
            return girosClient.DeleteGiros(gir);
        }
    }
}
