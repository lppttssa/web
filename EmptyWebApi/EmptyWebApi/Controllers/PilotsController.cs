using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EmptyWebApi.Models;
using System.Threading.Tasks;

namespace WebAPIApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PilotsController : ControllerBase
    {
        PilotsContext db;
        public PilotsController(PilotsContext context)
        {
            db = context;
            if (!db.Pilots.Any())
            {
                db.Pilots.Add(new Pilot { name = "Tom Art", company = "Aeroflot", exp = 5 });
                db.Pilots.Add(new Pilot { name = "Morti King", company = "Korean Air", exp = 10 });
                db.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pilot>>> Get()
        {
            return await db.Pilots.ToListAsync();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pilot>> Get(int id)
        {
            Pilot user = await db.Pilots.FirstOrDefaultAsync(x => x.id == id);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<Pilot>> Post(Pilot user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            db.Pilots.Add(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<Pilot>> Put(Pilot user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            if (!db.Pilots.Any(x => x.id == user.id))
            {
                return NotFound();
            }

            db.Update(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pilot>> Delete(int id)
        {
            Pilot user = db.Pilots.FirstOrDefault(x => x.id == id);
            if (user == null)
            {
                return NotFound();
            }
            db.Pilots.Remove(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }
    }
}