using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
  /// <summary>
  /// A control that allows the user to add an incident
  /// </summary>
  public partial class UpdateIncidentControl : UserControl
  {
    private readonly IncidentController _incidentController;
    private IEnumerable<Technician> _technicians;

    /// <summary>
    /// this constructor initializes the component and also builds the incidents controller.
    /// </summary>
    /// <remarks>
    /// Building your own members is not a best practice because it is harder to test, but we are not testing things in this class as of yet,
    /// and I am going to follow the classes lead on this one.
    /// </remarks>
    public UpdateIncidentControl()
    {
      InitializeComponent();

      _incidentController = new IncidentController();
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
      TechnicianComboBox.SelectedIndex = 0;
      DescriptionTextBox.Text = "";
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
      CloseButton.Enabled = !string.IsNullOrEmpty(TitleTextBox.Text) && !string.IsNullOrEmpty(DescriptionTextBox.Text);
    }

    private void UpdateIncidentControl_Load(object sender, EventArgs e)
    {
      try
      {
        _technicians = _incidentController.GetTechnicians();
        foreach (Technician technician in _technicians)
        {
          TechnicianComboBox.Items.Add(technician.Name);
        }
        
        ClearDialog();
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void CloseClick(object sender, EventArgs e)
    {

    }
  }
}
