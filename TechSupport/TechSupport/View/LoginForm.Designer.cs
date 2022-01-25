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
      this.UsernameTextBox = new System.Windows.Forms.TextBox();
      this.UsernameLabel = new System.Windows.Forms.Label();
      this.PasswordLabel = new System.Windows.Forms.Label();
      this.ErrorMessageLabel = new System.Windows.Forms.Label();
      this.LoginButton = new System.Windows.Forms.Button();
      this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
      this.MainTableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // UsernameTextBox
      // 
      this.UsernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UsernameTextBox.Location = new System.Drawing.Point(73, 3);
      this.UsernameTextBox.Name = "UsernameTextBox";
      this.UsernameTextBox.Size = new System.Drawing.Size(171, 20);
      this.UsernameTextBox.TabIndex = 1;
      this.UsernameTextBox.TextChanged += new System.EventHandler(this.EitherTextBoxTextChanged);
      // 
      // UsernameLabel
      // 
      this.UsernameLabel.AutoSize = true;
      this.UsernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UsernameLabel.Location = new System.Drawing.Point(3, 0);
      this.UsernameLabel.Name = "UsernameLabel";
      this.UsernameLabel.Size = new System.Drawing.Size(64, 27);
      this.UsernameLabel.TabIndex = 2;
      this.UsernameLabel.Text = "Username";
      this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PasswordLabel
      // 
      this.PasswordLabel.AutoSize = true;
      this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PasswordLabel.Location = new System.Drawing.Point(3, 27);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.Size = new System.Drawing.Size(64, 24);
      this.PasswordLabel.TabIndex = 3;
      this.PasswordLabel.Text = "Password";
      this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ErrorMessageLabel
      // 
      this.MainTableLayoutPanel.SetColumnSpan(this.ErrorMessageLabel, 2);
      this.ErrorMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ErrorMessageLabel.Location = new System.Drawing.Point(3, 51);
      this.ErrorMessageLabel.Name = "ErrorMessageLabel";
      this.ErrorMessageLabel.Size = new System.Drawing.Size(241, 25);
      this.ErrorMessageLabel.TabIndex = 4;
      this.ErrorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // LoginButton
      // 
      this.LoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LoginButton.Location = new System.Drawing.Point(250, 3);
      this.LoginButton.Name = "LoginButton";
      this.MainTableLayoutPanel.SetRowSpan(this.LoginButton, 3);
      this.LoginButton.Size = new System.Drawing.Size(51, 70);
      this.LoginButton.TabIndex = 3;
      this.LoginButton.Text = "Login";
      this.LoginButton.UseVisualStyleBackColor = true;
      this.LoginButton.Click += new System.EventHandler(this.LoginButtonClick);
      // 
      // fileSystemWatcher1
      // 
      this.fileSystemWatcher1.EnableRaisingEvents = true;
      this.fileSystemWatcher1.SynchronizingObject = this;
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PasswordTextBox.Location = new System.Drawing.Point(73, 30);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.PasswordChar = '*';
      this.PasswordTextBox.Size = new System.Drawing.Size(171, 20);
      this.PasswordTextBox.TabIndex = 2;
      this.PasswordTextBox.TextChanged += new System.EventHandler(this.EitherTextBoxTextChanged);
      // 
      // MainTableLayoutPanel
      // 
      this.MainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.MainTableLayoutPanel.ColumnCount = 3;
      this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.25112F));
      this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.74888F));
      this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
      this.MainTableLayoutPanel.Controls.Add(this.UsernameTextBox, 1, 0);
      this.MainTableLayoutPanel.Controls.Add(this.PasswordTextBox, 1, 1);
      this.MainTableLayoutPanel.Controls.Add(this.UsernameLabel, 0, 0);
      this.MainTableLayoutPanel.Controls.Add(this.PasswordLabel, 0, 1);
      this.MainTableLayoutPanel.Controls.Add(this.LoginButton, 2, 0);
      this.MainTableLayoutPanel.Controls.Add(this.ErrorMessageLabel, 0, 2);
      this.MainTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
      this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
      this.MainTableLayoutPanel.RowCount = 3;
      this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
      this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
      this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.MainTableLayoutPanel.Size = new System.Drawing.Size(304, 76);
      this.MainTableLayoutPanel.TabIndex = 5;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(328, 100);
      this.Controls.Add(this.MainTableLayoutPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginFormFormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
      this.MainTableLayoutPanel.ResumeLayout(false);
      this.MainTableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TextBox UsernameTextBox;
    private System.Windows.Forms.Label UsernameLabel;
    private System.Windows.Forms.Label PasswordLabel;
    private System.Windows.Forms.Label ErrorMessageLabel;
    private System.Windows.Forms.Button LoginButton;
    private System.IO.FileSystemWatcher fileSystemWatcher1;
    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
  }
}