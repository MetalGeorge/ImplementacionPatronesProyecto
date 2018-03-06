using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Bridge
{
    public abstract class Descuentos
    {
        private IImplementadorDescuentos implementador;

        public IImplementadorDescuentos ObtieneImplementador()
        {
            return this.implementador;
        }

        public void seteaImplementador(IImplementadorDescuentos implementador)
        {
            this.implementador = implementador;
        }

        public abstract int? Obtener(string couponCode, int id);

    }
}