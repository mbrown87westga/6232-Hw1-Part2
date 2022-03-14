using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupportData.Models;

namespace TechSupport.Controls
{
  /// <summary>
  /// A control that allows the user to add an incident
  /// </summary>
  public partial class UpdateIncidentControl : UserControl
  {
    private readonly IncidentController _incidentController;
    private IEnumerable<Technician> _technicians;
    private bool _loaded;
    private Incident _loadedIncident;

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

    private void ClearDialog(bool clearIncidentId = true)
    {
      if (clearIncidentId)
      {
        IncidentIDTextBox.Text = "";
      }

      CustomerTextBox.Text = "";
      ProductTextBox.Text = "";
      TechnicianComboBox.SelectedIndex = 0;
      TitleTextBox.Text = "";
      DateOpenedTextBox.Text = "";
      DescriptionTextBox.Text = "";
      TextToAddTextBox.Text = "";
      _loadedIncident = null;
      _loaded = false;
      UpdateButtonStates();
    }

    private void UpdateButtonStates()
    {
      CloseButton.Enabled = _loaded && IsOpen() && TechnicianComboBox.SelectedIndex != 0;
      FormClearButton.Enabled = _loaded;
      TechnicianComboBox.Enabled = _loaded && IsOpen();
      UpdateButton.Enabled = IsModified() && IsOpen();
      TextToAddTextBox.Enabled = DescriptionTextBox.Text.Length < 200 && IsOpen();
    }

    private bool IsOpen()
    {
      return _loadedIncident != null && _loadedIncident.DateClosed == null;
    }

    private bool IsModified()
    {
      if (_loadedIncident == null)
      {
        return false;
      }

      return !(string.IsNullOrWhiteSpace(TextToAddTextBox.Text) &&
               TechnicianComboBox.SelectedIndex == GetTechnicianIndex(_loadedIncident.Technician));
    }

    private int GetTechnicianIndex(string technician)
    {
      return string.IsNullOrWhiteSpace(technician) ? 0 : TechnicianComboBox.Items.IndexOf(technician);
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

    private void GetClick(object sender, EventArgs e)
    {
      try
      {
        if (!int.TryParse(IncidentIDTextBox.Text, out var incidentId))
        {
          throw new FormatException("The Incident ID must be a number.");
        }

        PerformGetIncident(incidentId);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void PerformGetIncident(int incidentId)
    {
      Incident incident = _incidentController.GetIncident(incidentId);
      if (incident != null)
      {
        CustomerTextBox.Text = incident.CustomerName;
        ProductTextBox.Text = incident.ProductCode;
        TechnicianComboBox.SelectedIndex = string.IsNullOrWhiteSpace(incident.Technician)
          ? 0
          : GetTechnicianIndex(incident.Technician);
        TitleTextBox.Text = incident.Title;
        DateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
        DescriptionTextBox.Text = incident.Description;
        _loadedIncident = incident;
        _loaded = true;
        UpdateButtonStates();
        if (!IsOpen())
        {
          MessageBox.Show(
            "This incident is closed. It may not be modified.",
            "Incident Closed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (DescriptionTextBox.Text.Length >= 200)
        {
          //I added this since it was in the requirements, however I think that making a red text block right above the disabled input would be better ui design, because message boxes
          //stop the user until they interact with them.
          MessageBox.Show(
            "The incident's description is already at its max length - you cannot add anything more to it.",
            "Max input length reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
      else
      {
        MessageBox.Show("No incident with that ID exists.", "There was an Error", MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        ClearDialog();
      }
    }

    private void ValueChanged(object sender, EventArgs e)
    {
      UpdateButtonStates();
    }

    private void UpdateClick(object sender, EventArgs e)
    {
      try
      {
        if (PerformUpdate())
        {
          PerformGetIncident(_loadedIncident.IncidentId);
          TextToAddTextBox.Text = String.Empty;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private bool PerformUpdate()
    {
      var newDescriptionText = string.IsNullOrWhiteSpace(TextToAddTextBox.Text) ? DescriptionTextBox.Text :
        DescriptionTextBox.Text + $"\r\n<{DateTime.Now.ToShortDateString()}> " + TextToAddTextBox.Text;

      if (newDescriptionText.Length > 200)
      {
        var result =
          MessageBox.Show(
            $"The description is {newDescriptionText.Length - 200} character(s) too long and will be truncated.", "Confirm Truncation", MessageBoxButtons.OKCancel);
        if (result == DialogResult.OK)
        {
          newDescriptionText = newDescriptionText.Substring(0, 200);
        }
        else if (result == DialogResult.Cancel)
        {
          return false;
        }
      }

      _incidentController.UpdateIncident(new Incident
      {
        Description = newDescriptionText,
        TechId = _technicians.SingleOrDefault(x => x.Name == TechnicianComboBox.SelectedItem.ToString())?.TechId,
        IncidentId = _loadedIncident.IncidentId,
        ProductCode = _loadedIncident.ProductCode,
        CustomerName = _loadedIncident.CustomerName,
        DateOpened = _loadedIncident.DateOpened,
        Technician = IncidentIDTextBox.Text,
        CustomerId = _loadedIncident.CustomerId,
        Title = _loadedIncident.Title
      }, _loadedIncident);

      return true;
    }

    private void CloseClick(object sender, EventArgs e)
    {
      try
      {
        int incidentId = _loadedIncident.IncidentId;
        var result =
          MessageBox.Show("The incident cannot be updated in this form once closed. Are you sure?", "Confirm Close", MessageBoxButtons.OKCancel);
        if (result == DialogResult.Cancel)
        {
          return;
        }

        if (!PerformUpdate())
        {
          return;
        }

        PerformGetIncident(incidentId);
        TextToAddTextBox.Text = String.Empty;

        _incidentController.CloseIncident(incidentId, _loadedIncident);

        PerformGetIncident(incidentId);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void IncidentIDTextBox_TextChanged(object sender, EventArgs e)
    {
      ClearDialog(false);
    }
  }
}
