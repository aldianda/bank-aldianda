using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank_Aldi.Models;
using Bank_Aldi.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank_Aldi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly CustomerRepository _repository;
        public CustomerController(CustomerRepository repository)
        {
            _repository = repository;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_repository.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(String id)
        {
            var result = _repository.Get(id);
            if(result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Customer customer)
        {

            return Ok(_repository.Insert(customer));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(String id, [FromBody]Customer entity)
        {
            return Ok(_repository.Update(id, entity));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(String id)
        {
            _repository.Delete(id);
        }

        [HttpGet]
        public ActionResult History()
        {
           return Ok(_repository.History());
        }
    }
}

