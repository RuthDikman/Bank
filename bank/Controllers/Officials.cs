using bank.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Officials : ControllerBase
    {
        public static List<Official> officials = new List<Official>();
        // GET: api/<Officials>
        [HttpGet]
        public List<Official> Get()
        {
            return officials;
        }

        // GET api/<Officials>/5
        [HttpGet("{id}")]
        public Official Get(int id)
        {
            Official o = officials.Find(x => x.Id == id);
            return o;
        }

        // POST api/<Officials>
        [HttpPost]
        public void Post([FromBody] Official value)
        {
            officials.Add(value);

        }

        // PUT api/<Officials>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            Official o = officials.Find(x => x.Id == id);
            if (o == null)
            {
                return NotFound();
            }
            o.Name = value;
            return Ok(o);
        }

        // DELETE api/<Officials>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Official o = officials.Find(x => x.Id == id);
            if (o == null)
            {
                return NotFound(id);
            }
            officials.Remove(o);
            return Ok(o);

        }
    }
}
