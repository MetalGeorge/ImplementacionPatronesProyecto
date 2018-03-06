using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public string Product_name { get; set; }
        public string Product_description { get; set; }
        public int Product_category_id { get; set; }
        public decimal Price { get; set; }
    }
}
