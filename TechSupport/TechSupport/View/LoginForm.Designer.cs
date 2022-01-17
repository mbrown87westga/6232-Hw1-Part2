namespace TechSupport.View
{
  partial class LoginForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
      this.usernameTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.Location = new System.Drawing.Point(213, 247);
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.Size = new System.Drawing.Size(225, 20);
      this.passwordTextBox.TabIndex = 0;
      // 
      // usernameTextBox
      // 
      this.usernameTextBox.Location = new System.Drawing.Point(210, 194);
      this.usernameTextBox.Name = "usernameTextBox";
      this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
      this.usernameTextBox.TabIndex = 1;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.usernameTextBox);
      this.Controls.Add(this.passwordTextBox);
      this.Name = "LoginForm";
      this.Text = "LoginForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MaskedTextBox passwordTextBox;
    private System.Windows.Forms.TextBox usernameTextBox;
  }
}