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
                TechId = (int) reader["TechID"],
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
  }
}