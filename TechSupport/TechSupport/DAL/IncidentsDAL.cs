using System.Collections.Generic;
using System.Linq;
using TechSupport.Model;

namespace TechSupport.DAL
{
  /// <summary>
  /// Data access layer for incidents
  /// </summary>
  public class IncidentsDal
  {
    private static readonly List<Incident> Incidents = new List<Incident>();
    
    /// <summary>
    /// The method that returns all of the incidents.
    /// </summary>
    /// <returns>Every incident that has been stored.</returns>
    public IEnumerable<Incident> GetIncidents()
    {
      return Incidents;
    }

    /// <summary>
    /// Saves a new incident 
    /// </summary>
    /// <param name="incident"></param>
    public void Add(Incident incident)
    {
      //I did not add business logic here intentionally. I don't want business logic in two places, and it was already in the controller.
      Incidents.Add(incident);
    }

    /// <summary>
    /// Returns only the incidents that have the matching customer id.
    /// </summary>
    /// <param name="customerId">the customer id to filter by</param>
    /// <returns>the matching incidents.</returns>
    public IEnumerable<Incident> SearchIncidentsByCustomerId(string customerId)
    {
      return Incidents.Where(incident => incident.CustomerId == customerId);
    }
  }
}