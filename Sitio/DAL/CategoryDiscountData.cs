using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDiscountData
    {
        private Interfaces.ICategoryDiscountData strategy;

        public CategoryDiscountData(Interfaces.ICategoryDiscountData strategy)
        {
            this.strategy = strategy;
        }
        public List<Model.Product_category_discount> ListaDescuentosCategoria()
        {
            return this.strategy.ListaDescuentosCategoria();
        }
        public int? ObtieneDescuentoPorCodigo(string cupon, int id)
        {
            return this.strategy.ObtieneDescuentoPorCodigo(cupon, id);
        }
        public int? ObtieneDescuentoPorCodigo(string cupon)
        {
            return this.strategy.ObtieneDescuentoPorCodigo(cupon);
        }
    }
}
