﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.Controls
{
  /// <summary>
  /// The report control
  /// </summary>
  public partial class OpenAssingnedIncidentsReportControl : UserControl
  {
    /// <summary>
    /// The default constructor
    /// </summary>
    public OpenAssingnedIncidentsReportControl()
    {
      InitializeComponent();
    }

    private void OpenAssingnedIncidentsReportControl_Load(object sender, EventArgs e)
    {
      LoadData();
    }

    private void LoadData()
    {
      this.openAssignedIncidentsTableAdapter.Fill(this.techSupportDataSet.OpenAssignedIncidents);
      this.reportViewer.RefreshReport();
    }

    private void OpenAssingnedIncidentsReportControl_VisibleChanged(object sender, EventArgs e)
    {
      LoadData();
    }
  }
}
