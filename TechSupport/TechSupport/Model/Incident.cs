using System;

namespace TechSupport.Model
{
  /// <summary>
  /// An incident that was retrieved from the database. It has different properties than a legacy incident.
  /// </summary>
  public class Incident
  {
    public int IncidentID { get; set; }
    /// <summary>
    /// The product code
    /// </summary>
    public string ProductCode { get; set; }
    /// <summary>
    /// The date that the incident was opened
    /// </summary>
    public DateTime DateOpened { get; set; }
    /// <summary>
    /// The customer that reported the incident
    /// </summary>
    public int CustomerID { get; set; }
    /// <summary>
    /// The customer that reported the incident
    /// </summary>
    public string CustomerName { get; set; }
    /// <summary>
    /// The technician assigned to the incident
    /// </summary>
    public string Technician { get; set; }
    /// <summary>
    /// The technician assigned to the incident
    /// </summary>
    public int TechID { get; set; }
    /// <summary>
    /// The title of the incident
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// the Description
    /// </summary>
    public string Description { get; set; }

    public override bool Equals(object obj)
    {
      Incident incident = obj as Incident;
      return incident != null && (incident.Description == Description &&
                                  incident.ProductCode == ProductCode &&
                                  incident.DateOpened == DateOpened &&
                                  incident.CustomerName == CustomerName &&
                                  incident.CustomerID == CustomerID &&
                                  incident.DateOpened == DateOpened &&
                                  incident.IncidentID == IncidentID &&
                                  incident.ProductCode == ProductCode &&
                                  incident.TechID == TechID &&
                                  incident.Technician == Technician &&
                                  incident.Title == Title);
    }
  }
}