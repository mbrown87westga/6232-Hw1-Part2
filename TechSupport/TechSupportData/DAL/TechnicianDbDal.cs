using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupportData.Models;

namespace TechSupportData.DAL
{
  /// <summary>
  /// The class that gets Technicians from the db
  /// </summary>
  public class TechnicianDbDal
  {
    /// <summary>
    /// gets the Technicians from the db
    /// </summary>
    /// <returns>the Technicians</returns>
    public IEnumerable<Technician> GetTechnicians()
    {
      List<Technician> technicianList = new List<Technician>();

      string selectStatement = @"select t.TechID,
                                        t.[Name],
                                        t.Email,
                                        t.Phone
                                 from [dbo].[Technicians] t;";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            while (reader.Read())
            {
              Technician technician = new Technician
              {
                TechId = (int)reader["TechID"],
                Name = reader["Name"].ToString(),
                Email = reader["Email"].ToString(),
                Phone = reader["Phone"].ToString()
              };

              technicianList.Add(technician);
            }
          }
        }
      }

      return technicianList;
    }

    /// <summary>
    /// gets the Technicians with incidents from the db
    /// </summary>
    /// <returns>the Technicians</returns>
    public IEnumerable<Technician> GetTechniciansWithIncidents()
    {
      List<Technician> technicianList = new List<Technician>();

      string selectStatement = @"select distinct t.TechID,
                                        t.[Name]
                                 from [dbo].[Technicians] t
                                 join [dbo].[Incidents] i on t.[TechID] = i.[TechID];";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            while (reader.Read())
            {
              Technician technician = new Technician
              {
                TechId = (int)reader["TechID"],
                Name = reader["Name"].ToString()
              };

              technicianList.Add(technician);
            }
          }
        }
      }

      return technicianList;
    }

    /// <summary>
    /// gets a technician's email and phone
    /// </summary>
    /// <param name="technicianId">the id of teh technician</param>
    /// <returns>a partially populated technician object</returns>
    public Technician GetTechnicianEmailAndPhone(int technicianId)
    {
      string selectStatement = @"select t.TechID,
                                        t.[Name],
                                        t.Email,
                                        t.Phone
                                 from [dbo].[Technicians] t
                                 where t.TechID = @TechID;";

      using (SqlConnection connection = TechSupportDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          selectCommand.Parameters.AddWithValue("@TechID", technicianId);
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            reader.Read();
            return new Technician
            {
              TechId = (int)reader["TechID"],
              Name = reader["Name"].ToString(),
              Email = reader["Email"].ToString(),
              Phone = reader["Phone"].ToString()
            };
          }
        }
      }
    }
  }
}