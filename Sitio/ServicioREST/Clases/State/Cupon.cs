using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.State
{
    public class Cupon
    {
        private IEstado estadoCupon;
        public string codigoCupon;
        public int producto_id;
        public Model.Product_discount productoDescuento;
        public bool EsUsado;
        public int Monto;

        public IEstado EstadoCupon
        {
            get { return this.estadoCupon; }
            set { this.estadoCupon = value; }
        }

        public Cupon(int producto_id,  string codigoCupon, int monto)
        {
            this.codigoCupon = codigoCupon;
            this.producto_id = producto_id;
            DAL.ProductDiscountData prodData = new DAL.ProductDiscountData(new DAL.DataSources.Postgresql.ProductDiscountDAO());
            var result = prodData.ObtieneDescuentoProducto(producto_id, codigoCupon);
            this.productoDescuento = result;
            this.EsUsado = result.IsUsed;
            this.Monto = monto;
        }

        public Model.Product_discount Recuperar()
        {
            return this.estadoCupon.Recuperar();
        }

        public void Aplicar()
        {
            this.estadoCupon.Aplicar();
        }
    }
}