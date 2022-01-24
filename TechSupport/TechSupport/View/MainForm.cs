using System.Windows.Forms;

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
    private string username;
    /// <summary>
    /// The username of the currently logged in user.
    /// </summary>
    /// <remarks>
    /// Note how setting this also sets the LoggedInUserLabel's text. This is a poor person's data binding.
    /// </remarks>
    public string Username
    {
      get { return username; }
      set
      {
        username = value;
        LoggedInUserLabel.Text = value;
      }
    }

    /// <summary>
    /// this is a required method on any form. I am not really doing anything special here.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Shows the login form again.
    /// </summary>
    /// <param name="sender">ignored</param>
    /// <param name="e">ignored</param>
    private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.HideThisAndShowForm<LoginForm>();
    }

    /// <summary>
    /// Exits the application.
    /// </summary>
    /// <param name="sender">ignored</param>
    /// <param name="e">ignored</param>
    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void addIncident_Click(object sender, System.EventArgs e)
    {

    }
    private void searchIncident_Click(object sender, System.EventArgs e)
    {

    }
  }
}
