using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Command
{
    public abstract class DescuentosAbstracta
    {
        public DateTime FechaInicioDescuento { get; set; }
        public DateTime FechaFinDescuento { get; set; }
        public string CodigoCupon { get; set; }
        public bool EstaUsado { get; set; }
        public int MontoMaximo { get; set; }
        public int Producto_id { get; set; }
        public abstract int? ObtieneDescuento(int producto_id);
    }
}