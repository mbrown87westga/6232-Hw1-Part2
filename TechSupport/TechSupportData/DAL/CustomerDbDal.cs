using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupportData.Models;

namespace TechSupportData.DAL
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
      List<Customer> customerList = new List<Customer>();

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
              Customer customer = new Customer
              {
                CustomerId = (int) reader["CustomerID"],
                Name = reader["Name"].ToString(),
                Address = reader["Address"].ToString(),
                City = reader["City"].ToString(),
                State = reader["State"].ToString(),
                ZipCode = reader["ZipCode"].ToString(),
                Phone = reader["Phone"].ToString(),
                Email = reader["Email"].ToString()
              };


              customerList.Add(customer);
            }
          }
        }
      }

      return customerList;
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