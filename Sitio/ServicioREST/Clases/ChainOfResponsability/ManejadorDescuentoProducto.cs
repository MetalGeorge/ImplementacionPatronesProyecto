using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.ChainOfResponsability
{
    public class ManejadorDescuentoProducto : ManejadorDescuentos
    {
        public override int? BuscaCupon(string codigo)
        {
            DAL.ProductDiscountData prodData = new DAL.ProductDiscountData(new DAL.DataSources.Postgresql.ProductDiscountDAO());
            var result = prodData.ObtieneDescuentoPorCodigo("codigo");
            return result;
        }
    }
}