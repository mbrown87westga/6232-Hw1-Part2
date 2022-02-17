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
      if (!_customerDbDal.IsCustomerAssociatedToProduct(incident.CustomerID, incident.ProductCode))
      {
        throw new ArgumentException("There is no registration associated with the product.");
      }
      _incidentDbDal.AddIncident(incident);
    }

    public Incident GetIncident(int incidentID)
    {
      return _incidentDbDal.GetIncident(incidentID);
    }
  }
}
