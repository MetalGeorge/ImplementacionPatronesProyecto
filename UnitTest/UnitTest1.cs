using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaProductos()
        {
            DAL.ProductData prodData = new DAL.ProductData(new DAL.DataSources.Mockups.ProductMockups());
            var list = prodData.ListaTodosLosproductos();
        }

        [TestMethod]
        public void ListaDescuentoProductosCupon()
        {
            DAL.ProductDiscountData prodData = new DAL.ProductDiscountData(new DAL.DataSources.Postgresql.ProductDiscountDAO());
            var list = prodData.ObtieneDescuentoPorCodigo("codigo");
        }

        [TestMethod]
        public void ListaDescuentoCategoriaCupon()
        {
            DAL.CategoryDiscountData prodData = new DAL.CategoryDiscountData(new DAL.DataSources.Postgresql.ProductCategoryDiscountDAO());
            var list = prodData.ObtieneDescuentoPorCodigo("codigo");
        }
    }
}
