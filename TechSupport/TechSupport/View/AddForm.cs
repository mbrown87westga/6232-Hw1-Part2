using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
  public partial class AddForm : Form
  {
    private readonly IncidentsController _incidentsController;

    public AddForm()
    {
      InitializeComponent();

      _incidentsController = new IncidentsController();
    }

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
