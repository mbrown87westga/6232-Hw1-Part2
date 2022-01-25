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
      this.loggedInUserLabel = new System.Windows.Forms.Label();
      this.logoutLink = new System.Windows.Forms.LinkLabel();
      this.addIncidentButton = new System.Windows.Forms.Button();
      this.searchIncidentButton = new System.Windows.Forms.Button();
      this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // loggedInUserLabel
      // 
      this.loggedInUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.loggedInUserLabel.Location = new System.Drawing.Point(224, 9);
      this.loggedInUserLabel.Name = "loggedInUserLabel";
      this.loggedInUserLabel.Size = new System.Drawing.Size(132, 13);
      this.loggedInUserLabel.TabIndex = 0;
      this.loggedInUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Logout
      // 
      this.logoutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.logoutLink.AutoSize = true;
      this.logoutLink.Location = new System.Drawing.Point(316, 22);
      this.logoutLink.Name = "logoutLink";
      this.logoutLink.Size = new System.Drawing.Size(40, 13);
      this.logoutLink.TabIndex = 3;
      this.logoutLink.TabStop = true;
      this.logoutLink.Text = "Logout";
      this.logoutLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkClicked);
      // 
      // addIncidentButton
      // 
      this.addIncidentButton.Location = new System.Drawing.Point(13, 13);
      this.addIncidentButton.Name = "addIncidentButton";
      this.addIncidentButton.Size = new System.Drawing.Size(75, 23);
      this.addIncidentButton.TabIndex = 1;
      this.addIncidentButton.Text = "Add Incident";
      this.addIncidentButton.UseVisualStyleBackColor = true;
      this.addIncidentButton.Click += new System.EventHandler(this.AddIncidentClick);
      // 
      // searchIncidentButton
      // 
      this.searchIncidentButton.Location = new System.Drawing.Point(94, 13);
      this.searchIncidentButton.Name = "searchIncidentButton";
      this.searchIncidentButton.Size = new System.Drawing.Size(91, 23);
      this.searchIncidentButton.TabIndex = 2;
      this.searchIncidentButton.Text = "Search Incident";
      this.searchIncidentButton.UseVisualStyleBackColor = true;
      this.searchIncidentButton.Click += new System.EventHandler(this.SearchIncidentClick);
      // 
      // incidentsDataGridView
      // 
      this.incidentsDataGridView.AllowUserToAddRows = false;
      this.incidentsDataGridView.AllowUserToDeleteRows = false;
      this.incidentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.incidentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.incidentsDataGridView.Location = new System.Drawing.Point(12, 42);
      this.incidentsDataGridView.Name = "incidentsDataGridView";
      this.incidentsDataGridView.ReadOnly = true;
      this.incidentsDataGridView.Size = new System.Drawing.Size(344, 218);
      this.incidentsDataGridView.TabIndex = 4;
      // 
      // MainForm
      // 
      this.AcceptButton = this.addIncidentButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 272);
      this.Controls.Add(this.incidentsDataGridView);
      this.Controls.Add(this.searchIncidentButton);
      this.Controls.Add(this.addIncidentButton);
      this.Controls.Add(this.logoutLink);
      this.Controls.Add(this.loggedInUserLabel);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Incident Main Form";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
      this.Load += new System.EventHandler(this.MainFormLoad);
      ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label loggedInUserLabel;
    private System.Windows.Forms.LinkLabel logoutLink;
    private System.Windows.Forms.Button addIncidentButton;
    private System.Windows.Forms.Button searchIncidentButton;
    private System.Windows.Forms.DataGridView incidentsDataGridView;
  }
}