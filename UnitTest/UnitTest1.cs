using System;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaProductos()
        {
            ProductData prodData = new ProductData(new DAL.DataSources.Mockups.ProductMockups());
            var list = prodData.ListaTodosLosproductos();
        }

        [TestMethod]
        public void ListaDescuentoProductosCupon()
        {
            ProductDiscountData prodData = new ProductDiscountData(new DAL.DataSources.Postgresql.ProductDiscountDAO());
            var list = prodData.ObtieneDescuentoPorCodigo("codigo");
        }

        [TestMethod]
        public void ListaDescuentoCategoriaCupon()
        {
            CategoryDiscountData prodData = new CategoryDiscountData(new DAL.DataSources.Postgresql.ProductCategoryDiscountDAO());
            var list = prodData.ObtieneDescuentoPorCodigo("codigo");
        }
    }
}
