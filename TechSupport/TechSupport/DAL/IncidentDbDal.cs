using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
  /// <summary>
  /// The class that interacts with incidents in the db
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
    
    /// <summary>
    /// adds an incident to the db
    /// </summary>
    /// <param name="incident">the incident</param>
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