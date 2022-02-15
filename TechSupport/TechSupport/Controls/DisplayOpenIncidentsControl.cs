using System;
using System.Linq;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.Controls
{
  /// <summary>
  /// A control that shows all the incidents in the db unfiltered.
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
      try
      {
        this.ErrorLabel.Text = "";
        this.OpenIncidentsListView.Show();
        this.ErrorLabel.Hide();

        var incidents = _incidentController.GetOpenIncidents().ToList();
        OpenIncidentsListView.Items.Clear();
        for (int i = 0; i < incidents.Count; i++)
        {
          var incident = incidents[i];
          OpenIncidentsListView.Items.Add(incident.ProductCode);
          OpenIncidentsListView.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
          OpenIncidentsListView.Items[i].SubItems.Add(incident.CustomerName);
          OpenIncidentsListView.Items[i].SubItems.Add(incident.Technician);
          OpenIncidentsListView.Items[i].SubItems.Add(incident.Title);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void DisplayOpenIncidentsControlVisibleChanged(object sender, EventArgs e)
    {
      SetDataSource();
    }
  }
}
