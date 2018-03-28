using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.State
{
    public class ActivoEstado : IEstado
    {
        private Cupon cupon;

        public ActivoEstado(Cupon c)
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
            if (this.cupon.EsUsado)
                throw new Exception("El cupon ya fue usado, no se puede aplicar");

            DAL.ProductDiscountData prodData = new DAL.ProductDiscountData(new DAL.DataSources.Postgresql.ProductDiscountDAO());
            var result = prodData.ConfirmaCompraCupon(this.cupon.codigoCupon);

            this.cupon.EstadoCupon = new UtilizadoEstado(this.cupon);
        }
    }
}