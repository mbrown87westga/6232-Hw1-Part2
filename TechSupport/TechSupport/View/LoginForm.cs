using System;
using System.Drawing;
using System.Windows.Forms;

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
      if (usernameTextBox.Text == "Jane" && passwordTextBox.Text == "test1234")
      {
        var mainForm = this.HideThisAndShowForm<MainForm>();
        mainForm.Username = usernameTextBox.Text;
        usernameTextBox.Clear(); //clearing these to make the form clean when we re-enter it after logging out.
        passwordTextBox.Clear();
      }
      else
      {
        usernameTextBox.Select(0, usernameTextBox.TextLength); //this selects the username text box, since you probably want to fill it out again.
        usernameTextBox.Select();
        errorMessageLabel.ForeColor = Color.Red;
        errorMessageLabel.Text = "invalid username/password";
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
      if (String.IsNullOrEmpty(usernameTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text))
      {
        loginButton.Enabled = false;
      }
      else
      {
        loginButton.Enabled = true;
      }

      if (!string.IsNullOrEmpty(errorMessageLabel.Text) &&
          (!string.IsNullOrEmpty(usernameTextBox.Text) ||
           !string.IsNullOrEmpty(passwordTextBox.Text)))
      {
        errorMessageLabel.Text = "";
        errorMessageLabel.ForeColor = Color.Black; //An assumption: I think I should reset the color to the default color when the error is fixed.
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
