using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
  /// <summary>
  /// The class that interacts with customers in the db
  /// </summary>
  public class CustomerDbDal
  {
    /// <summary>
    /// gets the customers from the db
    /// </summary>
    /// <returns>the customers</returns>
    public IEnumerable<Customer> GetCustomers()
    {
      List<Customer> CustomerList = new List<Customer>();

      string selectStatement = @"select c.CustomerID,
                                        c.[Name],
                                        c.[Address],
                                        c.City,
                                        c.[State],
                                        c.ZipCode,
                                        c.Phone,
                                        c.Email
                                 from [dbo].[Customers] c;";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            while (reader.Read())
            {
              Customer Customer = new Customer();
              Customer.CustomerID = (int)reader["CustomerID"]; 
              Customer.Name = reader["Name"].ToString();
              Customer.Address = reader["Address"].ToString();
              Customer.City = reader["City"].ToString();
              Customer.State = reader["State"].ToString();
              Customer.ZipCode = reader["ZipCode"].ToString();
              Customer.Phone = reader["Phone"].ToString();
              Customer.Email = reader["Email"].ToString();

              CustomerList.Add(Customer);
            }
          }
        }
      }

      return CustomerList;
    }

    /// <summary>
    /// returns true if the customer is associated with the product
    /// </summary>
    /// <param name="customerId">the id of the customer</param>
    /// <param name="productCode">the product's id</param>
    /// <returns>true if the customer is associated with the product. False otherwise</returns>
    public bool IsCustomerAssociatedToProduct(int customerId, string productCode)
    {
      string selectStatement = @"select count(*)
                                 from [dbo].[Registrations]
                                 where CustomerID = @CustomerID
                                 and ProductCode = @ProductCode;";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          selectCommand.Parameters.AddWithValue("@CustomerID", customerId);
          selectCommand.Parameters.AddWithValue("@ProductCode", productCode);
          var result = (int) selectCommand.ExecuteScalar();
          return result > 0;
        }
      }
    }
  }
}