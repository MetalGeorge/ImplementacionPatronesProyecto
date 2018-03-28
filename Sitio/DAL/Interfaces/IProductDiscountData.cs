using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductDiscountData
    {
        List<Model.Product_discount> ListaDescuentosProducto();
        int? ObtieneDescuentoPorCodigo(string codigoCupon, int id);
        int? ObtieneDescuentoPorCodigo(string codigoCupon);
        int? ObtieneDescuentoPorFechas(int producto_id, DateTime fechaInicio, DateTime fechaFin);
        int ConfirmaCompraCupon(string codigoCupon);
    }
}
