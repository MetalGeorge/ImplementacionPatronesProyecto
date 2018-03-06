using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.ChainOfResponsability
{
    public abstract class ManejadorDescuentos
    {
        protected ManejadorDescuentos siguienteManejador;

        public ManejadorDescuentos getSiguiente()
        {
            return this.siguienteManejador;
        }

        public void setSiguiente(ManejadorDescuentos m)
        {
            this.siguienteManejador = m;
        }

        public int? procesar(string codigo)
        {
            var result = this.BuscaCupon(codigo);
            if (!result.HasValue)
            {
                if (this.getSiguiente() != null)
                {
                    this.getSiguiente().procesar(codigo);
                }
            }
            return result;
        }

        public abstract int? BuscaCupon(string codigo);
        
    }
}