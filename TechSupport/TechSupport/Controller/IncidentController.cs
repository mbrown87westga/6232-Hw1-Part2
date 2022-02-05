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
    private readonly IncidentDal _incidentDal;
    private readonly IncidentDbDal _incidentDbDal;

    /// <summary>
    /// The default constructor. Builds a DAL to get and save the incidents.
    /// </summary>
    public IncidentController()
    {
      _incidentDal = new IncidentDal();
      _incidentDbDal = new IncidentDbDal();
    }

    /// <summary>
    /// The method which returns the incidents from the backend.
    /// </summary>
    /// <param name="customerId">optional. If provided, gets all incidents for that customer.</param>
    /// <returns>the specified incidents.</returns>
    public IEnumerable<Incident> GetIncidents(string customerId = null)
    {
      return string.IsNullOrEmpty(customerId) ? _incidentDal.GetIncidents() : _incidentDal.SearchIncidentsByCustomerId(customerId);
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

      _incidentDal.Add(incident);
    }

    /// <summary>
    /// Gets the open incidents from the db
    /// </summary>
    /// <returns>the open incidents</returns>
    public IEnumerable<DBIncident> GetOpenIncidents()
    {
      return _incidentDbDal.GetIncidents();
    }
  }
}
