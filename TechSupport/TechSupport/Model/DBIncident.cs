using System;
using System.Runtime.Remoting;

namespace TechSupport.Model
{
  public class DBIncident
  {
    public string ProductCode { get; set; }
    public DateTime DateOpened { get; set; }
    public string Customer { get; set; }
    public string Technician { get; set; }
    public string Title { get; set; }
  }
}