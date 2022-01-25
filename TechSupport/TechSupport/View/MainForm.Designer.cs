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
      this.Logout = new System.Windows.Forms.LinkLabel();
      this.addIncidentButton = new System.Windows.Forms.Button();
      this.searchIncidentButton = new System.Windows.Forms.Button();
      this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
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
      this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.Logout.AutoSize = true;
      this.Logout.Location = new System.Drawing.Point(316, 22);
      this.Logout.Name = "Logout";
      this.Logout.Size = new System.Drawing.Size(40, 13);
      this.Logout.TabIndex = 1;
      this.Logout.TabStop = true;
      this.Logout.Text = "Logout";
      this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkClicked);
      // 
      // addIncidentButton
      // 
      this.addIncidentButton.Location = new System.Drawing.Point(13, 13);
      this.addIncidentButton.Name = "addIncidentButton";
      this.addIncidentButton.Size = new System.Drawing.Size(75, 23);
      this.addIncidentButton.TabIndex = 2;
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
      this.incidentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.incidentsDataGridView.Location = new System.Drawing.Point(12, 42);
      this.incidentsDataGridView.Name = "incidentsDataGridView";
      this.incidentsDataGridView.Size = new System.Drawing.Size(344, 218);
      this.incidentsDataGridView.TabIndex = 3;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 272);
      this.Controls.Add(this.incidentsDataGridView);
      this.Controls.Add(this.searchIncidentButton);
      this.Controls.Add(this.addIncidentButton);
      this.Controls.Add(this.Logout);
      this.Controls.Add(this.LoggedInUserLabel);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Main Form";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
      this.Load += new System.EventHandler(this.MainFormLoad);
      ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LoggedInUserLabel;
    private System.Windows.Forms.LinkLabel Logout;
    private System.Windows.Forms.Button addIncidentButton;
    private System.Windows.Forms.Button searchIncidentButton;
    private System.Windows.Forms.DataGridView incidentsDataGridView;
  }
}