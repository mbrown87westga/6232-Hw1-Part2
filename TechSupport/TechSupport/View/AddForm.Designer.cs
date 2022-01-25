﻿namespace TechSupport.View
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
      this.titleLabel = new System.Windows.Forms.Label();
      this.titleTextBox = new System.Windows.Forms.TextBox();
      this.descriptionTextBox = new System.Windows.Forms.TextBox();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.customerIdTextBox = new System.Windows.Forms.TextBox();
      this.customerIdLabel = new System.Windows.Forms.Label();
      this.addButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.CustomerIdRequiredLabel = new System.Windows.Forms.Label();
      this.RequiredDescriptionAsteriskLabel = new System.Windows.Forms.Label();
      this.RequiredDescriptionLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // titleLabel
      // 
      this.titleLabel.AutoSize = true;
      this.titleLabel.Location = new System.Drawing.Point(12, 15);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(27, 13);
      this.titleLabel.TabIndex = 0;
      this.titleLabel.Text = "Title";
      // 
      // titleTextBox
      // 
      this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.titleTextBox.Location = new System.Drawing.Point(41, 12);
      this.titleTextBox.Name = "titleTextBox";
      this.titleTextBox.Size = new System.Drawing.Size(278, 20);
      this.titleTextBox.TabIndex = 1;
      // 
      // descriptionTextBox
      // 
      this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.descriptionTextBox.Location = new System.Drawing.Point(12, 57);
      this.descriptionTextBox.Multiline = true;
      this.descriptionTextBox.Name = "descriptionTextBox";
      this.descriptionTextBox.Size = new System.Drawing.Size(491, 140);
      this.descriptionTextBox.TabIndex = 3;
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.Location = new System.Drawing.Point(12, 41);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
      this.descriptionLabel.TabIndex = 2;
      this.descriptionLabel.Text = "Description";
      // 
      // customerIdTextBox
      // 
      this.customerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.customerIdTextBox.Location = new System.Drawing.Point(403, 12);
      this.customerIdTextBox.Name = "customerIdTextBox";
      this.customerIdTextBox.Size = new System.Drawing.Size(100, 20);
      this.customerIdTextBox.TabIndex = 2;
      this.customerIdTextBox.TextChanged += new System.EventHandler(this.customerIdTextBoxTextChanged);
      // 
      // customerIdLabel
      // 
      this.customerIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.customerIdLabel.AutoSize = true;
      this.customerIdLabel.Location = new System.Drawing.Point(325, 15);
      this.customerIdLabel.Name = "customerIdLabel";
      this.customerIdLabel.Size = new System.Drawing.Size(65, 13);
      this.customerIdLabel.TabIndex = 4;
      this.customerIdLabel.Text = "Customer ID";
      // 
      // addButton
      // 
      this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.addButton.Enabled = false;
      this.addButton.Location = new System.Drawing.Point(347, 203);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(75, 23);
      this.addButton.TabIndex = 4;
      this.addButton.Text = "Add";
      this.addButton.UseVisualStyleBackColor = true;
      this.addButton.Click += new System.EventHandler(this.AddClick);
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(428, 203);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 5;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.CancelClick);
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
      this.AcceptButton = this.addButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(515, 238);
      this.Controls.Add(this.RequiredDescriptionLabel);
      this.Controls.Add(this.RequiredDescriptionAsteriskLabel);
      this.Controls.Add(this.CustomerIdRequiredLabel);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.addButton);
      this.Controls.Add(this.customerIdTextBox);
      this.Controls.Add(this.customerIdLabel);
      this.Controls.Add(this.descriptionTextBox);
      this.Controls.Add(this.descriptionLabel);
      this.Controls.Add(this.titleTextBox);
      this.Controls.Add(this.titleLabel);
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

    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.TextBox descriptionTextBox;
    private System.Windows.Forms.Label descriptionLabel;
    private System.Windows.Forms.TextBox customerIdTextBox;
    private System.Windows.Forms.Label customerIdLabel;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Label CustomerIdRequiredLabel;
    private System.Windows.Forms.Label RequiredDescriptionAsteriskLabel;
    private System.Windows.Forms.Label RequiredDescriptionLabel;
  }
}