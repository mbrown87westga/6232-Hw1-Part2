namespace TechSupport.Model
{
  /// <summary>
  /// A customer that was retrieved from the database.
  /// </summary>
  public class Technician
  {
    /// <summary>
    /// the CustomerID
    /// </summary>
    public int CustomerID { get; set; }
    /// <summary>
    /// the Name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// the Address
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// the City
    /// </summary>
    public string City { get; set; }
    /// <summary>
    /// the State
    /// </summary>
    public string State { get; set; }
    /// <summary>
    /// the ZipCode
    /// </summary>
    public string ZipCode { get; set; }
    /// <summary>
    /// the Phone
    /// </summary>
    public string Phone { get; set; }
    /// <summary>
    /// the Email
    /// </summary>
    public string Email { get; set; }

  }
}