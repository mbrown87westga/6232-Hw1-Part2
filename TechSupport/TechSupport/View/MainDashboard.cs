using System.Windows.Forms;

namespace TechSupport.View
{
  public partial class MainDashboard : Form
  {
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

    public MainDashboard()
    {
      InitializeComponent();
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
    private void MainDashboardClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

  }
}
