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
      this.AddButton = new System.Windows.Forms.Button();
      this.CustomerIdLabel = new System.Windows.Forms.Label();
      this.DescriptionTextBox = new System.Windows.Forms.TextBox();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.TitleTextBox = new System.Windows.Forms.TextBox();
      this.TitleLabel = new System.Windows.Forms.Label();
      this.FormClearButton = new System.Windows.Forms.Button();
      this.CustomerComboBox = new System.Windows.Forms.ComboBox();
      this.ProductLabel = new System.Windows.Forms.Label();
      this.ProductComboBox = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // AddButton
      // 
      this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.AddButton.Enabled = false;
      this.AddButton.Location = new System.Drawing.Point(101, 158);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(101, 23);
      this.AddButton.TabIndex = 14;
      this.AddButton.Text = "Create Incident";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.AddClick);
      // 
      // CustomerIdLabel
      // 
      this.CustomerIdLabel.AutoSize = true;
      this.CustomerIdLabel.Location = new System.Drawing.Point(12, 9);
      this.CustomerIdLabel.Name = "CustomerIdLabel";
      this.CustomerIdLabel.Size = new System.Drawing.Size(54, 13);
      this.CustomerIdLabel.TabIndex = 15;
      this.CustomerIdLabel.Text = "Customer:";
      // 
      // DescriptionTextBox
      // 
      this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DescriptionTextBox.Location = new System.Drawing.Point(72, 86);
      this.DescriptionTextBox.Multiline = true;
      this.DescriptionTextBox.Name = "DescriptionTextBox";
      this.DescriptionTextBox.Size = new System.Drawing.Size(211, 66);
      this.DescriptionTextBox.TabIndex = 13;
      this.DescriptionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Location = new System.Drawing.Point(3, 89);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
      this.DescriptionLabel.TabIndex = 12;
      this.DescriptionLabel.Text = "Description:";
      // 
      // TitleTextBox
      // 
      this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TitleTextBox.Location = new System.Drawing.Point(72, 60);
      this.TitleTextBox.Name = "TitleTextBox";
      this.TitleTextBox.Size = new System.Drawing.Size(211, 20);
      this.TitleTextBox.TabIndex = 10;
      this.TitleTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // TitleLabel
      // 
      this.TitleLabel.AutoSize = true;
      this.TitleLabel.Location = new System.Drawing.Point(36, 63);
      this.TitleLabel.Name = "TitleLabel";
      this.TitleLabel.Size = new System.Drawing.Size(30, 13);
      this.TitleLabel.TabIndex = 9;
      this.TitleLabel.Text = "Title:";
      // 
      // FormClearButton
      // 
      this.FormClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.FormClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.FormClearButton.Location = new System.Drawing.Point(208, 158);
      this.FormClearButton.Name = "FormClearButton";
      this.FormClearButton.Size = new System.Drawing.Size(75, 23);
      this.FormClearButton.TabIndex = 16;
      this.FormClearButton.Text = "Clear";
      this.FormClearButton.UseVisualStyleBackColor = true;
      this.FormClearButton.Click += new System.EventHandler(this.ClearClick);
      // 
      // CustomerComboBox
      // 
      this.CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerComboBox.Cursor = System.Windows.Forms.Cursors.Default;
      this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CustomerComboBox.FormattingEnabled = true;
      this.CustomerComboBox.Location = new System.Drawing.Point(72, 6);
      this.CustomerComboBox.Name = "CustomerComboBox";
      this.CustomerComboBox.Size = new System.Drawing.Size(211, 21);
      this.CustomerComboBox.TabIndex = 20;
      // 
      // ProductLabel
      // 
      this.ProductLabel.AutoSize = true;
      this.ProductLabel.Location = new System.Drawing.Point(19, 36);
      this.ProductLabel.Name = "ProductLabel";
      this.ProductLabel.Size = new System.Drawing.Size(47, 13);
      this.ProductLabel.TabIndex = 21;
      this.ProductLabel.Text = "Product:";
      // 
      // ProductComboBox
      // 
      this.ProductComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ProductComboBox.FormattingEnabled = true;
      this.ProductComboBox.Location = new System.Drawing.Point(72, 33);
      this.ProductComboBox.Name = "ProductComboBox";
      this.ProductComboBox.Size = new System.Drawing.Size(211, 21);
      this.ProductComboBox.TabIndex = 22;
      // 
      // AddIncidentControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ProductComboBox);
      this.Controls.Add(this.ProductLabel);
      this.Controls.Add(this.CustomerComboBox);
      this.Controls.Add(this.FormClearButton);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.CustomerIdLabel);
      this.Controls.Add(this.DescriptionTextBox);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.TitleTextBox);
      this.Controls.Add(this.TitleLabel);
      this.Name = "AddIncidentControl";
      this.Size = new System.Drawing.Size(295, 193);
      this.Load += new System.EventHandler(this.AddIncidentControl_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Label CustomerIdLabel;
    private System.Windows.Forms.TextBox DescriptionTextBox;
    private System.Windows.Forms.Label DescriptionLabel;
    private System.Windows.Forms.TextBox TitleTextBox;
    private System.Windows.Forms.Label TitleLabel;
    private System.Windows.Forms.Button FormClearButton;
    private System.Windows.Forms.ComboBox CustomerComboBox;
    private System.Windows.Forms.Label ProductLabel;
    private System.Windows.Forms.ComboBox ProductComboBox;
  }
}
