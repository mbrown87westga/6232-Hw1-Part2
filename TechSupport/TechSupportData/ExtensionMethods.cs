using System;
using System.Data.SqlClient;

namespace TechSupportData
{
  /// <summary>
  /// This is a helper class that I made to hold extension methods.
  /// </summary> 
  public static class ExtensionMethods
  {
    /// <summary>
    /// I didn't want to have to reinvent the wheel, because I knew that someone had done this already. I found it here:
    /// https://stackoverflow.com/questions/8052753/how-to-parse-nullabledatetime-from-a-sqldatareader/24634677
    /// </summary>
    /// <param name="reader">the reader to that we are reading from</param>
    /// <param name="fieldName">the name of the field</param>
    /// <returns>the nullable date time.</returns>
    public static DateTime? GetNullableDateTime(this SqlDataReader reader, string fieldName)
    {
      int x = reader.GetOrdinal(fieldName);
      return reader.IsDBNull(x) ? (DateTime?)null : reader.GetDateTime(x);
    }
  }
}
