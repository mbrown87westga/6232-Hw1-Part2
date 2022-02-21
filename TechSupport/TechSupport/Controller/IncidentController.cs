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
    private readonly IncidentDbDal _incidentDbDal;
    private readonly CustomerDbDal _customerDbDal;
    private readonly ProductDbDal _productDbDal;
    private readonly TechnicianDbDal _technicianDbDal;

    /// <summary>
    /// The default constructor. Builds a DAL to get and save the incidents.
    /// </summary>
    public IncidentController()
    {
      _incidentDbDal = new IncidentDbDal();
      _customerDbDal = new CustomerDbDal();
      _productDbDal = new ProductDbDal();
      _technicianDbDal = new TechnicianDbDal();
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
      return _customerDbDal.GetCustomers();
    }

    /// <summary>
    /// Gets the products from the db
    /// </summary>
    /// <returns>the products</returns>
    public IEnumerable<Product> GetProducts()
    {
      return _productDbDal.GetProducts();
    }

    /// <summary>
    /// Gets the Technicians from the db
    /// </summary>
    /// <returns>the Technicians</returns>
    public IEnumerable<Technician> GetTechnicians()
    {
      return _technicianDbDal.GetTechnicians();
    }

    /// <summary>
    /// adds an incident to the db
    /// </summary>
    /// <param name="incident">the incident</param>
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
      if (!_customerDbDal.IsCustomerAssociatedToProduct(incident.CustomerId, incident.ProductCode))
      {
        throw new ArgumentException("There is no registration associated with the product.");
      }
      _incidentDbDal.AddIncident(incident);
    }

    /// <summary>
    /// Gets an incident from the DB
    /// </summary>
    /// <param name="incidentId">The id of the incident to get</param>
    /// <returns>The incident</returns>
    public Incident GetIncident(int incidentId)
    {
      return _incidentDbDal.GetIncident(incidentId);
    }

    /// <summary>
    /// Updates an incident as long as we have the newest version of the incident.
    /// </summary>
    /// <param name="incident">The incident with its new values</param>
    /// <param name="originalIncident">the original incident - used to check to see if the incident has been modified or not.</param>
    public void UpdateIncident(Incident incident, Incident originalIncident)
    {
      var existingIncident = GetIncident(incident.IncidentId);

      if (existingIncident.Equals(originalIncident))
      {
        _incidentDbDal.UpdateIncident(incident);
      }
      else
      {
        throw new InvalidOperationException("The incident was updated in the db! Update aborted.");
      }
    }

    /// <summary>
    /// Closes an incident as long as we have the newest version of the incident.
    /// </summary>
    /// <param name="incidentId">the incident to close</param>
    /// <param name="originalIncident">the original incident - used to check to see if the incident has been modified or not.</param>
    public void CloseIncident(int incidentId, Incident originalIncident)
    {
      var existingIncident = GetIncident(incidentId);

      if (existingIncident.Equals(originalIncident))
      {
        _incidentDbDal.CloseIncident(incidentId);
      }
      else
      {
        throw new InvalidOperationException("The incident was updated in the db! Update aborted.");
      }
    }
  }
}
