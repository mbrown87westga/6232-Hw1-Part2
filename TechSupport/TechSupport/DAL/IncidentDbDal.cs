using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
  public class IncidentDbDal
  {
    public IEnumerable<DBIncident> GetIncidents()
    {
      return new List<DBIncident> {new DBIncident{Title = "yo ho ho", Customer = "Long John", DateOpened = DateTime.Today, ProductCode = "090", Technician = "Bluebeard"}};
    }
  }
}