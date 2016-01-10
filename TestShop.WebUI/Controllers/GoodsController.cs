using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestShop.WebUI.Models;

namespace TestShop.WebUI.Controllers
{
    public class GoodsController : Controller
    {
        // GET: Goods
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            using (IDbConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TestShop;Integrated Security=True;"))
            {
                IDbCommand command = new SqlCommand("SELECT * FROM dbo.Products");
                command.Connection = connection;

                connection.Open();

                IDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    Product product = new Product()
                    {
                        ProductID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDecimal(2)
                    };

                    products.Add(product);
                }
            }

            return View(products);
        }
    }
}