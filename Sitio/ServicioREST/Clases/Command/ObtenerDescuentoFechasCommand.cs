using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Command
{
    public class ObtenerDescuentoFechasCommand : IDescuentosCommand
    {
        private DescuentoPorFechas descuentoPorFechas;

        public ObtenerDescuentoFechasCommand(DescuentoPorFechas descuento)
        {
            this.descuentoPorFechas = descuento;
        }

        public int? Execute()
        {
            return this.descuentoPorFechas.ObtieneDescuento(this.descuentoPorFechas.Producto_id);
        }
    }
}