using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupportData.Models;

namespace TechSupportData.DAL
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
      List<Incident> incidentList = new List<Incident>();

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
              Incident incident = new Incident
              {
                ProductCode = reader["ProductCode"].ToString(),
                DateOpened = (DateTime) reader["DateOpened"],
                CustomerName = reader["CustomerName"].ToString(),
                CustomerId = (int) reader["CustomerID"],
                Technician = reader["TechName"].ToString(),
                Title = reader["Title"].ToString()
              };
              incidentList.Add(incident);
            }
          }
        }
      }

      return incidentList;
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
          insertCommand.Parameters.AddWithValue("@DateOpened", incident.DateOpened == DateTime.MinValue ? DateTime.Now : incident.DateOpened);
          insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerId);
          insertCommand.Parameters.AddWithValue("@Title", incident.Title);
          insertCommand.Parameters.AddWithValue("@Description", incident.Description);

          insertCommand.ExecuteNonQuery();
        }
      }
    }

    /// <summary>
    /// Gets an incident from the db
    /// </summary>
    /// <param name="incidentId">the id of the incident</param>
    /// <returns>the incident</returns>
    public Incident GetIncident(int incidentId)
    {
      Incident incident = null;

      string selectStatement = @"select i.ProductCode,
                                        i.DateOpened,
                                        i.DateClosed,
                                        c.[Name] as CustomerName,
                                        c.CustomerID,
                                        COALESCE(t.[Name], '') as TechName,
                                        i.Title,
                                        i.Description
                                 from [dbo].[Incidents] i
                                 join [dbo].[Customers] c on i.[CustomerID] = c.[CustomerID]
                                 left join [dbo].[Technicians] t on i.[TechID] = t.[TechID]
                                 where IncidentID = @IncidentID";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          selectCommand.Parameters.AddWithValue("@IncidentId", incidentId);
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            if (reader.Read())
            {
              incident = new Incident
              {
                Title = reader["Title"].ToString(),
                ProductCode = reader["ProductCode"].ToString(),
                DateOpened = (DateTime)reader["DateOpened"],
                DateClosed = reader.GetNullableDateTime("DateClosed"),
                CustomerName = reader["CustomerName"].ToString(),
                CustomerId = (int)reader["CustomerID"],
                Technician = reader["TechName"].ToString(),
                Description = reader["Description"].ToString(),
                IncidentId = incidentId
              };
            }
          }
        }
      }

      return incident;
    }

    /// <summary>
    /// updates an incident in the db
    /// </summary>
    /// <param name="incident">the new values for the incident</param>
    /// <param name="oldIncident">the old incident</param>
    public int UpdateIncident(Incident incident, Incident oldIncident)
    {
      string updateStatement = @"update [dbo].[Incidents]
                                set [Description] = @Description,
                                    TechID = @TechID
                                 where IncidentID = @IncidentID
                                   and Description = @OldDescription
                                   and ((DateClosed is null and @OldDateClosed is null) or DateClosed = @OldDateClosed)";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
        {
          updateCommand.Parameters.AddWithValue("@Description", (object)incident.Description ?? DBNull.Value);
          updateCommand.Parameters.AddWithValue("@IncidentId", incident.IncidentId);
          updateCommand.Parameters.AddWithValue("@TechID", (object)incident.TechId ?? DBNull.Value);
          updateCommand.Parameters.AddWithValue("@OldDescription", (object)oldIncident.Description ?? DBNull.Value);
          updateCommand.Parameters.AddWithValue("@OldDateClosed", (object)oldIncident.DateClosed ?? DBNull.Value);

          return updateCommand.ExecuteNonQuery();
        }
      }
    }

    /// <summary>
    /// closes an incident
    /// </summary>
    /// <param name="incidentId">the id of the incident to close</param>
    public void CloseIncident(int incidentId)
    {
      string closeStatement = @"update [dbo].[Incidents]
                                set DateClosed = getDate()
                                where IncidentID = @IncidentID";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand updateCommand = new SqlCommand(closeStatement, connection))
        {
          updateCommand.Parameters.AddWithValue("@IncidentId", incidentId);

          updateCommand.ExecuteNonQuery();
        }
      }
    }

    /// <summary>
    /// Gets the open technician incidents
    /// </summary>
    /// <param name="technicianId">the id of the technician</param>
    /// <returns>the incidents list</returns>
    public List<Incident> GetOpenTechnicianIncidents(int technicianId)
    {
      List<Incident> incidentList = new List<Incident>();

      string selectStatement = @"select i.ProductCode,
                                        p.[Name] as ProductName,
                                        i.DateOpened,
                                        c.[Name] as CustomerName,
                                        c.CustomerID,
                                        COALESCE(t.[Name], '') as TechName,
                                        i.Title
                                 from [dbo].[Incidents] i
                                 join [dbo].[Customers] c on i.[CustomerID] = c.[CustomerID]
                                 join [dbo].[Products] p on i.[ProductCode] = p.[ProductCode]
                                 left join [dbo].[Technicians] t on i.[TechID] = t.[TechID]
                                 where DateClosed is null
                                 and I.TechID = @TechID";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          selectCommand.Parameters.AddWithValue("@TechID", technicianId);
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            while (reader.Read())
            {
              Incident incident = new Incident
              {
                ProductCode = reader["ProductCode"].ToString(),
                ProductName = reader["ProductName"].ToString(),
                DateOpened = ((DateTime)reader["DateOpened"]).Date,
                CustomerName = reader["CustomerName"].ToString(),
                CustomerId = (int)reader["CustomerID"],
                Technician = reader["TechName"].ToString(),
                Title = reader["Title"].ToString()
              };
              incidentList.Add(incident);
            }
          }
        }
      }

      return incidentList;
    }
  }
}