using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICategoryDiscountData
    {
        List<Model.Product_category_discount> ListaDescuentosCategoria();
        int? ObtieneDescuentoPorCodigo(string codigoCupon, int id);
        int? ObtieneDescuentoPorCodigo(string codigoCupon);
        int ConfirmaCompraCupon(string codigoCupon);
    }
}
