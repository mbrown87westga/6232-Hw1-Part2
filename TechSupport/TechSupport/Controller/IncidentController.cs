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
    public IEnumerable<LegacyIncident> GetIncidents(string customerId = null)
    {
      return string.IsNullOrEmpty(customerId) ? _incidentDal.GetIncidents() : _incidentDal.SearchIncidentsByCustomerId(customerId);
    }

    /// <summary>
    /// A method to save a new legacyIncident
    /// </summary>
    /// <param name="legacyIncident">the legacyIncident to save.</param>
    public void AddLegacyIncident(LegacyIncident legacyIncident)
    {
      if (legacyIncident == null)
      {
        throw new ArgumentNullException(nameof(legacyIncident));
      }

      _incidentDal.Add(legacyIncident);
    }

    /// <summary>
    /// Gets the open incidents from the db
    /// </summary>
    /// <returns>the open incidents</returns>
    public IEnumerable<Incident> GetOpenIncidents()
    {
      return _incidentDbDal.GetOpenIncidents();
    }

    /// <summary>
    /// Gets the customers from the db
    /// </summary>
    /// <returns>the customers</returns>
    public IEnumerable<Customer> GetCustomers()
    {
      return _incidentDbDal.GetCustomers();
    }

    public IEnumerable<Product> GetProducts()
    {
      return _incidentDbDal.GetProducts();
    }

    public void AddIncident(Incident incident)
    {
      if (string.IsNullOrWhiteSpace(incident.Title))
      {
        throw new ArgumentException("Title is required.");
      }
      if (string.IsNullOrWhiteSpace(incident.Description))
      {
        throw new ArgumentException("Description is required.");
      }
      if (!_incidentDbDal.IsCustomerAssociatedToProduct(incident.CustomerID, incident.ProductCode))
      {
        throw new ArgumentException("There is no registration associated with the product.");
      }
      _incidentDbDal.AddIncident(incident);
    }
  }
}
