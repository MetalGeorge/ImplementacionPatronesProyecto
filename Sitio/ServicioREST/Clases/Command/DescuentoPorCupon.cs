using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Command
{
    public class DescuentoPorCupon : DescuentosAbstracta
    {
        public override int? ObtieneDescuento(int producto_id)
        {
            DAL.ProductDiscountData prodData = new DAL.ProductDiscountData(new DAL.DataSources.Postgresql.ProductDiscountDAO());
            var result = prodData.ObtieneDescuentoPorCodigo(this.CodigoCupon, producto_id);
            return result;
        }
    }
}