using Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductData
    {
        private Interfaces.IProductData strategy;

        public ProductData(Interfaces.IProductData strategy)
        {
            this.strategy = strategy;
        }
        public List<Product> ListaTodosLosproductos()
        {
            return this.strategy.ListaProductos();
        }
        public List<Model.ViewModel.ProductPrice> ListaProductosConPrecio()
        {
            return this.strategy.ListaProductosConPrecio();
        }


    }
}
