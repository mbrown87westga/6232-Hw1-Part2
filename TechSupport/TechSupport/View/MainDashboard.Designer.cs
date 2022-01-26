﻿namespace TechSupport.View
{
  partial class MainDashboard
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.AddIncidentPage = new System.Windows.Forms.TabPage();
      this.addIncidentControl1 = new TechSupport.View.AddIncidentControl();
      this.LoadAllIncidentsPage = new System.Windows.Forms.TabPage();
      this.loadAllIncidentsControl1 = new TechSupport.Controls.LoadAllIncidentsControl();
      this.SearchIncidentsPage = new System.Windows.Forms.TabPage();
      this.searchIncidentsControl1 = new TechSupport.Controls.SearchIncidentsControl();
      this.LogoutLink = new System.Windows.Forms.LinkLabel();
      this.LoggedInUserLabel = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.AddIncidentPage.SuspendLayout();
      this.LoadAllIncidentsPage.SuspendLayout();
      this.SearchIncidentsPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.AddIncidentPage);
      this.tabControl1.Controls.Add(this.LoadAllIncidentsPage);
      this.tabControl1.Controls.Add(this.SearchIncidentsPage);
      this.tabControl1.Location = new System.Drawing.Point(0, 6);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(804, 444);
      this.tabControl1.TabIndex = 0;
      // 
      // AddIncidentPage
      // 
      this.AddIncidentPage.Controls.Add(this.addIncidentControl1);
      this.AddIncidentPage.Location = new System.Drawing.Point(4, 22);
      this.AddIncidentPage.Name = "AddIncidentPage";
      this.AddIncidentPage.Padding = new System.Windows.Forms.Padding(3);
      this.AddIncidentPage.Size = new System.Drawing.Size(796, 418);
      this.AddIncidentPage.TabIndex = 0;
      this.AddIncidentPage.Text = "Add Incident";
      this.AddIncidentPage.UseVisualStyleBackColor = true;
      // 
      // addIncidentControl1
      // 
      this.addIncidentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addIncidentControl1.Location = new System.Drawing.Point(3, 3);
      this.addIncidentControl1.Name = "addIncidentControl1";
      this.addIncidentControl1.Size = new System.Drawing.Size(790, 412);
      this.addIncidentControl1.TabIndex = 0;
      // 
      // LoadAllIncidentsPage
      // 
      this.LoadAllIncidentsPage.Controls.Add(this.loadAllIncidentsControl1);
      this.LoadAllIncidentsPage.Location = new System.Drawing.Point(4, 22);
      this.LoadAllIncidentsPage.Name = "LoadAllIncidentsPage";
      this.LoadAllIncidentsPage.Padding = new System.Windows.Forms.Padding(3);
      this.LoadAllIncidentsPage.Size = new System.Drawing.Size(796, 418);
      this.LoadAllIncidentsPage.TabIndex = 1;
      this.LoadAllIncidentsPage.Text = "Load All Incidents";
      this.LoadAllIncidentsPage.UseVisualStyleBackColor = true;
      // 
      // loadAllIncidentsControl1
      // 
      this.loadAllIncidentsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.loadAllIncidentsControl1.Location = new System.Drawing.Point(3, 3);
      this.loadAllIncidentsControl1.Name = "loadAllIncidentsControl1";
      this.loadAllIncidentsControl1.Size = new System.Drawing.Size(790, 412);
      this.loadAllIncidentsControl1.TabIndex = 0;
      // 
      // SearchIncidentsPage
      // 
      this.SearchIncidentsPage.Controls.Add(this.searchIncidentsControl1);
      this.SearchIncidentsPage.Location = new System.Drawing.Point(4, 22);
      this.SearchIncidentsPage.Name = "SearchIncidentsPage";
      this.SearchIncidentsPage.Size = new System.Drawing.Size(796, 418);
      this.SearchIncidentsPage.TabIndex = 2;
      this.SearchIncidentsPage.Text = "Search Incidents";
      this.SearchIncidentsPage.UseVisualStyleBackColor = true;
      // 
      // searchIncidentsControl1
      // 
      this.searchIncidentsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchIncidentsControl1.Location = new System.Drawing.Point(0, 0);
      this.searchIncidentsControl1.Name = "searchIncidentsControl1";
      this.searchIncidentsControl1.Size = new System.Drawing.Size(796, 418);
      this.searchIncidentsControl1.TabIndex = 0;
      // 
      // LogoutLink
      // 
      this.LogoutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.LogoutLink.AutoSize = true;
      this.LogoutLink.Location = new System.Drawing.Point(748, 6);
      this.LogoutLink.Name = "LogoutLink";
      this.LogoutLink.Size = new System.Drawing.Size(40, 13);
      this.LogoutLink.TabIndex = 5;
      this.LogoutLink.TabStop = true;
      this.LogoutLink.Text = "Logout";
      this.LogoutLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkClicked);
      // 
      // LoggedInUserLabel
      // 
      this.LoggedInUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.LoggedInUserLabel.Location = new System.Drawing.Point(610, 6);
      this.LoggedInUserLabel.Name = "LoggedInUserLabel";
      this.LoggedInUserLabel.Size = new System.Drawing.Size(132, 13);
      this.LoggedInUserLabel.TabIndex = 4;
      this.LoggedInUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // MainDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.LogoutLink);
      this.Controls.Add(this.LoggedInUserLabel);
      this.Controls.Add(this.tabControl1);
      this.Name = "MainDashboard";
      this.Text = "Main Dashboard";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboardClosed);
      this.tabControl1.ResumeLayout(false);
      this.AddIncidentPage.ResumeLayout(false);
      this.LoadAllIncidentsPage.ResumeLayout(false);
      this.SearchIncidentsPage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage AddIncidentPage;
    private System.Windows.Forms.TabPage LoadAllIncidentsPage;
    private System.Windows.Forms.TabPage SearchIncidentsPage;
    private AddIncidentControl addIncidentControl1;
    private Controls.LoadAllIncidentsControl loadAllIncidentsControl1;
    private Controls.SearchIncidentsControl searchIncidentsControl1;
    private System.Windows.Forms.LinkLabel LogoutLink;
    private System.Windows.Forms.Label LoggedInUserLabel;
  }
}