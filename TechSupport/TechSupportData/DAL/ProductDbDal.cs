using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupportData.Models;

namespace TechSupportData.DAL
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
      List<Product> productList = new List<Product>();

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
              Product product = new Product
              {
                ProductCode = reader["ProductCode"].ToString(),
                Name = reader["Name"].ToString(),
                Version = (decimal) reader["Version"],
                ReleaseDate = (DateTime) reader["ReleaseDate"]
              };

              productList.Add(product);
            }
          }
        }
      }

      return productList;
    }
  }
}