﻿namespace TechSupport.Controls
{
  partial class SearchIncidentsControl
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
      this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
      this.SearchButton = new System.Windows.Forms.Button();
      this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
      this.CustomerIdLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // ResultsDataGridView
      // 
      this.ResultsDataGridView.AllowUserToAddRows = false;
      this.ResultsDataGridView.AllowUserToDeleteRows = false;
      this.ResultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ResultsDataGridView.Location = new System.Drawing.Point(12, 39);
      this.ResultsDataGridView.Name = "ResultsDataGridView";
      this.ResultsDataGridView.ReadOnly = true;
      this.ResultsDataGridView.Size = new System.Drawing.Size(253, 148);
      this.ResultsDataGridView.TabIndex = 7;
      // 
      // SearchButton
      // 
      this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.SearchButton.Location = new System.Drawing.Point(190, 11);
      this.SearchButton.Name = "SearchButton";
      this.SearchButton.Size = new System.Drawing.Size(75, 23);
      this.SearchButton.TabIndex = 6;
      this.SearchButton.Text = "Search";
      this.SearchButton.UseVisualStyleBackColor = true;
      this.SearchButton.Click += new System.EventHandler(this.SearchClick);
      // 
      // CustomerIdTextBox
      // 
      this.CustomerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerIdTextBox.Location = new System.Drawing.Point(83, 13);
      this.CustomerIdTextBox.Name = "CustomerIdTextBox";
      this.CustomerIdTextBox.Size = new System.Drawing.Size(101, 20);
      this.CustomerIdTextBox.TabIndex = 5;
      // 
      // CustomerIdLabel
      // 
      this.CustomerIdLabel.AutoSize = true;
      this.CustomerIdLabel.Location = new System.Drawing.Point(12, 16);
      this.CustomerIdLabel.Name = "CustomerIdLabel";
      this.CustomerIdLabel.Size = new System.Drawing.Size(65, 13);
      this.CustomerIdLabel.TabIndex = 8;
      this.CustomerIdLabel.Text = "Customer ID";
      // 
      // SearchIncidentsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ResultsDataGridView);
      this.Controls.Add(this.SearchButton);
      this.Controls.Add(this.CustomerIdTextBox);
      this.Controls.Add(this.CustomerIdLabel);
      this.Name = "SearchIncidentsControl";
      this.Size = new System.Drawing.Size(277, 198);
      ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView ResultsDataGridView;
    private System.Windows.Forms.Button SearchButton;
    private System.Windows.Forms.TextBox CustomerIdTextBox;
    private System.Windows.Forms.Label CustomerIdLabel;
  }
}
