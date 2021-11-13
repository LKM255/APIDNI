using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDNI.DataContext;
using WebApiDNI.Models;

namespace WebApiDNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonContext _db;
        public PersonController(PersonContext db)
        {
            _db = db;
        }
        
        [HttpGet("{DNI:int}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetPerson(string DNI)
        {
            var obj = await _db.Person.FirstOrDefaultAsync(c => c.DNI == DNI);

            if(obj==null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
        [HttpPost]
        public async Task<IActionResult> CrearPerson([FromBody] Person person)
        {
            if(person==null)
            {
                return BadRequest(ModelState);
            }
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _db.AddAsync(person);
            await _db.SaveChangesAsync();
            return Ok();
        }
        
    }
}
