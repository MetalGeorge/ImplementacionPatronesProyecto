using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductData
    {
        List<Model.Product> ListaProductos();
        List<Model.ViewModel.ProductPrice> ListaProductosConPrecio();
    }
}
