namespace TechSupport.View
{
  partial class SearchForm
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
      this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
      this.CustomerIdLabel = new System.Windows.Forms.Label();
      this.SearchButton = new System.Windows.Forms.Button();
      this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // CustomerIdTextBox
      // 
      this.CustomerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.CustomerIdTextBox.Location = new System.Drawing.Point(83, 12);
      this.CustomerIdTextBox.Name = "CustomerIdTextBox";
      this.CustomerIdTextBox.Size = new System.Drawing.Size(319, 20);
      this.CustomerIdTextBox.TabIndex = 1;
      // 
      // CustomerIdLabel
      // 
      this.CustomerIdLabel.AutoSize = true;
      this.CustomerIdLabel.Location = new System.Drawing.Point(12, 15);
      this.CustomerIdLabel.Name = "CustomerIdLabel";
      this.CustomerIdLabel.Size = new System.Drawing.Size(65, 13);
      this.CustomerIdLabel.TabIndex = 4;
      this.CustomerIdLabel.Text = "Customer ID";
      // 
      // SearchButton
      // 
      this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.SearchButton.Location = new System.Drawing.Point(408, 10);
      this.SearchButton.Name = "SearchButton";
      this.SearchButton.Size = new System.Drawing.Size(75, 23);
      this.SearchButton.TabIndex = 2;
      this.SearchButton.Text = "Search";
      this.SearchButton.UseVisualStyleBackColor = true;
      this.SearchButton.Click += new System.EventHandler(this.SearchClick);
      // 
      // ResultsDataGridView
      // 
      this.ResultsDataGridView.AllowUserToAddRows = false;
      this.ResultsDataGridView.AllowUserToDeleteRows = false;
      this.ResultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ResultsDataGridView.Location = new System.Drawing.Point(12, 38);
      this.ResultsDataGridView.Name = "ResultsDataGridView";
      this.ResultsDataGridView.ReadOnly = true;
      this.ResultsDataGridView.Size = new System.Drawing.Size(471, 188);
      this.ResultsDataGridView.TabIndex = 3;
      // 
      // SearchForm
      // 
      this.AcceptButton = this.SearchButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(495, 238);
      this.Controls.Add(this.ResultsDataGridView);
      this.Controls.Add(this.SearchButton);
      this.Controls.Add(this.CustomerIdTextBox);
      this.Controls.Add(this.CustomerIdLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SearchForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Add Incident";
      ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox CustomerIdTextBox;
    private System.Windows.Forms.Label CustomerIdLabel;
    private System.Windows.Forms.Button SearchButton;
    private System.Windows.Forms.DataGridView ResultsDataGridView;
  }
}