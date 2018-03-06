using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioREST.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<Model.ViewModel.ProductPrice> Get()
        {
            DAL.ProductData prodData = new DAL.ProductData(new DAL.DataSources.Postgresql.ProductDAO());
            return prodData.ListaProductosConPrecio();
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
