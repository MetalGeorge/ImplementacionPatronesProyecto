using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioREST.Clases.Command
{
    public interface IDescuentosCommand
    {
        // este método permitirá realizar cualquier tipo de cobro
        int? Execute();
    }
}
