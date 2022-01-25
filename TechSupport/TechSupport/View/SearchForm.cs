using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
  /// <summary>
  /// This form is for the user to be able to filter the incidents by customerId
  /// </summary>
  public partial class SearchForm : Form
  {
    private readonly IncidentController _incidentController;

    /// <summary>
    /// The default constructor. builds the incident controller.
    /// </summary>
    public SearchForm()
    {
      InitializeComponent();

      _incidentController = new IncidentController();
    }
    
    private void SearchClick(object sender, EventArgs e)
    {
      ResultsDataGridView.DataSource = null;
      ResultsDataGridView.DataSource = new BindingSource(_incidentController.GetIncidents(CustomerIdTextBox.Text), null);
    }

    /// <summary>
    /// This is just so that it closes when you hit escape.
    /// </summary>
    /// <param name="msg">unused</param>
    /// <param name="keyData">the key data</param>
    /// <returns>true if the key was processed successfully.</returns>
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if (keyData == Keys.Escape)
      {
        this.Close();
        DialogResult = DialogResult.Cancel;
        return true;
      }
      return base.ProcessCmdKey(ref msg, keyData);
    }
  }
}
