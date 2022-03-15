﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupportData.Models;

namespace TechSupport.Controls
{
  /// <summary>
  /// a control which lets you view incidents by technician
  /// </summary>
  public partial class ViewIncidentsByTechnicianControl : UserControl
  {
    private readonly IncidentController _incidentController;
    private IEnumerable<Technician> _technicianList;
    private Technician _technician;
    private List<Incident> _incidentList;

    /// <summary>
    /// the constructor
    /// </summary>
    public ViewIncidentsByTechnicianControl()
    {
      InitializeComponent();
      _incidentController = new IncidentController();
    }

    private void ViewIncidentsByTechnicianControl_Load(object sender, EventArgs e)
    {
      this.GetTechnicianList();
      this.GetTechnicianData();
    }

    private void GetTechnicianList()
    {
      try
      {
        _technicianList = _incidentController.GetTechniciansWithIncidents().ToList();
        nameComboBox.DataSource = _technicianList;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }
    }

    private void GetTechnicianData()
    {
      try
      {
        int technicianId = (int)(nameComboBox?.SelectedValue ?? 0);
        _technician = _incidentController.GetTechnicianEmailAndPhone(technicianId);
        technicianBindingSource.Clear();
        technicianBindingSource.Add(_technician);

        _incidentList = _incidentController.GetOpenTechnicianIncidents(technicianId);
        incidentDataGridView.DataSource = _incidentList;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }
    }

    private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.GetTechnicianData();
    }
  }
}
