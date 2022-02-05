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
    public IEnumerable<DBIncident> GetIncidents()
    {
      List<DBIncident> IncidentList = new List<DBIncident>();

      string selectStatement = @"select i.ProductCode,
                                        i.DateOpened,
                                        c.[Name] as CustomerName,
                                        COALESCE(t.[Name], '') as TechName,
                                        i.Title
                                 from [dbo].[Incidents] i
                                 join [dbo].[Customers] c on i.[CustomerID] = c.[CustomerID]
                                 left join [dbo].[Technicians] t on i.[TechID] = t.[TechID]";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            while (reader.Read())
            {
              DBIncident Incident = new DBIncident();
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

  }
}