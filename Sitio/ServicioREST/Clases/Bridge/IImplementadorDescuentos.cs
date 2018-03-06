using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioREST.Clases.Bridge
{
    public interface IImplementadorDescuentos
    {
        int? ObtieneDescuento(string couponCode, int id);
    }
}
