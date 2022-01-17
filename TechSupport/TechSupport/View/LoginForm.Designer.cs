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
      this.PasswordTextBox = new System.Windows.Forms.MaskedTextBox();
      this.UsernameTextBox = new System.Windows.Forms.TextBox();
      this.UsernameLabel = new System.Windows.Forms.Label();
      this.PasswordLabel = new System.Windows.Forms.Label();
      this.ErrorMessageLabel = new System.Windows.Forms.Label();
      this.LoginButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Location = new System.Drawing.Point(73, 32);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.Size = new System.Drawing.Size(225, 20);
      this.PasswordTextBox.TabIndex = 0;
      // 
      // UsernameTextBox
      // 
      this.UsernameTextBox.Location = new System.Drawing.Point(73, 6);
      this.UsernameTextBox.Name = "UsernameTextBox";
      this.UsernameTextBox.Size = new System.Drawing.Size(225, 20);
      this.UsernameTextBox.TabIndex = 1;
      // 
      // UsernameLabel
      // 
      this.UsernameLabel.AutoSize = true;
      this.UsernameLabel.Location = new System.Drawing.Point(12, 9);
      this.UsernameLabel.Name = "UsernameLabel";
      this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
      this.UsernameLabel.TabIndex = 2;
      this.UsernameLabel.Text = "Username";
      // 
      // PasswordLabel
      // 
      this.PasswordLabel.AutoSize = true;
      this.PasswordLabel.Location = new System.Drawing.Point(14, 35);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
      this.PasswordLabel.TabIndex = 3;
      this.PasswordLabel.Text = "Password";
      // 
      // ErrorMessageLabel
      // 
      this.ErrorMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ErrorMessageLabel.Location = new System.Drawing.Point(15, 58);
      this.ErrorMessageLabel.Name = "ErrorMessageLabel";
      this.ErrorMessageLabel.Size = new System.Drawing.Size(202, 23);
      this.ErrorMessageLabel.TabIndex = 4;
      // 
      // LoginButton
      // 
      this.LoginButton.Location = new System.Drawing.Point(223, 58);
      this.LoginButton.Name = "LoginButton";
      this.LoginButton.Size = new System.Drawing.Size(75, 23);
      this.LoginButton.TabIndex = 5;
      this.LoginButton.Text = "Login";
      this.LoginButton.UseVisualStyleBackColor = true;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.LoginButton);
      this.Controls.Add(this.ErrorMessageLabel);
      this.Controls.Add(this.PasswordLabel);
      this.Controls.Add(this.UsernameLabel);
      this.Controls.Add(this.UsernameTextBox);
      this.Controls.Add(this.PasswordTextBox);
      this.Name = "LoginForm";
      this.Text = "LoginForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MaskedTextBox PasswordTextBox;
    private System.Windows.Forms.TextBox UsernameTextBox;
    private System.Windows.Forms.Label UsernameLabel;
    private System.Windows.Forms.Label PasswordLabel;
    private System.Windows.Forms.Label ErrorMessageLabel;
    private System.Windows.Forms.Button LoginButton;
  }
}