using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
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
              Technician Technician = new Technician();
              Technician.TechID = (int)reader["TechID"];
              Technician.Name = reader["Name"].ToString();
              Technician.Email = reader["Email"].ToString();
              Technician.Phone = reader["Phone"].ToString();

              technicianList.Add(Technician);
            }
          }
        }
      }

      return technicianList;
    }
  }
}