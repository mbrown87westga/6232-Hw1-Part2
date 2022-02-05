using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport.Controls
{
  /// <summary>
  /// A control that shows all the incidents unfiltered.
  /// </summary>
  public partial class DisplayOpenIncidentsControl : UserControl
  {
    readonly IncidentController _incidentController;
    
    /// <summary>
    /// this is a required method on any form. I am not really doing anything special here.
    /// </summary>
    public DisplayOpenIncidentsControl()
    {
      InitializeComponent();

      _incidentController = new IncidentController();
    }

    private void SetDataSource()
    {
      var incidents = _incidentController.GetOpenIncidents().ToList();
      OpenIncidentsListView.Items.Clear();
      for (int i = 0; i < incidents.Count; i++)
      {
        var incident = incidents[i];
        OpenIncidentsListView.Items.Add(incident.ProductCode);
        OpenIncidentsListView.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
        OpenIncidentsListView.Items[i].SubItems.Add(incident.Customer);
        OpenIncidentsListView.Items[i].SubItems.Add(incident.Technician);
        OpenIncidentsListView.Items[i].SubItems.Add(incident.Title);
      }
    }

    private void DisplayOpenIncidentsControlVisibleChanged(object sender, EventArgs e)
    {
      SetDataSource();
    }
  }
}
