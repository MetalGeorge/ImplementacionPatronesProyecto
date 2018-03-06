using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product_category
    {
        public int Id { get; set; }
        public string Category_Name { get; set; }
        public int Parent_category_Id { get; set; }
    }
}

