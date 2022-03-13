using System;

namespace TechSupportData.Models
{
  /// <summary>
  /// A customer that was retrieved from the database.
  /// </summary>
  public class Product
  {
    /// <summary>
    /// the ProductCode
    /// </summary>
    public string ProductCode { get; set; }
    /// <summary>
    /// the Name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// the Version
    /// </summary>
    public decimal Version { get; set; }
    /// <summary>
    /// the ReleaseDate
    /// </summary>
    public DateTime ReleaseDate { get; set; }

  }
}