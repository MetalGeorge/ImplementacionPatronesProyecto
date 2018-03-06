using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioREST.Controllers
{
    public class ProductDiscountController : ApiController
    {
        // GET: api/ProductDiscount
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProductDiscount/5
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/ProductDiscount/"coupon"/5
        public string Get(string coupon, int id)
        {
            return "value";
        }

        // POST: api/ProductDiscount
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductDiscount/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductDiscount/5
        public void Delete(int id)
        {
        }
    }
}
