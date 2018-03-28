using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDiscountData
    {
        private Interfaces.IProductDiscountData strategy;

        public ProductDiscountData(Interfaces.IProductDiscountData strategy)
        {
            this.strategy = strategy;
        }
        public List<Model.Product_discount> ListaDescuentosProducto()
        {
            return this.strategy.ListaDescuentosProducto();
        }
        public int? ObtieneDescuentoPorCodigo(string cupon, int id)
        {
            return this.strategy.ObtieneDescuentoPorCodigo(cupon, id);
        }
        public int? ObtieneDescuentoPorCodigo(string cupon)
        {
            return this.strategy.ObtieneDescuentoPorCodigo(cupon);
        }
        public int? ObtieneDescuentoPorFechas(int producto_id, DateTime fechaInicio, DateTime fechaFin)
        {
            return this.strategy.ObtieneDescuentoPorFechas(producto_id, fechaInicio, fechaFin);
        }
        public Model.Product_discount ObtieneDescuentoProducto(int id, string codigoCupon)
        {
            return this.strategy.ObtieneDescuentoProducto(id, codigoCupon);
        }
        public int ConfirmaCompraCupon(string codigoCupon)
        {
            return this.strategy.ConfirmaCompraCupon(codigoCupon);
        }

    }
}
