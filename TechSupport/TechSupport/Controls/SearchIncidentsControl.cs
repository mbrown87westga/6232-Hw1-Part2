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

namespace TechSupport.Controls
{
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
