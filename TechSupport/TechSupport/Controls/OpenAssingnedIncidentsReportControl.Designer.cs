namespace TechSupport.Controls
{
  partial class OpenAssingnedIncidentsReportControl
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
      this.components = new System.ComponentModel.Container();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
      this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
      this.techSupportDataSet = new TechSupport.TechSupportDataSet();
      this.openAssignedIncidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.openAssignedIncidentsTableAdapter = new TechSupport.TechSupportDataSetTableAdapters.OpenAssignedIncidentsTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.openAssignedIncidentsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // reportViewer
      // 
      this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      reportDataSource2.Name = "OpenAssignedIncidentDataSet";
      reportDataSource2.Value = this.openAssignedIncidentsBindingSource;
      this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
      this.reportViewer.LocalReport.ReportEmbeddedResource = "TechSupport.OpenAssignedIncidentReport.rdlc";
      this.reportViewer.Location = new System.Drawing.Point(0, 0);
      this.reportViewer.Name = "reportViewer";
      this.reportViewer.ServerReport.BearerToken = null;
      this.reportViewer.Size = new System.Drawing.Size(611, 323);
      this.reportViewer.TabIndex = 0;
      // 
      // techSupportDataSet
      // 
      this.techSupportDataSet.DataSetName = "TechSupportDataSet";
      this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // openAssignedIncidentsBindingSource
      // 
      this.openAssignedIncidentsBindingSource.DataMember = "OpenAssignedIncidents";
      this.openAssignedIncidentsBindingSource.DataSource = this.techSupportDataSet;
      // 
      // openAssignedIncidentsTableAdapter
      // 
      this.openAssignedIncidentsTableAdapter.ClearBeforeFill = true;
      // 
      // OpenAssingnedIncidentsReportControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.reportViewer);
      this.Name = "OpenAssingnedIncidentsReportControl";
      this.Size = new System.Drawing.Size(611, 323);
      this.Load += new System.EventHandler(this.OpenAssingnedIncidentsReportControl_Load);
      ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.openAssignedIncidentsBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    private System.Windows.Forms.BindingSource openAssignedIncidentsBindingSource;
    private TechSupportDataSet techSupportDataSet;
    private TechSupportDataSetTableAdapters.OpenAssignedIncidentsTableAdapter openAssignedIncidentsTableAdapter;
  }
}
