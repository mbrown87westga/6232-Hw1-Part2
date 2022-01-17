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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // UsernameTextBox
      // 
      this.UsernameTextBox.Location = new System.Drawing.Point(163, 3);
      this.UsernameTextBox.Name = "UsernameTextBox";
      this.UsernameTextBox.Size = new System.Drawing.Size(158, 20);
      this.UsernameTextBox.TabIndex = 1;
      // 
      // UsernameLabel
      // 
      this.UsernameLabel.AutoSize = true;
      this.UsernameLabel.Location = new System.Drawing.Point(3, 0);
      this.UsernameLabel.Name = "UsernameLabel";
      this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
      this.UsernameLabel.TabIndex = 2;
      this.UsernameLabel.Text = "Username";
      // 
      // PasswordLabel
      // 
      this.PasswordLabel.AutoSize = true;
      this.PasswordLabel.Location = new System.Drawing.Point(3, 42);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
      this.PasswordLabel.TabIndex = 3;
      this.PasswordLabel.Text = "Password";
      // 
      // ErrorMessageLabel
      // 
      this.ErrorMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ErrorMessageLabel.Location = new System.Drawing.Point(3, 79);
      this.ErrorMessageLabel.Name = "ErrorMessageLabel";
      this.ErrorMessageLabel.Size = new System.Drawing.Size(154, 23);
      this.ErrorMessageLabel.TabIndex = 4;
      // 
      // LoginButton
      // 
      this.LoginButton.Location = new System.Drawing.Point(163, 82);
      this.LoginButton.Name = "LoginButton";
      this.LoginButton.Size = new System.Drawing.Size(75, 23);
      this.LoginButton.TabIndex = 3;
      this.LoginButton.Text = "Login";
      this.LoginButton.UseVisualStyleBackColor = true;
      this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
      // 
      // fileSystemWatcher1
      // 
      this.fileSystemWatcher1.EnableRaisingEvents = true;
      this.fileSystemWatcher1.SynchronizingObject = this;
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Location = new System.Drawing.Point(163, 45);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.PasswordChar = '*';
      this.PasswordTextBox.Size = new System.Drawing.Size(158, 20);
      this.PasswordTextBox.TabIndex = 2;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.66216F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.33784F));
      this.tableLayoutPanel1.Controls.Add(this.UsernameTextBox, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.ErrorMessageLabel, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.PasswordTextBox, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.UsernameLabel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.LoginButton, 1, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 111);
      this.tableLayoutPanel1.TabIndex = 5;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(324, 111);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LoginForm";
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
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
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}