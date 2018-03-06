using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Bridge
{
    public class DescuentoProducto : IImplementadorDescuentos
    {
        public DescuentoProducto()
        {

        }

        int? IImplementadorDescuentos.ObtieneDescuento(string couponCode, int id)
        {
            DAL.ProductDiscountData prodDiscountData = new DAL.ProductDiscountData(new DAL.DataSources.Postgresql.ProductDiscountDAO());
            var descuento = prodDiscountData.ObtieneDescuentoPorCodigo(couponCode, id);
            return descuento;
        }
    }
}