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
      this.usernameTextBox = new System.Windows.Forms.TextBox();
      this.usernameLabel = new System.Windows.Forms.Label();
      this.passwordLabel = new System.Windows.Forms.Label();
      this.errorMessageLabel = new System.Windows.Forms.Label();
      this.loginButton = new System.Windows.Forms.Button();
      this.passwordTextBox = new System.Windows.Forms.TextBox();
      this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.mainTableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // usernameTextBox
      // 
      this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.usernameTextBox.Location = new System.Drawing.Point(72, 3);
      this.usernameTextBox.Name = "usernameTextBox";
      this.usernameTextBox.Size = new System.Drawing.Size(170, 20);
      this.usernameTextBox.TabIndex = 1;
      this.usernameTextBox.TextChanged += new System.EventHandler(this.EitherTextBoxTextChanged);
      // 
      // usernameLabel
      // 
      this.usernameLabel.AutoSize = true;
      this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.usernameLabel.Location = new System.Drawing.Point(3, 0);
      this.usernameLabel.Name = "usernameLabel";
      this.usernameLabel.Size = new System.Drawing.Size(63, 27);
      this.usernameLabel.TabIndex = 2;
      this.usernameLabel.Text = "Username";
      this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // passwordLabel
      // 
      this.passwordLabel.AutoSize = true;
      this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.passwordLabel.Location = new System.Drawing.Point(3, 27);
      this.passwordLabel.Name = "passwordLabel";
      this.passwordLabel.Size = new System.Drawing.Size(63, 24);
      this.passwordLabel.TabIndex = 3;
      this.passwordLabel.Text = "Password";
      this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // errorMessageLabel
      // 
      this.mainTableLayoutPanel.SetColumnSpan(this.errorMessageLabel, 2);
      this.errorMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.errorMessageLabel.Location = new System.Drawing.Point(3, 51);
      this.errorMessageLabel.Name = "errorMessageLabel";
      this.errorMessageLabel.Size = new System.Drawing.Size(239, 25);
      this.errorMessageLabel.TabIndex = 4;
      this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // loginButton
      // 
      this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.loginButton.Enabled = false;
      this.loginButton.Location = new System.Drawing.Point(248, 3);
      this.loginButton.Name = "loginButton";
      this.mainTableLayoutPanel.SetRowSpan(this.loginButton, 3);
      this.loginButton.Size = new System.Drawing.Size(53, 70);
      this.loginButton.TabIndex = 3;
      this.loginButton.Text = "Login";
      this.loginButton.UseVisualStyleBackColor = true;
      this.loginButton.Click += new System.EventHandler(this.LoginButtonClick);
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.passwordTextBox.Location = new System.Drawing.Point(72, 30);
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.PasswordChar = '*';
      this.passwordTextBox.Size = new System.Drawing.Size(170, 20);
      this.passwordTextBox.TabIndex = 2;
      this.passwordTextBox.TextChanged += new System.EventHandler(this.EitherTextBoxTextChanged);
      // 
      // mainTableLayoutPanel
      // 
      this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainTableLayoutPanel.ColumnCount = 3;
      this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.25112F));
      this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.74888F));
      this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
      this.mainTableLayoutPanel.Controls.Add(this.usernameTextBox, 1, 0);
      this.mainTableLayoutPanel.Controls.Add(this.passwordTextBox, 1, 1);
      this.mainTableLayoutPanel.Controls.Add(this.usernameLabel, 0, 0);
      this.mainTableLayoutPanel.Controls.Add(this.passwordLabel, 0, 1);
      this.mainTableLayoutPanel.Controls.Add(this.loginButton, 2, 0);
      this.mainTableLayoutPanel.Controls.Add(this.errorMessageLabel, 0, 2);
      this.mainTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
      this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
      this.mainTableLayoutPanel.RowCount = 3;
      this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
      this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
      this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.mainTableLayoutPanel.Size = new System.Drawing.Size(304, 76);
      this.mainTableLayoutPanel.TabIndex = 5;
      // 
      // LoginForm
      // 
      this.AcceptButton = this.loginButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(328, 100);
      this.Controls.Add(this.mainTableLayoutPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginFormFormClosed);
      this.mainTableLayoutPanel.ResumeLayout(false);
      this.mainTableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TextBox usernameTextBox;
    private System.Windows.Forms.Label usernameLabel;
    private System.Windows.Forms.Label passwordLabel;
    private System.Windows.Forms.Label errorMessageLabel;
    private System.Windows.Forms.Button loginButton;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
  }
}