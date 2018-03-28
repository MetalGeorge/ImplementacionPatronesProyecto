using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Command
{
    public class ObtenerDescuentoCuponCommand : IDescuentosCommand
    {
         private DescuentoPorCupon descuentoPorCupon;

        public ObtenerDescuentoCuponCommand(DescuentoPorCupon descuento)
        {
            this.descuentoPorCupon = descuento;
        }

        public int? Execute()
        {
            return this.descuentoPorCupon.ObtieneDescuento(this.descuentoPorCupon.Producto_id);
        }
    }
}