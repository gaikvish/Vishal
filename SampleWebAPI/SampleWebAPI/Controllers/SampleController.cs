using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleWebAPI.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SampleController : Controller
    {
        // GET: api/<SampleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }

        // GET api/<SampleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public List<Name_CLS> NameDetail([FromBody] Name_CLS json)
        {
            List<Name_CLS> lst_name = new List<Name_CLS>();
           
            try
            {
                Name_CLS clsobj = new Name_CLS();
                clsobj.FirstName = json.FirstName;
                clsobj.LastName = json.LastName;
                
                clsobj.error = "";
                lst_name.Add(clsobj);
                return lst_name;
            }
            catch (Exception ex)
            {
                Name_CLS clsobj = new Name_CLS();
                clsobj.error = ex.Message;
                lst_name.Add(clsobj);
                return lst_name;

            }

        }

            // POST api/<SampleController>
            [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
