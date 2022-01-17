using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
      if (UsernameTextBox.Text == "Jane" && PasswordTextBox.Text == "test1234")
      {
        MessageBox.Show("log in success!");
      }
      else
      {
        ErrorMessageLabel.Text = "invalid username/password";
      }
    }
  }
}
