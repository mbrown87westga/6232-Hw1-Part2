using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupportData;

namespace TechSupport.View
{
  /// <summary>
  /// This is the login form. The app starts up this one when it first starts.
  /// </summary>
  public partial class LoginForm : Form
  {
    /// <summary>
    /// this is a required method on any form. I am not really doing anything special here.
    /// </summary>
    public LoginForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// tries to log in using the current credentials. If successful, it shows the main form.
    /// </summary>
    /// <param name="sender">ignored</param>
    /// <param name="e">ignored</param>
    private void LoginButtonClick(object sender, EventArgs e)
    {
      if (UsernameTextBox.Text == "Jane" && PasswordTextBox.Text == "test1234")
      {
        var mainForm = this.HideThisAndShowForm<MainDashboard>();
        mainForm.Username = UsernameTextBox.Text;
        UsernameTextBox.Clear(); //clearing these to make the form clean when we re-enter it after logging out.
        PasswordTextBox.Clear();
      }
      else
      {
        UsernameTextBox.Select(0, UsernameTextBox.TextLength); //this selects the username text box, since you probably want to fill it out again.
        UsernameTextBox.Select();
        ErrorMessageLabel.ForeColor = Color.Red;
        ErrorMessageLabel.Text = "invalid username/password";
      }

    }

    /// <summary>
    /// Removes the error text when anything is entered on the username or password fields. Since
    /// they were never cleared out, this removes it immediately upon the text changing.
    /// </summary>
    /// <param name="sender">ignored</param>
    /// <param name="e">ignored</param>
    private void EitherTextBoxTextChanged(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text))
      {
        LoginButton.Enabled = false;
      }
      else
      {
        LoginButton.Enabled = true;
      }

      if (!string.IsNullOrEmpty(ErrorMessageLabel.Text) &&
          (!string.IsNullOrEmpty(UsernameTextBox.Text) ||
           !string.IsNullOrEmpty(PasswordTextBox.Text)))
      {
        ErrorMessageLabel.Text = "";
        ErrorMessageLabel.ForeColor = Color.Black; //An assumption: I think I should reset the color to the default color when the error is fixed.
      }
    }

    /// <summary>
    /// Exits the application.
    /// </summary>
    /// <param name="sender">ignored</param>
    /// <param name="e">ignored</param>
    private void LoginFormFormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
  }
}
