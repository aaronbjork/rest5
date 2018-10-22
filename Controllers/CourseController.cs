using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace rest5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // GET api/course
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "semiahmoo", "loomis" };
        }

        // GET api/course/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/course
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/course/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/course/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
