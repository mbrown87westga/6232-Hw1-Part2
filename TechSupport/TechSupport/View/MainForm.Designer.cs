namespace TechSupport.View
{
  partial class MainForm
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
      this.LoggedInUserLabel = new System.Windows.Forms.Label();
      this.LogoutLink = new System.Windows.Forms.LinkLabel();
      this.AddIncidentButton = new System.Windows.Forms.Button();
      this.SearchIncidentButton = new System.Windows.Forms.Button();
      this.IncidentsDataGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.IncidentsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // LoggedInUserLabel
      // 
      this.LoggedInUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.LoggedInUserLabel.Location = new System.Drawing.Point(224, 9);
      this.LoggedInUserLabel.Name = "LoggedInUserLabel";
      this.LoggedInUserLabel.Size = new System.Drawing.Size(132, 13);
      this.LoggedInUserLabel.TabIndex = 0;
      this.LoggedInUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Logout
      // 
      this.LogoutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.LogoutLink.AutoSize = true;
      this.LogoutLink.Location = new System.Drawing.Point(316, 22);
      this.LogoutLink.Name = "LogoutLink";
      this.LogoutLink.Size = new System.Drawing.Size(40, 13);
      this.LogoutLink.TabIndex = 3;
      this.LogoutLink.TabStop = true;
      this.LogoutLink.Text = "Logout";
      this.LogoutLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkClicked);
      // 
      // AddIncidentButton
      // 
      this.AddIncidentButton.Location = new System.Drawing.Point(13, 13);
      this.AddIncidentButton.Name = "AddIncidentButton";
      this.AddIncidentButton.Size = new System.Drawing.Size(75, 23);
      this.AddIncidentButton.TabIndex = 1;
      this.AddIncidentButton.Text = "Add Incident";
      this.AddIncidentButton.UseVisualStyleBackColor = true;
      this.AddIncidentButton.Click += new System.EventHandler(this.AddIncidentClick);
      // 
      // SearchIncidentButton
      // 
      this.SearchIncidentButton.Location = new System.Drawing.Point(94, 13);
      this.SearchIncidentButton.Name = "SearchIncidentButton";
      this.SearchIncidentButton.Size = new System.Drawing.Size(91, 23);
      this.SearchIncidentButton.TabIndex = 2;
      this.SearchIncidentButton.Text = "Search Incident";
      this.SearchIncidentButton.UseVisualStyleBackColor = true;
      this.SearchIncidentButton.Click += new System.EventHandler(this.SearchIncidentClick);
      // 
      // IncidentsDataGridView
      // 
      this.IncidentsDataGridView.AllowUserToAddRows = false;
      this.IncidentsDataGridView.AllowUserToDeleteRows = false;
      this.IncidentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.IncidentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.IncidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.IncidentsDataGridView.Location = new System.Drawing.Point(12, 42);
      this.IncidentsDataGridView.Name = "IncidentsDataGridView";
      this.IncidentsDataGridView.ReadOnly = true;
      this.IncidentsDataGridView.Size = new System.Drawing.Size(344, 218);
      this.IncidentsDataGridView.TabIndex = 4;
      // 
      // MainForm
      // 
      this.AcceptButton = this.AddIncidentButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 272);
      this.Controls.Add(this.IncidentsDataGridView);
      this.Controls.Add(this.SearchIncidentButton);
      this.Controls.Add(this.AddIncidentButton);
      this.Controls.Add(this.LogoutLink);
      this.Controls.Add(this.LoggedInUserLabel);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Incident Main Form";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
      this.Load += new System.EventHandler(this.MainFormLoad);
      ((System.ComponentModel.ISupportInitialize)(this.IncidentsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LoggedInUserLabel;
    private System.Windows.Forms.LinkLabel LogoutLink;
    private System.Windows.Forms.Button AddIncidentButton;
    private System.Windows.Forms.Button SearchIncidentButton;
    private System.Windows.Forms.DataGridView IncidentsDataGridView;
  }
}