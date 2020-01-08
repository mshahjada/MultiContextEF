using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        private PrimaryContext _primaryContext;
        private SecondaryContext _secondaryContext;

        public ValuesController()
        {
            _primaryContext = new PrimaryContext();
            _secondaryContext = new SecondaryContext();
        }

        public async Task<IHttpActionResult> Get()
        {
            var results = await _secondaryContext.Purchases.Include(x=>x.Product).Where(x=>x.Product.Name=="Computer").ToListAsync();
            return Ok(results);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
