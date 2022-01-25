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
      this.customerIdTextBox = new System.Windows.Forms.TextBox();
      this.customerIdLabel = new System.Windows.Forms.Label();
      this.searchButton = new System.Windows.Forms.Button();
      this.resultsDataGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // customerIdTextBox
      // 
      this.customerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.customerIdTextBox.Location = new System.Drawing.Point(83, 12);
      this.customerIdTextBox.Name = "customerIdTextBox";
      this.customerIdTextBox.Size = new System.Drawing.Size(319, 20);
      this.customerIdTextBox.TabIndex = 1;
      // 
      // customerIdLabel
      // 
      this.customerIdLabel.AutoSize = true;
      this.customerIdLabel.Location = new System.Drawing.Point(12, 15);
      this.customerIdLabel.Name = "customerIdLabel";
      this.customerIdLabel.Size = new System.Drawing.Size(65, 13);
      this.customerIdLabel.TabIndex = 4;
      this.customerIdLabel.Text = "Customer ID";
      // 
      // searchButton
      // 
      this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.searchButton.Location = new System.Drawing.Point(408, 10);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(75, 23);
      this.searchButton.TabIndex = 2;
      this.searchButton.Text = "Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.SearchClick);
      // 
      // resultsDataGridView
      // 
      this.resultsDataGridView.AllowUserToAddRows = false;
      this.resultsDataGridView.AllowUserToDeleteRows = false;
      this.resultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.resultsDataGridView.Location = new System.Drawing.Point(12, 38);
      this.resultsDataGridView.Name = "resultsDataGridView";
      this.resultsDataGridView.ReadOnly = true;
      this.resultsDataGridView.Size = new System.Drawing.Size(471, 188);
      this.resultsDataGridView.TabIndex = 3;
      // 
      // SearchForm
      // 
      this.AcceptButton = this.searchButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(495, 238);
      this.Controls.Add(this.resultsDataGridView);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(this.customerIdTextBox);
      this.Controls.Add(this.customerIdLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SearchForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Add Incident";
      ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox customerIdTextBox;
    private System.Windows.Forms.Label customerIdLabel;
    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.DataGridView resultsDataGridView;
  }
}