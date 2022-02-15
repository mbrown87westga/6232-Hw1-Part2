using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
  /// <summary>
  /// The class that gets products from the db
  /// </summary>
  public class ProductDbDal
  {
    /// <summary>
    /// gets the products from the db
    /// </summary>
    /// <returns>the products</returns>
    public IEnumerable<Product> GetProducts()
    {
      List<Product> ProductList = new List<Product>();

      string selectStatement = @"select p.ProductCode,
                                        p.Name,
                                        p.Version,
                                        p.ReleaseDate
                                 from [dbo].[Products] p;";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            while (reader.Read())
            {
              Product Product = new Product();
              Product.ProductCode = reader["ProductCode"].ToString();
              Product.Name = reader["Name"].ToString();
              Product.Version = (decimal)reader["Version"];
              Product.ReleaseDate = (DateTime)reader["ReleaseDate"];

              ProductList.Add(Product);
            }
          }
        }
      }

      return ProductList;
    }
  }
}