using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Command
{
    public interface IInvoker 
    {
        void SetCommand(IDescuentosCommand command);

        // Ejecuta el método encapsulado
        int? Invoke();
    }
}