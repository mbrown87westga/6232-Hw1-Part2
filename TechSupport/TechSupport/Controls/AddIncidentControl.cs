using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
  /// <summary>
  /// A control that allows the user to add an incident
  /// </summary>
  public partial class AddIncidentControl : UserControl
  {
    private readonly IncidentController _incidentController;

    /// <summary>
    /// this constructor initializes the component and also builds the incidents controller.
    /// </summary>
    /// <remarks>
    /// Building your own members is not a best practice because it is harder to test, but we are not testing things in this class as of yet,
    /// and I am going to follow the classes lead on this one.
    /// </remarks>
    public AddIncidentControl()
    {
      InitializeComponent();

      _incidentController = new IncidentController();
    }

    /// <summary>
    /// The click method for the add button. This saves the incident to the backend, clears the dialog, and then returns OK
    /// </summary>
    /// <param name="sender">Ignored.</param>
    /// <param name="e">Ignored.</param>
    private void AddClick(object sender, EventArgs e)
    {
      try
      {
        _incidentController.Add(new LegacyIncident
        {
          Description = DescriptionTextBox.Text,
          Title = TitleTextBox.Text,
          ProductId = 0, //Todo: make this correct
          CustomerId = 0
        });
        ClearDialog();
      }
      catch (Exception ex)
      {
        if (ex is FormatException)
        {
          MessageBox.Show("CustomerID must be an integer.", "Error");
        }
        else
        {
          throw;
        }
      }
    }

    /// <summary>
    /// The click method for the cancel button. Just closes the form and returns CANCEL
    /// </summary>
    /// <param name="sender">Ignored.</param>
    /// <param name="e">Ignored.</param>
    private void ClearClick(object sender, EventArgs e)
    {
      ClearDialog();
    }

    private void ClearDialog()
    {
      TitleTextBox.Text = "";
      CustomerComboBox.SelectedIndex = 0;
      ProductComboBox.SelectedIndex = 0;
      DescriptionTextBox.Text = "";
    }
  }
}
