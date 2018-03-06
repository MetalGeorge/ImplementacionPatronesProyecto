using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product_category_discount
    {
        public int Id { get; set; }
        public int Product_Category_Id { get; set; }
        public int? Discount_Value{ get; set; }
        public int Maximum_Discount_Amount { get; set; }
        public string Coupon_Code{ get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime Valid_Until { get; set; }
    }
}
