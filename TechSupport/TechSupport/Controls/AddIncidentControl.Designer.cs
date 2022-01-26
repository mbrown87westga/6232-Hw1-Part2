namespace TechSupport.View
{
  partial class AddIncidentControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.RequiredDescriptionLabel = new System.Windows.Forms.Label();
      this.RequiredDescriptionAsteriskLabel = new System.Windows.Forms.Label();
      this.CustomerIdRequiredLabel = new System.Windows.Forms.Label();
      this.AddButton = new System.Windows.Forms.Button();
      this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
      this.CustomerIdLabel = new System.Windows.Forms.Label();
      this.DescriptionTextBox = new System.Windows.Forms.TextBox();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.TitleTextBox = new System.Windows.Forms.TextBox();
      this.TitleLabel = new System.Windows.Forms.Label();
      this.FormClearButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // RequiredDescriptionLabel
      // 
      this.RequiredDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.RequiredDescriptionLabel.AutoSize = true;
      this.RequiredDescriptionLabel.Location = new System.Drawing.Point(24, 131);
      this.RequiredDescriptionLabel.Name = "RequiredDescriptionLabel";
      this.RequiredDescriptionLabel.Size = new System.Drawing.Size(56, 13);
      this.RequiredDescriptionLabel.TabIndex = 19;
      this.RequiredDescriptionLabel.Text = "- Required";
      // 
      // RequiredDescriptionAsteriskLabel
      // 
      this.RequiredDescriptionAsteriskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.RequiredDescriptionAsteriskLabel.AutoSize = true;
      this.RequiredDescriptionAsteriskLabel.ForeColor = System.Drawing.Color.Red;
      this.RequiredDescriptionAsteriskLabel.Location = new System.Drawing.Point(12, 131);
      this.RequiredDescriptionAsteriskLabel.Name = "RequiredDescriptionAsteriskLabel";
      this.RequiredDescriptionAsteriskLabel.Size = new System.Drawing.Size(11, 13);
      this.RequiredDescriptionAsteriskLabel.TabIndex = 18;
      this.RequiredDescriptionAsteriskLabel.Text = "*";
      // 
      // CustomerIdRequiredLabel
      // 
      this.CustomerIdRequiredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerIdRequiredLabel.AutoSize = true;
      this.CustomerIdRequiredLabel.ForeColor = System.Drawing.Color.Red;
      this.CustomerIdRequiredLabel.Location = new System.Drawing.Point(142, 15);
      this.CustomerIdRequiredLabel.Name = "CustomerIdRequiredLabel";
      this.CustomerIdRequiredLabel.Size = new System.Drawing.Size(11, 13);
      this.CustomerIdRequiredLabel.TabIndex = 17;
      this.CustomerIdRequiredLabel.Text = "*";
      // 
      // AddButton
      // 
      this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.AddButton.Enabled = false;
      this.AddButton.Location = new System.Drawing.Point(103, 126);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(75, 23);
      this.AddButton.TabIndex = 14;
      this.AddButton.Text = "Add";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.AddClick);
      // 
      // CustomerIdTextBox
      // 
      this.CustomerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerIdTextBox.Location = new System.Drawing.Point(159, 12);
      this.CustomerIdTextBox.Name = "CustomerIdTextBox";
      this.CustomerIdTextBox.Size = new System.Drawing.Size(100, 20);
      this.CustomerIdTextBox.TabIndex = 11;
      this.CustomerIdTextBox.TextChanged += new System.EventHandler(this.customerIdTextBoxTextChanged);
      // 
      // CustomerIdLabel
      // 
      this.CustomerIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerIdLabel.AutoSize = true;
      this.CustomerIdLabel.Location = new System.Drawing.Point(81, 15);
      this.CustomerIdLabel.Name = "CustomerIdLabel";
      this.CustomerIdLabel.Size = new System.Drawing.Size(65, 13);
      this.CustomerIdLabel.TabIndex = 15;
      this.CustomerIdLabel.Text = "Customer ID";
      // 
      // DescriptionTextBox
      // 
      this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DescriptionTextBox.Location = new System.Drawing.Point(12, 57);
      this.DescriptionTextBox.Multiline = true;
      this.DescriptionTextBox.Name = "DescriptionTextBox";
      this.DescriptionTextBox.Size = new System.Drawing.Size(247, 63);
      this.DescriptionTextBox.TabIndex = 13;
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Location = new System.Drawing.Point(12, 41);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
      this.DescriptionLabel.TabIndex = 12;
      this.DescriptionLabel.Text = "Description";
      // 
      // TitleTextBox
      // 
      this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TitleTextBox.Location = new System.Drawing.Point(41, 12);
      this.TitleTextBox.Name = "TitleTextBox";
      this.TitleTextBox.Size = new System.Drawing.Size(34, 20);
      this.TitleTextBox.TabIndex = 10;
      // 
      // TitleLabel
      // 
      this.TitleLabel.AutoSize = true;
      this.TitleLabel.Location = new System.Drawing.Point(12, 15);
      this.TitleLabel.Name = "TitleLabel";
      this.TitleLabel.Size = new System.Drawing.Size(27, 13);
      this.TitleLabel.TabIndex = 9;
      this.TitleLabel.Text = "Title";
      // 
      // FormClearButton
      // 
      this.FormClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.FormClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.FormClearButton.Location = new System.Drawing.Point(184, 126);
      this.FormClearButton.Name = "FormClearButton";
      this.FormClearButton.Size = new System.Drawing.Size(75, 23);
      this.FormClearButton.TabIndex = 16;
      this.FormClearButton.Text = "Clear";
      this.FormClearButton.UseVisualStyleBackColor = true;
      this.FormClearButton.Click += new System.EventHandler(this.ClearClick);
      // 
      // AddIncidentControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.RequiredDescriptionLabel);
      this.Controls.Add(this.RequiredDescriptionAsteriskLabel);
      this.Controls.Add(this.CustomerIdRequiredLabel);
      this.Controls.Add(this.FormClearButton);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.CustomerIdTextBox);
      this.Controls.Add(this.CustomerIdLabel);
      this.Controls.Add(this.DescriptionTextBox);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.TitleTextBox);
      this.Controls.Add(this.TitleLabel);
      this.Name = "AddIncidentControl";
      this.Size = new System.Drawing.Size(271, 161);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label RequiredDescriptionLabel;
    private System.Windows.Forms.Label RequiredDescriptionAsteriskLabel;
    private System.Windows.Forms.Label CustomerIdRequiredLabel;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.TextBox CustomerIdTextBox;
    private System.Windows.Forms.Label CustomerIdLabel;
    private System.Windows.Forms.TextBox DescriptionTextBox;
    private System.Windows.Forms.Label DescriptionLabel;
    private System.Windows.Forms.TextBox TitleTextBox;
    private System.Windows.Forms.Label TitleLabel;
    private System.Windows.Forms.Button FormClearButton;
  }
}
