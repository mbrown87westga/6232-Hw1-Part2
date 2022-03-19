using System;
using System.Windows.Forms;

namespace TechSupport.Controls
{
  /// <summary>
  /// The report control
  /// </summary>
  public partial class OpenAssignedIncidentsReportControl : UserControl
  {
    /// <summary>
    /// The default constructor
    /// </summary>
    public OpenAssignedIncidentsReportControl()
    {
      InitializeComponent();
    }

    private void OpenAssignedIncidentsReportControl_Load(object sender, EventArgs e)
    {
      LoadData();
    }

    private void LoadData()
    {
      this.openAssignedIncidentsTableAdapter.Fill(this.techSupportDataSet.OpenAssignedIncidents);
      this.reportViewer.RefreshReport();
    }

    private void OpenAssignedIncidentsReportControl_VisibleChanged(object sender, EventArgs e)
    {
      LoadData();
    }
  }
}
