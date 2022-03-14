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
  public partial class AddIncidentControl : UserControl
  {
    private readonly IncidentController _incidentController;
    private IEnumerable<Customer> _customers;
    private IEnumerable<Product> _products;

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
        _incidentController.AddIncident(new Incident
        {
          Description = DescriptionTextBox.Text,
          Title = TitleTextBox.Text,
          ProductCode = _products.Single(x => x.Name == (string) ProductComboBox.SelectedItem).ProductCode,
          CustomerId = _customers.Single(x => x.Name == (string) CustomerComboBox.SelectedItem).CustomerId
        });
        MessageBox.Show("Incident was successfully added to the DB.", "Confirmation", MessageBoxButtons.OK,
          MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        ClearDialog();
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

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
      AddButton.Enabled = !string.IsNullOrEmpty(TitleTextBox.Text) && !string.IsNullOrEmpty(DescriptionTextBox.Text);
    }

    private void AddIncidentControl_Load(object sender, EventArgs e)
    {
      try
      {
        _customers = _incidentController.GetCustomers();
        foreach (Customer customer in _customers)
        {
          CustomerComboBox.Items.Add(customer.Name);
        }

        _products = _incidentController.GetProducts();
        foreach (Product product in _products)
        {
          ProductComboBox.Items.Add(product.Name);
        }
        
        ClearDialog();
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, "There was an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }
  }
}
