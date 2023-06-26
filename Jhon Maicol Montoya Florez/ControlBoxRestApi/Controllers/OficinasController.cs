using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OficinasService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControlBoxRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OficinasController : ControllerBase
    {
        OficinasClient oficinasClient = new OficinasClient();
        // GET: api/<OficinasController>
        [HttpGet]
        public IEnumerable<oficina> Get()
        {
            return oficinasClient.GetDataOficinas();
        }

        // GET api/<OficinasController>/5
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IEnumerable<oficina> GetAllOficinas()
        {
            return oficinasClient.GetAllOficinas();
        }

        // POST api/<OficinasController>
        [HttpPost]
        public string Post([FromBody] oficina ofi)
        {
            return oficinasClient.AddDataOficinas(ofi);
        }

        // PUT api/<OficinasController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] oficina ofi)
        {
            return oficinasClient.UpdateDataOficinas(ofi);
        }

        // DELETE api/<OficinasController>/5
        [HttpDelete("{id}")]
        public string Delete([FromQuery] oficina ofi)
        {
            return oficinasClient.DeleteOficinas(ofi);
        }
    }
}
