using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
  /// <summary>
  /// This controller is how the frontend talks to the backend.
  /// </summary>
  public class IncidentController
  {
    private readonly IncidentsDal _incidentsDal; //In your example code, you used both camelCase and underscore prefixed camelCase, so I am going with underscore prefixed for class variables.

    /// <summary>
    /// The default constructor. Builds a DAL to get and save the incidents.
    /// </summary>
    public IncidentController()
    {
      _incidentsDal = new IncidentsDal(); //Normally I would use IOC here so that this could be unit tested, but I will go with how we were instructed to do this.
    }

    /// <summary>
    /// The method which returns the incidents from the backend.
    /// </summary>
    /// <param name="customerId">optional. If provided, gets all incidents for that customer.</param>
    /// <returns>the specified incidents.</returns>
    public IEnumerable<Incident> GetIncidents(string customerId = null)
    {
      return string.IsNullOrEmpty(customerId) ? _incidentsDal.GetIncidents() : _incidentsDal.SearchIncidentsByCustomerId(customerId);
    }

    /// <summary>
    /// A method to save a new incident
    /// </summary>
    /// <param name="incident">the incident to save.</param>
    public void Add(Incident incident)
    {
      if (incident == null)
      {
        throw new ArgumentNullException(nameof(incident));
      }

      if (string.IsNullOrEmpty(incident.CustomerId))
      {
        throw new ArgumentException("CustomerID must be filled out.");
      }

      _incidentsDal.Add(incident);
    }
  }
}
