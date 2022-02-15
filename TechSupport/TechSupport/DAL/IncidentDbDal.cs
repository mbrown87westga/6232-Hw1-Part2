using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
  /// <summary>
  /// The class that gets incidents from the db
  /// </summary>
  public class IncidentDbDal
  {
    /// <summary>
    /// Get the incidents from the db
    /// </summary>
    /// <returns>the incidents</returns>
    public IEnumerable<Incident> GetOpenIncidents()
    {
      List<Incident> IncidentList = new List<Incident>();

      string selectStatement = @"select i.ProductCode,
                                        i.DateOpened,
                                        c.[Name] as CustomerName,
                                        c.CustomerID,
                                        COALESCE(t.[Name], '') as TechName,
                                        i.Title
                                 from [dbo].[Incidents] i
                                 join [dbo].[Customers] c on i.[CustomerID] = c.[CustomerID]
                                 left join [dbo].[Technicians] t on i.[TechID] = t.[TechID]
                                 where DateClosed is null";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            while (reader.Read())
            {
              Incident Incident = new Incident();
              Incident.ProductCode = reader["ProductCode"].ToString();
              Incident.DateOpened = (DateTime)reader["DateOpened"];
              Incident.CustomerName = reader["CustomerName"].ToString();
              Incident.CustomerID = (int)reader["CustomerID"];
              Incident.Technician = reader["TechName"].ToString();
              Incident.Title = reader["Title"].ToString();
              IncidentList.Add(Incident);
            }
          }
        }
      }

      return IncidentList;
    }

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

    public void AddIncident(Incident incident)
    {
      string insertStatement = @"insert into [dbo].[Incidents] (ProductCode, DateOpened, CustomerID, Title, [Description])
                                 values (@ProductCode, @DateOpened, @CustomerID, @Title, @Description);";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
        {
          insertCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);
          insertCommand.Parameters.AddWithValue("@DateOpened",  incident.DateOpened == DateTime.MinValue ? DateTime.Now : incident.DateOpened);
          insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
          insertCommand.Parameters.AddWithValue("@Title", incident.Title);
          insertCommand.Parameters.AddWithValue("@Description", incident.Description);

          insertCommand.ExecuteNonQuery();
        }
      }
    }
  }
}