using System.Collections.Generic;
using System.Linq;
using TechSupport.Model;

namespace TechSupport.DAL
{
  /// <summary>
  /// Data access layer for incidents
  /// </summary>
  public class IncidentDal
  {
    private static readonly List<LegacyIncident> Incidents = new List<LegacyIncident>();
    
    /// <summary>
    /// The method that returns all of the incidents.
    /// </summary>
    /// <returns>Every legacyIncident that has been stored.</returns>
    public IEnumerable<LegacyIncident> GetIncidents()
    {
      return Incidents;
    }

    /// <summary>
    /// Saves a new legacyIncident 
    /// </summary>
    /// <param name="legacyIncident"></param>
    public void Add(LegacyIncident legacyIncident)
    {
      //I did not add business logic here intentionally. I don't want business logic in two places, and it was already in the controller.
      Incidents.Add(legacyIncident);
    }

    /// <summary>
    /// Returns only the incidents that have the matching customer id.
    /// </summary>
    /// <param name="customerId">the customer id to filter by</param>
    /// <returns>the matching incidents.</returns>
    public IEnumerable<LegacyIncident> SearchIncidentsByCustomerId(string customerId)
    {
      return Incidents.Where(incident => incident.CustomerId.ToString() == customerId);
    }
  }
}