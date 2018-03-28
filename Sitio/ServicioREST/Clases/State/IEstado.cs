using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.State
{
    public interface IEstado
    {
        Model.Product_discount Recuperar();
        void Aplicar();
    }
}