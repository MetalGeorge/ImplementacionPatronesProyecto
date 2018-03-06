using Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataSources.Postgresql
{
    public class ProductCategoryDiscountDAO : Interfaces.ICategoryDiscountData
    {
        public List<Model.Product_category_discount> ListaDescuentosCategoria()
        {
            List<Product_category_discount> result = new List<Product_category_discount>();
            NpgsqlConnection connection = new NpgsqlConnection("Server=jepdata.c72m7dovjxgj.us-east-1.rds.amazonaws.com;Port=5432;User Id=root;Password=Metalis123;Database=DemoPatrones;MAXPOOLSIZE=100;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"SELECT id, product_id, discount_value, date_created, 
                                                    valid_until, coupon_code FROM product_discount "), connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new Product_category_discount()
                {
                    Id = reader.GetInt32(0),
                    Product_Category_Id = reader.GetInt32(1),
                    Discount_Value = reader.GetInt32(2),
                    Date_Created = reader.GetDateTime(3),
                    Valid_Until = reader.GetDateTime(4),
                    Coupon_Code = reader.GetString(5)
                });
            }

            return result;
        }

        public int? ObtieneDescuentoPorCodigo(string couponCode, int id)
        {
            var result = new Product_category_discount();
            NpgsqlConnection connection = new NpgsqlConnection("Server=jepdata.c72m7dovjxgj.us-east-1.rds.amazonaws.com;Port=5432;User Id=root;Password=Metalis123;Database=DemoPatrones;MAXPOOLSIZE=100;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"SELECT id, product_category_id, discount_value, date_created, 
                                                    valid_until, coupon_code, maximum_discount_amount FROM product_discount WHERE coupon_code='{0}' AND product_category_id={1} LIMIT 1", couponCode, id), connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result = new Product_category_discount()
                {
                    Id = reader.GetInt32(0),
                    Product_Category_Id = reader.GetInt32(1),
                    Discount_Value = reader.GetInt32(2),
                    Date_Created = reader.GetDateTime(3),
                    Valid_Until = reader.GetDateTime(4),
                    Coupon_Code = reader.GetString(5),
                    Maximum_Discount_Amount = reader.GetInt32(6)
                };
            }

            return result.Discount_Value;
        }

        public int? ObtieneDescuentoPorCodigo(string couponCode)
        {
            var result = new Product_category_discount();
            NpgsqlConnection connection = new NpgsqlConnection("Server=jepdata.c72m7dovjxgj.us-east-1.rds.amazonaws.com;Port=5432;User Id=root;Password=Metalis123;Database=DemoPatrones;MAXPOOLSIZE=100;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"SELECT id, product_id, discount_value, date_created, 
                                                    valid_until, coupon_code, maximum_discount_amount 
                                                    FROM product_discount WHERE coupon_code='{0}' LIMIT 1", couponCode), connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result = new Product_category_discount()
                {
                    Id = reader.GetInt32(0),
                    Product_Category_Id = reader.GetInt32(1),
                    Discount_Value = reader.GetInt32(2),
                    Date_Created = reader.GetDateTime(3),
                    Valid_Until = reader.GetDateTime(4),
                    Coupon_Code = reader.GetString(5),
                    Maximum_Discount_Amount = reader.GetInt32(6)
                };
            }

            return result.Discount_Value;
        }

        public int ConfirmaCompraCupon(string codigoCupon)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=jepdata.c72m7dovjxgj.us-east-1.rds.amazonaws.com;Port=5432;User Id=root;Password=Metalis123;Database=DemoPatrones;MAXPOOLSIZE=100;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"UPDATE product_discount SET coupon_code = '' WHERE coupon_code='{0}' LIMIT 1", codigoCupon), connection);
            return cmd.ExecuteNonQuery();
        }
    }
}
