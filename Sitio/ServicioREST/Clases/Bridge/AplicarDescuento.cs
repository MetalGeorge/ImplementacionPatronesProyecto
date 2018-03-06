using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Bridge
{
    public class AplicarDescuento : Descuentos
    {
        public AplicarDescuento(IImplementadorDescuentos implementador)
        {
            this.seteaImplementador(implementador);
        }

        public override int? Obtener(string couponCode, int id)
        {
            return this.ObtieneImplementador().ObtieneDescuento(couponCode, id);
        }
    }
}