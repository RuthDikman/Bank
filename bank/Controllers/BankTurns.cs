using bank.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankTurns : ControllerBase
    {
        public static List<Turns> turns = new List<Turns>();

        // GET: api/<BunkTurns>
        [HttpGet]
        public List<Turns> Get()
        {
            return turns;
        }

        // GET api/<BunkTurns>/5
        [HttpGet("{start}")]
        public List<Turns> Get(DateTime start)
        {
            List<Turns> t = turns.FindAll((e) => e.Start.Month == start.Month);
            return t;
        }

        // POST api/<BunkTurns>
        [HttpPost]
        public void Post([FromBody] Turns value)
        {
            turns.Add(value);
        }

        // PUT api/<BunkTurns>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Turns value)
        {
            Turns t = turns.Find((e) => e.Id == id);
            if (t == null)
            {
                return NotFound();
            }
            t.Start = value.Start;
            t.Customer = value.Customer;
            t.Official = value.Official;
            return Ok(t);
        }

        // DELETE api/<BunkTurns>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Turns t = turns.Find((e) => e.Id == id);
            if (t == null)
            {
                return NotFound(t);
            }
            turns.Remove(t);
            return Ok(t);
        }
    }
}
