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

        // GET: api/ProductDiscount/5/
        public int? Get(int id, DateTime fechaInicio, DateTime fechaFin)
        {
            Clases.Command.DescuentoPorFechas descuentoFechas = new Clases.Command.DescuentoPorFechas();
            /// Asignamos los valores necesarios
            descuentoFechas.FechaInicioDescuento = fechaInicio;
            descuentoFechas.FechaFinDescuento= fechaFin;
            descuentoFechas.Producto_id = id;

            Clases.Command.IDescuentosCommand descuentoCuponCmd = new Clases.Command.ObtenerDescuentoFechasCommand(descuentoFechas);
            Clases.Command.IInvoker invoker = new Clases.Command.ControladorObtieneDescuentoInvoker();
            invoker.SetCommand(descuentoCuponCmd);
            var result = invoker.Invoke();
            return result;
        }

        // GET: api/ProductDiscount/"coupon"/5
        public int? Get(string coupon, int id)
        {
            Clases.Command.DescuentoPorCupon descuentoCupon = new Clases.Command.DescuentoPorCupon();
            /// Asignamos los valores necesarios
            descuentoCupon.CodigoCupon = coupon;
            descuentoCupon.Producto_id = id;

            Clases.Command.IDescuentosCommand descuentoCuponCmd = new Clases.Command.ObtenerDescuentoCuponCommand(descuentoCupon);
            Clases.Command.IInvoker invoker = new Clases.Command.ControladorObtieneDescuentoInvoker();
            invoker.SetCommand(descuentoCuponCmd);
            var result = invoker.Invoke();
            return result;
        }

        // POST: api/ProductDiscount
        public void Post([FromBody]string codigoCupon, int producto_id)
        {
            Clases.State.Cupon cupon = new Clases.State.Cupon(producto_id, codigoCupon);
            var cuponRecuperado = cupon.Recuperar();
            cupon.Aplicar();
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
