using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.State
{
    public class UtilizadoEstado: IEstado
    {
        private Cupon cupon;

        public UtilizadoEstado(Cupon c)
        {
            this.cupon = c;
        }

        public Model.Product_discount Recuperar()
        {
            DAL.ProductDiscountData prodData = new DAL.ProductDiscountData(new DAL.DataSources.Postgresql.ProductDiscountDAO());
            return prodData.ObtieneDescuentoProducto(this.cupon.producto_id, this.cupon.codigoCupon);

        }

        public void Aplicar()
        {
            throw new Exception("El cupon ya fue usado, no se puede aplicar");
        }
    }
}