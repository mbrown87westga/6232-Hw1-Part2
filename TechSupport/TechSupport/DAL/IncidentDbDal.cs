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
              Incident.Customer = reader["CustomerName"].ToString();
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
              Customer.CustomerID = int.Parse(reader["CustomerID"].ToString()); 
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
  }
}