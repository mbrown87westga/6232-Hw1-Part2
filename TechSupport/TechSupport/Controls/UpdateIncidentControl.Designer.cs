namespace TechSupport.View
{
  partial class UpdateIncidentControl
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
      this.CloseButton = new System.Windows.Forms.Button();
      this.CustomerIdLabel = new System.Windows.Forms.Label();
      this.DescriptionTextBox = new System.Windows.Forms.TextBox();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.TitleTextBox = new System.Windows.Forms.TextBox();
      this.TitleLabel = new System.Windows.Forms.Label();
      this.FormClearButton = new System.Windows.Forms.Button();
      this.TechnicianComboBox = new System.Windows.Forms.ComboBox();
      this.ProductLabel = new System.Windows.Forms.Label();
      this.GetButton = new System.Windows.Forms.Button();
      this.IncidentTextBox = new System.Windows.Forms.TextBox();
      this.IncidentLabel = new System.Windows.Forms.Label();
      this.CustomerTextBox = new System.Windows.Forms.TextBox();
      this.ProductTextBox = new System.Windows.Forms.TextBox();
      this.TechnicianLabel = new System.Windows.Forms.Label();
      this.DateOpenedTextBox = new System.Windows.Forms.TextBox();
      this.DateOpenedLabel = new System.Windows.Forms.Label();
      this.TestToAddTextBox = new System.Windows.Forms.TextBox();
      this.TestToAddLabel = new System.Windows.Forms.Label();
      this.UpdateButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // CloseButton
      // 
      this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.CloseButton.Enabled = false;
      this.CloseButton.Location = new System.Drawing.Point(212, 330);
      this.CloseButton.Name = "CloseButton";
      this.CloseButton.Size = new System.Drawing.Size(101, 23);
      this.CloseButton.TabIndex = 14;
      this.CloseButton.Text = "Close";
      this.CloseButton.UseVisualStyleBackColor = true;
      this.CloseButton.Click += new System.EventHandler(this.CloseClick);
      // 
      // CustomerIdLabel
      // 
      this.CustomerIdLabel.AutoSize = true;
      this.CustomerIdLabel.Location = new System.Drawing.Point(4, 35);
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
      this.DescriptionTextBox.Location = new System.Drawing.Point(84, 163);
      this.DescriptionTextBox.Multiline = true;
      this.DescriptionTextBox.Name = "DescriptionTextBox";
      this.DescriptionTextBox.Size = new System.Drawing.Size(310, 72);
      this.DescriptionTextBox.TabIndex = 13;
      this.DescriptionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Location = new System.Drawing.Point(4, 166);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
      this.DescriptionLabel.TabIndex = 12;
      this.DescriptionLabel.Text = "Description:";
      // 
      // TitleTextBox
      // 
      this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TitleTextBox.Location = new System.Drawing.Point(84, 111);
      this.TitleTextBox.Name = "TitleTextBox";
      this.TitleTextBox.Size = new System.Drawing.Size(310, 20);
      this.TitleTextBox.TabIndex = 10;
      this.TitleTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // TitleLabel
      // 
      this.TitleLabel.AutoSize = true;
      this.TitleLabel.Location = new System.Drawing.Point(4, 114);
      this.TitleLabel.Name = "TitleLabel";
      this.TitleLabel.Size = new System.Drawing.Size(30, 13);
      this.TitleLabel.TabIndex = 9;
      this.TitleLabel.Text = "Title:";
      // 
      // FormClearButton
      // 
      this.FormClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.FormClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.FormClearButton.Location = new System.Drawing.Point(319, 330);
      this.FormClearButton.Name = "FormClearButton";
      this.FormClearButton.Size = new System.Drawing.Size(75, 23);
      this.FormClearButton.TabIndex = 16;
      this.FormClearButton.Text = "Clear";
      this.FormClearButton.UseVisualStyleBackColor = true;
      this.FormClearButton.Click += new System.EventHandler(this.ClearClick);
      // 
      // TechnicianComboBox
      // 
      this.TechnicianComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TechnicianComboBox.Cursor = System.Windows.Forms.Cursors.Default;
      this.TechnicianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.TechnicianComboBox.FormattingEnabled = true;
      this.TechnicianComboBox.Location = new System.Drawing.Point(84, 84);
      this.TechnicianComboBox.Name = "TechnicianComboBox";
      this.TechnicianComboBox.Size = new System.Drawing.Size(310, 21);
      this.TechnicianComboBox.TabIndex = 20;
      // 
      // ProductLabel
      // 
      this.ProductLabel.AutoSize = true;
      this.ProductLabel.Location = new System.Drawing.Point(4, 61);
      this.ProductLabel.Name = "ProductLabel";
      this.ProductLabel.Size = new System.Drawing.Size(47, 13);
      this.ProductLabel.TabIndex = 21;
      this.ProductLabel.Text = "Product:";
      // 
      // GetButton
      // 
      this.GetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.GetButton.Location = new System.Drawing.Point(319, 4);
      this.GetButton.Name = "GetButton";
      this.GetButton.Size = new System.Drawing.Size(75, 23);
      this.GetButton.TabIndex = 22;
      this.GetButton.Text = "Get";
      this.GetButton.UseVisualStyleBackColor = true;
      // 
      // IncidentTextBox
      // 
      this.IncidentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.IncidentTextBox.Location = new System.Drawing.Point(84, 6);
      this.IncidentTextBox.Name = "IncidentTextBox";
      this.IncidentTextBox.Size = new System.Drawing.Size(229, 20);
      this.IncidentTextBox.TabIndex = 24;
      // 
      // IncidentLabel
      // 
      this.IncidentLabel.AutoSize = true;
      this.IncidentLabel.Location = new System.Drawing.Point(4, 9);
      this.IncidentLabel.Name = "IncidentLabel";
      this.IncidentLabel.Size = new System.Drawing.Size(62, 13);
      this.IncidentLabel.TabIndex = 23;
      this.IncidentLabel.Text = "Incident ID:";
      // 
      // CustomerTextBox
      // 
      this.CustomerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerTextBox.Location = new System.Drawing.Point(84, 32);
      this.CustomerTextBox.Name = "CustomerTextBox";
      this.CustomerTextBox.Size = new System.Drawing.Size(310, 20);
      this.CustomerTextBox.TabIndex = 25;
      // 
      // ProductTextBox
      // 
      this.ProductTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ProductTextBox.Location = new System.Drawing.Point(84, 58);
      this.ProductTextBox.Name = "ProductTextBox";
      this.ProductTextBox.Size = new System.Drawing.Size(310, 20);
      this.ProductTextBox.TabIndex = 26;
      // 
      // TechnicianLabel
      // 
      this.TechnicianLabel.AutoSize = true;
      this.TechnicianLabel.Location = new System.Drawing.Point(4, 87);
      this.TechnicianLabel.Name = "TechnicianLabel";
      this.TechnicianLabel.Size = new System.Drawing.Size(63, 13);
      this.TechnicianLabel.TabIndex = 27;
      this.TechnicianLabel.Text = "Technician:";
      // 
      // DateOpenedTextBox
      // 
      this.DateOpenedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DateOpenedTextBox.Location = new System.Drawing.Point(84, 137);
      this.DateOpenedTextBox.Name = "DateOpenedTextBox";
      this.DateOpenedTextBox.Size = new System.Drawing.Size(310, 20);
      this.DateOpenedTextBox.TabIndex = 29;
      // 
      // DateOpenedLabel
      // 
      this.DateOpenedLabel.AutoSize = true;
      this.DateOpenedLabel.Location = new System.Drawing.Point(4, 140);
      this.DateOpenedLabel.Name = "DateOpenedLabel";
      this.DateOpenedLabel.Size = new System.Drawing.Size(74, 13);
      this.DateOpenedLabel.TabIndex = 28;
      this.DateOpenedLabel.Text = "Date Opened:";
      // 
      // TestToAddTextBox
      // 
      this.TestToAddTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TestToAddTextBox.Location = new System.Drawing.Point(84, 241);
      this.TestToAddTextBox.Multiline = true;
      this.TestToAddTextBox.Name = "TestToAddTextBox";
      this.TestToAddTextBox.Size = new System.Drawing.Size(310, 83);
      this.TestToAddTextBox.TabIndex = 31;
      // 
      // TestToAddLabel
      // 
      this.TestToAddLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.TestToAddLabel.AutoSize = true;
      this.TestToAddLabel.Location = new System.Drawing.Point(4, 244);
      this.TestToAddLabel.Name = "TestToAddLabel";
      this.TestToAddLabel.Size = new System.Drawing.Size(69, 13);
      this.TestToAddLabel.TabIndex = 30;
      this.TestToAddLabel.Text = "Text To Add:";
      // 
      // UpdateButton
      // 
      this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.UpdateButton.Enabled = false;
      this.UpdateButton.Location = new System.Drawing.Point(105, 330);
      this.UpdateButton.Name = "UpdateButton";
      this.UpdateButton.Size = new System.Drawing.Size(101, 23);
      this.UpdateButton.TabIndex = 32;
      this.UpdateButton.Text = "Update";
      this.UpdateButton.UseVisualStyleBackColor = true;
      // 
      // UpdateIncidentControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.UpdateButton);
      this.Controls.Add(this.TestToAddTextBox);
      this.Controls.Add(this.TestToAddLabel);
      this.Controls.Add(this.DateOpenedTextBox);
      this.Controls.Add(this.DateOpenedLabel);
      this.Controls.Add(this.TechnicianLabel);
      this.Controls.Add(this.ProductTextBox);
      this.Controls.Add(this.CustomerTextBox);
      this.Controls.Add(this.IncidentTextBox);
      this.Controls.Add(this.IncidentLabel);
      this.Controls.Add(this.GetButton);
      this.Controls.Add(this.ProductLabel);
      this.Controls.Add(this.TechnicianComboBox);
      this.Controls.Add(this.FormClearButton);
      this.Controls.Add(this.CloseButton);
      this.Controls.Add(this.CustomerIdLabel);
      this.Controls.Add(this.DescriptionTextBox);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.TitleTextBox);
      this.Controls.Add(this.TitleLabel);
      this.Name = "UpdateIncidentControl";
      this.Size = new System.Drawing.Size(406, 356);
      this.Load += new System.EventHandler(this.UpdateIncidentControl_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button CloseButton;
    private System.Windows.Forms.Label CustomerIdLabel;
    private System.Windows.Forms.TextBox DescriptionTextBox;
    private System.Windows.Forms.Label DescriptionLabel;
    private System.Windows.Forms.TextBox TitleTextBox;
    private System.Windows.Forms.Label TitleLabel;
    private System.Windows.Forms.Button FormClearButton;
    private System.Windows.Forms.ComboBox TechnicianComboBox;
    private System.Windows.Forms.Label ProductLabel;
    private System.Windows.Forms.Button GetButton;
    private System.Windows.Forms.TextBox IncidentTextBox;
    private System.Windows.Forms.Label IncidentLabel;
    private System.Windows.Forms.TextBox CustomerTextBox;
    private System.Windows.Forms.TextBox ProductTextBox;
    private System.Windows.Forms.Label TechnicianLabel;
    private System.Windows.Forms.TextBox DateOpenedTextBox;
    private System.Windows.Forms.Label DateOpenedLabel;
    private System.Windows.Forms.TextBox TestToAddTextBox;
    private System.Windows.Forms.Label TestToAddLabel;
    private System.Windows.Forms.Button UpdateButton;
  }
}
