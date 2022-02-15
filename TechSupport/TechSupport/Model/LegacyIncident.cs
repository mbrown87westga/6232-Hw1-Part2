namespace TechSupport.Model
{
  /// <summary>
  /// This is a POCO (plain old C# object) that records the info about an incident.
  /// </summary>
  public class LegacyIncident
  {
    /// <summary>
    /// The title of the incident report.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// The description of the incident.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// The id of the reporting customer
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// the Id of the product that the incident is about
    /// </summary>
    public int ProductId { get; set; }
  }
}
