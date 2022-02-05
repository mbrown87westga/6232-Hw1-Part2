using System.Data.SqlClient;

namespace TechSupport.DAL
{
  /// <summary>
  /// Get a connection object. 
  /// </summary>
  public static class TechSupportDbConnection
  {
    /// <summary>
    /// Gets the connection
    /// </summary>
    /// <returns></returns>
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