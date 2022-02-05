using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.Controls
{
  /// <summary>
  /// A control that shows all the incidents unfiltered.
  /// </summary>
  public partial class LoadAllIncidentsControl : UserControl
  {
    readonly IncidentController _incidentController;
    
    /// <summary>
    /// this is a required method on any form. I am not really doing anything special here.
    /// </summary>
    public LoadAllIncidentsControl()
    {
      InitializeComponent();

      _incidentController = new IncidentController();
    }

    private void SetDataSource()
    {
      IncidentsDataGridView.DataSource = null;
      IncidentsDataGridView.DataSource = new BindingSource(_incidentController.GetIncidents(), null);
    }

    private void LoadAllIncidentsControlVisibleChanged(object sender, EventArgs e)
    {
      SetDataSource();
    }
  }
}
