using System;
using System.Collections.Generic;
using TechSupportData;
using TechSupportData.DAL;
using TechSupportData.Models;

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
    /// Gets the Technicians which have incidents from the db
    /// </summary>
    /// <returns>the Technicians</returns>
    public IEnumerable<Technician> GetTechniciansWithIncidents()
    {
      return _technicianDbDal.GetTechniciansWithIncidents();
    }

    /// <summary>
    /// Gets the technicians email and phone
    /// </summary>
    /// <param name="technicianId">the technician's id</param>
    /// <returns>the technician with only some fields populated (see above)</returns>
    public Technician GetTechnicianEmailAndPhone(int technicianId)
    {
      return _technicianDbDal.GetTechnicianEmailAndPhone(technicianId);
    }

    /// <summary>
    /// Gets the open technician's incidents
    /// </summary>
    /// <param name="technicianId">the id of the technician to get</param>
    /// <returns>the incidents as a list</returns>
    public List<Incident> GetOpenTechnicianIncidents(int technicianId)
    {
      return _incidentDbDal.GetOpenTechnicianIncidents(technicianId);
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
      if (incidentId <= 0)
      {
        throw new ArgumentException("IncidentId must be > 0");
      }
      return _incidentDbDal.GetIncident(incidentId);
    }

    /// <summary>
    /// Updates an incident as long as we have the newest version of the incident.
    /// </summary>
    /// <param name="incident">The incident with its new values</param>
    /// <param name="originalIncident">the original incident - used to check to see if the incident has been modified or not.</param>
    public void UpdateIncident(Incident incident, Incident originalIncident)
    {
      if (incident.IncidentId <= 0)
      {
        throw new ArgumentException("IncidentId must be > 0");
      }
      if (string.IsNullOrWhiteSpace(incident.Description))
      {
        throw new ArgumentException("Description is required.");
      }
      
      int updatedRows = _incidentDbDal.UpdateIncident(incident, originalIncident);

      if (updatedRows == 0)
      {
        throw new InvalidOperationException("The incident was updated in the db! Update aborted.");
      }
      if (updatedRows > 1)
      {
        throw new InvalidOperationException("Multiple incidents were updated in the db!");
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
