using System;

namespace TechSupportData.Models
{
  /// <summary>
  /// An incident that was retrieved from the database. It has different properties than a legacy incident.
  /// </summary>
  public class Incident
  {
    public int IncidentId { get; set; }
    /// <summary>
    /// The product code
    /// </summary>
    public string ProductCode { get; set; }
    /// <summary>
    /// The date that the incident was opened
    /// </summary>
    public DateTime DateOpened { get; set; }
    /// <summary>
    /// The date that the incident was closed
    /// </summary>
    public DateTime? DateClosed { get; set; }
    /// <summary>
    /// The customer that reported the incident
    /// </summary>
    public int CustomerId { get; set; }
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
    public int? TechId { get; set; }
    /// <summary>
    /// The title of the incident
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// the Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// checks to see if the object is equal to the passed object
    /// </summary>
    /// <param name="obj">the object to check against</param>
    /// <returns>true if they are equal</returns>
    public override bool Equals(object obj)
    {
      return obj is Incident incident && (incident.Description == Description &&
                                          incident.ProductCode == ProductCode &&
                                          incident.DateOpened == DateOpened &&
                                          incident.CustomerName == CustomerName &&
                                          incident.CustomerId == CustomerId &&
                                          incident.DateOpened == DateOpened &&
                                          incident.IncidentId == IncidentId &&
                                          incident.ProductCode == ProductCode &&
                                          incident.TechId == TechId &&
                                          incident.Technician == Technician &&
                                          incident.Title == Title);
    }
  }
}