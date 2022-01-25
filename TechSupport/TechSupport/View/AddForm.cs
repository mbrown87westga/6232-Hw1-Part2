﻿using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
  /// <summary>
  /// The form which allows you to add a new incident.
  /// </summary>
  public partial class AddForm : Form
  {
    private readonly IncidentsController _incidentsController;

    /// <summary>
    /// this constructor initializes the component and also builds the incidents controller.
    /// </summary>
    /// <remarks>
    /// Building your own members is not a best practice because it is harder to test, but we are not testing things in this class as of yet,
    /// and I am going to follow the classes lead on this one.
    /// </remarks>
    public AddForm()
    {
      InitializeComponent();

      _incidentsController = new IncidentsController();
    }

    /// <summary>
    /// The click method for the add button. This saves the incident to the backend, clears the dialog, and then returns OK
    /// </summary>
    /// <param name="sender">Ignored.</param>
    /// <param name="e">Ignored.</param>
    private void AddClick(object sender, EventArgs e)
    {
      _incidentsController.Add(new Incident
      {
        Description = descriptionTextBox.Text,
        Title = titleTextBox.Text,
        CustomerId = customerIdTextBox.Text
      });
      ClearDialog();
      this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// The click method for the cancel button. Just closes the form and returns CANCEL
    /// </summary>
    /// <param name="sender">Ignored.</param>
    /// <param name="e">Ignored.</param>
    private void CancelClick(object sender, EventArgs e)
    {
      ClearDialog();
      this.DialogResult = DialogResult.Cancel;
    }

    private void ClearDialog()
    {
      titleTextBox.Text = "";
      customerIdTextBox.Text = "";
      descriptionTextBox.Text = "";
    }
  }
}
