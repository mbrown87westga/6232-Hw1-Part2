using System.Collections.Generic;
using System.Linq;
using TechSupport.Model;

namespace TechSupport.DAL
{
  public class IncidentsDal
  {
    private static readonly List<Incident> _incidents = new List<Incident>();
    
    public IEnumerable<Incident> GetIncidents()
    {
      return _incidents;
    }

    public void Add(Incident incident)
    {
      //I did not add business logic here intentionally. I don't want business logic in two places, and it was already in the controller.
      _incidents.Add(incident);
    }

    public IEnumerable<Incident> SearchIncidentsByCustomerId(string customerId)
    {
      return _incidents.Where(incident => incident.CustomerId == customerId);
    }
  }
}