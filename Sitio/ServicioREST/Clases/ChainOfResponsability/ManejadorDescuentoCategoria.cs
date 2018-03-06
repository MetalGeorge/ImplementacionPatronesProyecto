using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.ChainOfResponsability
{
    public class ManejadorDescuentoCategoria : ManejadorDescuentos
    {
        public override int? BuscaCupon(string codigo)
        {
            DAL.CategoryDiscountData prodData = new DAL.CategoryDiscountData(new DAL.DataSources.Postgresql.ProductCategoryDiscountDAO());
            var result = prodData.ObtieneDescuentoPorCodigo(codigo);
            return result;
        }
    }
}