using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
  public partial class SearchForm : Form
  {
    private readonly IncidentsController _incidentsController;

    public SearchForm()
    {
      InitializeComponent();

      _incidentsController = new IncidentsController();
    }
    
    private void SearchClick(object sender, EventArgs e)
    {
      resultsDataGridView.DataSource = null;
      resultsDataGridView.DataSource = new BindingSource(_incidentsController.GetIncidents(customerIdTextBox.Text), null);
    }
  }
}
