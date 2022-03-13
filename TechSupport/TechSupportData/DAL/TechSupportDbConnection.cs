using System.Data.SqlClient;

namespace TechSupportData.DAL
{
  /// <summary>
  /// Get a connection object. 
  /// </summary>
  public static class TechSupportDbConnection
  {
    /// <summary>
    /// Gets the connection
    /// </summary>
    /// <returns>the connection</returns>
    public static SqlConnection GetConnection()
    {
      string connectionString =
        "Data Source=localhost;Initial Catalog=TechSupport;" +
        "Integrated Security=True";

      SqlConnection connection = new SqlConnection(connectionString);
      return connection;
    }
  }
}