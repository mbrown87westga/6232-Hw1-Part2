namespace TechSupport.Model
{
  /// <summary>
  /// A technician that was retrieved from the database.
  /// </summary>
  public class Technician
  {
    /// <summary>
    /// the TechnicianID
    /// </summary>
    public int TechId { get; set; }
    /// <summary>
    /// the Name
    /// </summary>
    public string Name { get; set; }
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