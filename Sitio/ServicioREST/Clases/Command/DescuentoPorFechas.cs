using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Command
{
    public class DescuentoPorFechas : DescuentosAbstracta
    {

        public override int? ObtieneDescuento(int producto_id)
        {
            DAL.ProductDiscountData prodData = new DAL.ProductDiscountData(new DAL.DataSources.Postgresql.ProductDiscountDAO());
            var result = prodData.ObtieneDescuentoPorFechas(producto_id, this.FechaInicioDescuento, this.FechaFinDescuento);
            return result;
        }
    }
}