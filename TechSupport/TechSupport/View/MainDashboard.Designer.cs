using TechSupport.Controls;

namespace TechSupport.View
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
      this.DisplayOpenIncidentsPage = new System.Windows.Forms.TabPage();
      this.displayOpenIncidentsControl1 = new TechSupport.Controls.DisplayOpenIncidentsControl();
      this.AddIncidentPage = new System.Windows.Forms.TabPage();
      this.addIncidentControl1 = new TechSupport.Controls.AddIncidentControl();
      this.UpdateIncidentPage = new System.Windows.Forms.TabPage();
      this.updateIncidentControl1 = new TechSupport.Controls.UpdateIncidentControl();
      this.ViewIncidentsByTechnicianPage = new System.Windows.Forms.TabPage();
      this.ViewIncidentsByTechnicianControl1 = new TechSupport.Controls.ViewIncidentsByTechnicianControl();
      this.LogoutLink = new System.Windows.Forms.LinkLabel();
      this.LoggedInUserLabel = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.DisplayOpenIncidentsPage.SuspendLayout();
      this.AddIncidentPage.SuspendLayout();
      this.UpdateIncidentPage.SuspendLayout();
      this.ViewIncidentsByTechnicianPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.DisplayOpenIncidentsPage);
      this.tabControl1.Controls.Add(this.AddIncidentPage);
      this.tabControl1.Controls.Add(this.UpdateIncidentPage);
      this.tabControl1.Controls.Add(this.ViewIncidentsByTechnicianPage);
      this.tabControl1.Location = new System.Drawing.Point(0, 6);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(710, 481);
      this.tabControl1.TabIndex = 0;
      // 
      // DisplayOpenIncidentsPage
      // 
      this.DisplayOpenIncidentsPage.Controls.Add(this.displayOpenIncidentsControl1);
      this.DisplayOpenIncidentsPage.Location = new System.Drawing.Point(4, 22);
      this.DisplayOpenIncidentsPage.Name = "DisplayOpenIncidentsPage";
      this.DisplayOpenIncidentsPage.Size = new System.Drawing.Size(702, 455);
      this.DisplayOpenIncidentsPage.TabIndex = 3;
      this.DisplayOpenIncidentsPage.Text = "Display Open Incidents";
      this.DisplayOpenIncidentsPage.UseVisualStyleBackColor = true;
      // 
      // displayOpenIncidentsControl1
      // 
      this.displayOpenIncidentsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.displayOpenIncidentsControl1.Location = new System.Drawing.Point(0, 0);
      this.displayOpenIncidentsControl1.Name = "displayOpenIncidentsControl1";
      this.displayOpenIncidentsControl1.Size = new System.Drawing.Size(702, 455);
      this.displayOpenIncidentsControl1.TabIndex = 0;
      // 
      // AddIncidentPage
      // 
      this.AddIncidentPage.Controls.Add(this.addIncidentControl1);
      this.AddIncidentPage.Location = new System.Drawing.Point(4, 22);
      this.AddIncidentPage.Name = "AddIncidentPage";
      this.AddIncidentPage.Padding = new System.Windows.Forms.Padding(3);
      this.AddIncidentPage.Size = new System.Drawing.Size(702, 455);
      this.AddIncidentPage.TabIndex = 0;
      this.AddIncidentPage.Text = "Add";
      this.AddIncidentPage.UseVisualStyleBackColor = true;
      // 
      // addIncidentControl1
      // 
      this.addIncidentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addIncidentControl1.Location = new System.Drawing.Point(3, 3);
      this.addIncidentControl1.Name = "addIncidentControl1";
      this.addIncidentControl1.Size = new System.Drawing.Size(696, 449);
      this.addIncidentControl1.TabIndex = 0;
      // 
      // UpdateIncidentPage
      // 
      this.UpdateIncidentPage.Controls.Add(this.updateIncidentControl1);
      this.UpdateIncidentPage.Location = new System.Drawing.Point(4, 22);
      this.UpdateIncidentPage.Name = "UpdateIncidentPage";
      this.UpdateIncidentPage.Size = new System.Drawing.Size(702, 455);
      this.UpdateIncidentPage.TabIndex = 4;
      this.UpdateIncidentPage.Text = "Update";
      this.UpdateIncidentPage.UseVisualStyleBackColor = true;
      // 
      // updateIncidentControl1
      // 
      this.updateIncidentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.updateIncidentControl1.Location = new System.Drawing.Point(0, 0);
      this.updateIncidentControl1.Name = "updateIncidentControl1";
      this.updateIncidentControl1.Size = new System.Drawing.Size(702, 455);
      this.updateIncidentControl1.TabIndex = 0;
      // 
      // ViewIncidentsByTechnicianPage
      // 
      this.ViewIncidentsByTechnicianPage.Controls.Add(this.ViewIncidentsByTechnicianControl1);
      this.ViewIncidentsByTechnicianPage.Location = new System.Drawing.Point(4, 22);
      this.ViewIncidentsByTechnicianPage.Name = "ViewIncidentsByTechnicianPage";
      this.ViewIncidentsByTechnicianPage.Size = new System.Drawing.Size(702, 455);
      this.ViewIncidentsByTechnicianPage.TabIndex = 5;
      this.ViewIncidentsByTechnicianPage.Text = "View Incidents by Technician";
      this.ViewIncidentsByTechnicianPage.UseVisualStyleBackColor = true;
      // 
      // ViewIncidentsByTechnicianControl1
      // 
      this.ViewIncidentsByTechnicianControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ViewIncidentsByTechnicianControl1.Location = new System.Drawing.Point(8, 12);
      this.ViewIncidentsByTechnicianControl1.Name = "ViewIncidentsByTechnicianControl1";
      this.ViewIncidentsByTechnicianControl1.Size = new System.Drawing.Size(682, 435);
      this.ViewIncidentsByTechnicianControl1.TabIndex = 0;
      // 
      // LogoutLink
      // 
      this.LogoutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.LogoutLink.AutoSize = true;
      this.LogoutLink.Location = new System.Drawing.Point(654, 6);
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
      this.LoggedInUserLabel.Location = new System.Drawing.Point(516, 6);
      this.LoggedInUserLabel.Name = "LoggedInUserLabel";
      this.LoggedInUserLabel.Size = new System.Drawing.Size(132, 13);
      this.LoggedInUserLabel.TabIndex = 4;
      this.LoggedInUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // MainDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(706, 487);
      this.Controls.Add(this.LogoutLink);
      this.Controls.Add(this.LoggedInUserLabel);
      this.Controls.Add(this.tabControl1);
      this.MinimumSize = new System.Drawing.Size(466, 295);
      this.Name = "MainDashboard";
      this.Text = "Main Dashboard";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboardClosed);
      this.tabControl1.ResumeLayout(false);
      this.DisplayOpenIncidentsPage.ResumeLayout(false);
      this.AddIncidentPage.ResumeLayout(false);
      this.UpdateIncidentPage.ResumeLayout(false);
      this.ViewIncidentsByTechnicianPage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage AddIncidentPage;
    private AddIncidentControl addIncidentControl1;
    private System.Windows.Forms.LinkLabel LogoutLink;
    private System.Windows.Forms.Label LoggedInUserLabel;
    private System.Windows.Forms.TabPage DisplayOpenIncidentsPage;
    private Controls.DisplayOpenIncidentsControl displayOpenIncidentsControl1;
    private System.Windows.Forms.TabPage UpdateIncidentPage;
    private UpdateIncidentControl updateIncidentControl1;
    private ViewIncidentsByTechnicianControl ViewIncidentsByTechnicianControl1;
    private System.Windows.Forms.TabPage ViewIncidentsByTechnicianPage;
  }
}