using Buildings.Domain.Handlers;
using Buildings.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Buildings.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly IBuildingHandler _buildingHandler;
        public BuildingsController(IBuildingHandler buildingHandler)
        {
            _buildingHandler = buildingHandler;
        }
        // GET: api/<BuildingsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BuildingsController>/5
        [HttpGet("{id}")]
        public async Task<BuildingDto> Get(string id)
        {
            var buildingDto = await _buildingHandler.Get(new Guid(id));

            return buildingDto;
        }

        // POST api/<BuildingsController>
        [HttpPost]
        public async Task Post([FromBody] BuildingDto dto)
        {
            await _buildingHandler.Save(dto);

        }

        // PUT api/<BuildingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BuildingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
