﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport.Controls
{
  /// <summary>
  /// A control that shows all the incidents unfiltered.
  /// </summary>
  public partial class LoadAllIncidentsControl : UserControl
  {
    readonly IncidentController _incidentController;
    
    /// <summary>
    /// this is a required method on any form. I am not really doing anything special here.
    /// </summary>
    public LoadAllIncidentsControl()
    {
      InitializeComponent();

      _incidentController = new IncidentController();
    }

    private void SetDataSource()
    {
      IncidentsDataGridView.DataSource = null;
      IncidentsDataGridView.DataSource = new BindingSource(_incidentController.GetIncidents(), null);
    }

    private void LoadAllIncidentsControlVisibleChanged(object sender, EventArgs e)
    {
      SetDataSource();
    }
  }
}
