using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.Controls
{
  /// <summary>
  /// A control that allows the user to search through the incidents.
  /// </summary>
  public partial class SearchIncidentsControl : UserControl
  {
    private readonly IncidentController _incidentController;

    /// <summary>
    /// The default constructor. builds the incident controller.
    /// </summary>
    public SearchIncidentsControl()
    {
      InitializeComponent();

      _incidentController = new IncidentController();
    }

    private void SearchClick(object sender, EventArgs e)
    {
      ResultsDataGridView.DataSource = null;
      ResultsDataGridView.DataSource = new BindingSource(_incidentController.GetIncidents(CustomerIdTextBox.Text), null);
    }
  }
}
