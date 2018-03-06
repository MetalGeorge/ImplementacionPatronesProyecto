using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Npgsql;
using System.Data;

namespace DAL.DataSources.Postgresql
{
    public class ProductDAO : Interfaces.IProductData
    {
        public List<Product> ListaProductos()
        {
            List<Product> result = new List<Product>();
            NpgsqlConnection connection = new NpgsqlConnection("Server=jepdata.c72m7dovjxgj.us-east-1.rds.amazonaws.com;Port=5432;User Id=root;Password=Metalis123;Database=DemoPatrones;MAXPOOLSIZE=100;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select id, product_name, product_description, units_in_stock, product_category_id from product limit 10", connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new Product()
                {
                    Id = reader.GetInt32(0),
                    Product_name = reader.GetString(1),
                    Product_description = reader.GetString(2),
                    Product_category_id = reader.GetInt32(4)
                });
            }

            return result;
        }

        public List<Model.ViewModel.ProductPrice> ListaProductosConPrecio()
        {
            List<Model.ViewModel.ProductPrice> result = new List<Model.ViewModel.ProductPrice>();
            NpgsqlConnection connection = new NpgsqlConnection("Server=jepdata.c72m7dovjxgj.us-east-1.rds.amazonaws.com;Port=5432;User Id=root;Password=Metalis123;Database=DemoPatrones;MAXPOOLSIZE=100;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT p.id, product_name, product_description, 
                                                    product_category_id,
                                                    pp.base_price
                                                    FROM product p
                                                    INNER JOIN product_pricing pp ON pp.product_id = p.id", connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new Model.ViewModel.ProductPrice()
                {
                    Id = reader.GetInt32(0),
                    Product_name = reader.GetString(1),
                    Product_description = reader.GetString(2),
                    Product_category_id = reader.GetInt32(3),
                    Price = reader.GetInt32(4),
                });
            }

            return result;
        }
    }
}
