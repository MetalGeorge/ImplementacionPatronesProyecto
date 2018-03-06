using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductPricing
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public decimal Base_price{ get; set; }
        public DateTime Date_created{ get; set; }
        public DateTime Date_expiry { get; set; }
        public bool Is_active{ get; set; }
    }
}
