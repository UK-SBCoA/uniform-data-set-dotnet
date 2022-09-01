using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Data;
using UDS.Net.API.Extensions;
using UDS.Net.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UDS.Net.API.Controllers
{
    [Route("api/[controller]")]
    public class VisitsController : Controller
    {
        private readonly ApiDbContext _Context;

        public VisitsController(ApiDbContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<VisitDto>> Get()
        {
            return await _Context.Visits.Select(v => v.ToDto()).ToListAsync();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

