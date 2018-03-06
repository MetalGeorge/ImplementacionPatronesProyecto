using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Model;
using Model.ViewModel;

namespace DAL.DataSources.Mockups
{
    public class ProductMockups : Interfaces.IProductData
    {
        public List<Model.Product> ListaProductos()
        {
            List<Model.Product> result = new List<Model.Product>();
            result.Add(new Model.Product()
            {
                Id = 1,
                Product_name = "Pelota",
                Product_description = "Pelota champions",
                Product_category_id = 1
            });
            return result;
        }


        List<ProductPrice> IProductData.ListaProductosConPrecio()
        {
            throw new NotImplementedException();
        }
    }
}
