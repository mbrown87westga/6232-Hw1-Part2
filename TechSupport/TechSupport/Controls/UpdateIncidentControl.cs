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
    private bool _loaded = false;
    private bool _modified = false;

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
      IncidentIDTextBox.Text = "";
      CustomerTextBox.Text = "";
      ProductTextBox.Text = "";
      TechnicianComboBox.SelectedIndex = 0;
      TitleTextBox.Text = "";
      DateOpenedTextBox.Text = "";
      DescriptionTextBox.Text = "";
      TestToAddTextBox.Text = "";
      _modified = false;
      _loaded = false;
      UpdateButtonStates();
    }

    private void UpdateButtonStates()
    {
      CloseButton.Enabled = _loaded;
      FormClearButton.Enabled = _loaded;
      UpdateButton.Enabled = _modified;
    }
    
    private void UpdateIncidentControl_Load(object sender, EventArgs e)
    {
      try
      {
        _technicians = _incidentController.GetTechnicians();
        TechnicianComboBox.Items.Add("--  Unassigned  --");
        foreach (Technician technician in _technicians)
        {
          TechnicianComboBox.Items.Add(technician.Name);
        }

        ClearDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void CloseClick(object sender, EventArgs e)
    {

    }

    private void GetClick(object sender, EventArgs e)
    {
      try
      {
        Incident incident = _incidentController.GetIncident(int.Parse(IncidentIDTextBox.Text));
        if (incident != null)
        {
          CustomerTextBox.Text = incident.CustomerName;
          ProductTextBox.Text = incident.ProductCode;
          TechnicianComboBox.SelectedIndex = string.IsNullOrWhiteSpace(incident.Technician) ? 0 : TechnicianComboBox.Items.IndexOf(incident.Technician);
          TitleTextBox.Text = incident.Title;
          DateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
          DescriptionTextBox.Text = incident.Description;
          _modified = false;
          _loaded = true;
        }
        else
        {
          MessageBox.Show("No incident with that ID exists.", "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void ValueChanged(object sender, EventArgs e)
    {
      _modified = true;
      UpdateButtonStates();
    }
  }
}
