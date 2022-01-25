namespace TechSupport.View
{
  partial class AddForm
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
      this.TitleLabel = new System.Windows.Forms.Label();
      this.TitleTextBox = new System.Windows.Forms.TextBox();
      this.DescriptionTextBox = new System.Windows.Forms.TextBox();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
      this.CustomerIdLabel = new System.Windows.Forms.Label();
      this.AddButton = new System.Windows.Forms.Button();
      this.FormCancelButton = new System.Windows.Forms.Button();
      this.CustomerIdRequiredLabel = new System.Windows.Forms.Label();
      this.RequiredDescriptionAsteriskLabel = new System.Windows.Forms.Label();
      this.RequiredDescriptionLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // TitleLabel
      // 
      this.TitleLabel.AutoSize = true;
      this.TitleLabel.Location = new System.Drawing.Point(12, 15);
      this.TitleLabel.Name = "TitleLabel";
      this.TitleLabel.Size = new System.Drawing.Size(27, 13);
      this.TitleLabel.TabIndex = 0;
      this.TitleLabel.Text = "Title";
      // 
      // TitleTextBox
      // 
      this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TitleTextBox.Location = new System.Drawing.Point(41, 12);
      this.TitleTextBox.Name = "TitleTextBox";
      this.TitleTextBox.Size = new System.Drawing.Size(278, 20);
      this.TitleTextBox.TabIndex = 1;
      // 
      // DescriptionTextBox
      // 
      this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DescriptionTextBox.Location = new System.Drawing.Point(12, 57);
      this.DescriptionTextBox.Multiline = true;
      this.DescriptionTextBox.Name = "DescriptionTextBox";
      this.DescriptionTextBox.Size = new System.Drawing.Size(491, 140);
      this.DescriptionTextBox.TabIndex = 3;
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Location = new System.Drawing.Point(12, 41);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
      this.DescriptionLabel.TabIndex = 2;
      this.DescriptionLabel.Text = "Description";
      // 
      // CustomerIdTextBox
      // 
      this.CustomerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerIdTextBox.Location = new System.Drawing.Point(403, 12);
      this.CustomerIdTextBox.Name = "CustomerIdTextBox";
      this.CustomerIdTextBox.Size = new System.Drawing.Size(100, 20);
      this.CustomerIdTextBox.TabIndex = 2;
      this.CustomerIdTextBox.TextChanged += new System.EventHandler(this.customerIdTextBoxTextChanged);
      // 
      // CustomerIdLabel
      // 
      this.CustomerIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerIdLabel.AutoSize = true;
      this.CustomerIdLabel.Location = new System.Drawing.Point(325, 15);
      this.CustomerIdLabel.Name = "CustomerIdLabel";
      this.CustomerIdLabel.Size = new System.Drawing.Size(65, 13);
      this.CustomerIdLabel.TabIndex = 4;
      this.CustomerIdLabel.Text = "Customer ID";
      // 
      // AddButton
      // 
      this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.AddButton.Enabled = false;
      this.AddButton.Location = new System.Drawing.Point(347, 203);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(75, 23);
      this.AddButton.TabIndex = 4;
      this.AddButton.Text = "Add";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.AddClick);
      // 
      // FormCancelButton
      // 
      this.FormCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.FormCancelButton.Location = new System.Drawing.Point(428, 203);
      this.FormCancelButton.Name = "FormCancelButton";
      this.FormCancelButton.Size = new System.Drawing.Size(75, 23);
      this.FormCancelButton.TabIndex = 5;
      this.FormCancelButton.Text = "Cancel";
      this.FormCancelButton.UseVisualStyleBackColor = true;
      this.FormCancelButton.Click += new System.EventHandler(this.CancelClick);
      // 
      // CustomerIdRequiredLabel
      // 
      this.CustomerIdRequiredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerIdRequiredLabel.AutoSize = true;
      this.CustomerIdRequiredLabel.ForeColor = System.Drawing.Color.Red;
      this.CustomerIdRequiredLabel.Location = new System.Drawing.Point(386, 15);
      this.CustomerIdRequiredLabel.Name = "CustomerIdRequiredLabel";
      this.CustomerIdRequiredLabel.Size = new System.Drawing.Size(11, 13);
      this.CustomerIdRequiredLabel.TabIndex = 6;
      this.CustomerIdRequiredLabel.Text = "*";
      // 
      // RequiredDescriptionAsteriskLabel
      // 
      this.RequiredDescriptionAsteriskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.RequiredDescriptionAsteriskLabel.AutoSize = true;
      this.RequiredDescriptionAsteriskLabel.ForeColor = System.Drawing.Color.Red;
      this.RequiredDescriptionAsteriskLabel.Location = new System.Drawing.Point(12, 208);
      this.RequiredDescriptionAsteriskLabel.Name = "RequiredDescriptionAsteriskLabel";
      this.RequiredDescriptionAsteriskLabel.Size = new System.Drawing.Size(11, 13);
      this.RequiredDescriptionAsteriskLabel.TabIndex = 7;
      this.RequiredDescriptionAsteriskLabel.Text = "*";
      // 
      // RequiredDescriptionLabel
      // 
      this.RequiredDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.RequiredDescriptionLabel.AutoSize = true;
      this.RequiredDescriptionLabel.Location = new System.Drawing.Point(24, 208);
      this.RequiredDescriptionLabel.Name = "RequiredDescriptionLabel";
      this.RequiredDescriptionLabel.Size = new System.Drawing.Size(56, 13);
      this.RequiredDescriptionLabel.TabIndex = 8;
      this.RequiredDescriptionLabel.Text = "- Required";
      // 
      // AddForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.FormCancelButton;
      this.ClientSize = new System.Drawing.Size(515, 238);
      this.Controls.Add(this.RequiredDescriptionLabel);
      this.Controls.Add(this.RequiredDescriptionAsteriskLabel);
      this.Controls.Add(this.CustomerIdRequiredLabel);
      this.Controls.Add(this.FormCancelButton);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.CustomerIdTextBox);
      this.Controls.Add(this.CustomerIdLabel);
      this.Controls.Add(this.DescriptionTextBox);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.TitleTextBox);
      this.Controls.Add(this.TitleLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AddForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Add Incident";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label TitleLabel;
    private System.Windows.Forms.TextBox TitleTextBox;
    private System.Windows.Forms.TextBox DescriptionTextBox;
    private System.Windows.Forms.Label DescriptionLabel;
    private System.Windows.Forms.TextBox CustomerIdTextBox;
    private System.Windows.Forms.Label CustomerIdLabel;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button FormCancelButton;
    private System.Windows.Forms.Label CustomerIdRequiredLabel;
    private System.Windows.Forms.Label RequiredDescriptionAsteriskLabel;
    private System.Windows.Forms.Label RequiredDescriptionLabel;
  }
}