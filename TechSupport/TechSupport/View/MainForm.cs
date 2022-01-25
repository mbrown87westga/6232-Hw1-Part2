using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
  /// <summary>
  /// This is the main form of the application.
  /// </summary>
  /// <remarks>
  /// I am not sure what this is supposed to do at this point, but currently it shows the logged in user's name and allows you to log out.
  /// </remarks>
  public partial class MainForm : Form
  {
    readonly IncidentController _incidentController;

    private string _username;
    /// <summary>
    /// The username of the currently logged in user.
    /// </summary>
    /// <remarks>
    /// Note how setting this also sets the LoggedInUserLabel's text. This is a poor person's data binding.
    /// </remarks>
    public string Username
    {
      get => _username;
      set
      {
        _username = value;
        LoggedInUserLabel.Text = value;
      }
    }

    /// <summary>
    /// this is a required method on any form. I am not really doing anything special here.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();

      _incidentController = new IncidentController();
    }
    private void MainFormLoad(object sender, System.EventArgs e)
    {
      SetDataSource();
    }

    private void SetDataSource()
    {
      IncidentsDataGridView.DataSource = null;
      IncidentsDataGridView.DataSource = new BindingSource(_incidentController.GetIncidents(), null);
    }

    /// <summary>
    /// Shows the login form again.
    /// </summary>
    /// <param name="sender">ignored</param>
    /// <param name="e">ignored</param>
    private void LogoutLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.HideThisAndShowForm<LoginForm>();
    }

    /// <summary>
    /// Exits the application.
    /// </summary>
    /// <param name="sender">ignored</param>
    /// <param name="e">ignored</param>
    private void MainFormFormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void AddIncidentClick(object sender, System.EventArgs e)
    {
      var (_, result) = this.ShowFormAsModal<AddForm>();
      if (result == DialogResult.OK)
      {
        SetDataSource();
      }
    }
    private void SearchIncidentClick(object sender, System.EventArgs e)
    {
      this.ShowFormAsModal<SearchForm>();
    }
  }
}
