using bank.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerTurns : ControllerBase
    {
        private readonly DataContext customers;
        public CustomerTurns(DataContext context)
        {
            customers = context;
        }

        // GET: api/<Customers>
        [HttpGet]
        public List<Customer> Get()
        {
            return customers.Customers;
        }

        // GET api/<Customers>/5
        [HttpGet("{tz}")]
        public Customer Get(string tz)
        {
            Customer c = customers.Customers.Find(x => x.Tz == tz);
            return c;
        }

        // POST api/<Customers>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            customers.Customers.Add(value);
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer value)
        {
            Customer c = customers.Customers.Find(x => x.Id == id);
            if (c == null)
            {
                return NotFound();
            }
            c.Tz = value.Tz;
            c.Name = value.Name;
            return Ok(c);
        }

        // DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Customer c = customers.Customers.Find(x => x.Id == id);
            if (c == null)
            {
                return NotFound(id);
            }
            customers.Customers.Remove(c);
            return Ok(c);
        }
    }
}
