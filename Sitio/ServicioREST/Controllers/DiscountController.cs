using ServicioREST.Clases.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioREST.Controllers
{
    public class DiscountController : ApiController
    {
        // GET: api/Discount
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Discount/5
        public int? Get(string cupon)
        {
            ManejadorDescuentos mp = new Clases.ChainOfResponsability.ManejadorDescuentoProducto();
            ManejadorDescuentos mc = new Clases.ChainOfResponsability.ManejadorDescuentoCategoria();
            mc.setSiguiente(null);
            mp.setSiguiente(mc);
            var result = mp.procesar(cupon);

            return result;
        }

        // POST: api/Discount
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Discount/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Discount/5
        public void Delete(int id)
        {
        }
    }
}
