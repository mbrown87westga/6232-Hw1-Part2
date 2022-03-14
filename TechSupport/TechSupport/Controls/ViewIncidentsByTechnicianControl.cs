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
using TechSupportData.Models;

namespace TechSupport.Controls
{
  public partial class ViewIncidentsByTechnicianControl : UserControl
  {
    private readonly IncidentController _incidentController;
    private IEnumerable<Technician> _technicianList;
    private Technician _technician;
    private List<Incident> _incidentList;

    public ViewIncidentsByTechnicianControl()
    {
      InitializeComponent();
      _incidentController = new IncidentController();
    }

    private void ViewIncidentsByTechnicianControl_Load(object sender, EventArgs e)
    {
      this.getTechnicianList();
      this.getTechnicianData();
    }

    private void getTechnicianList()
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

    private void getTechnicianData()
    {
      int technicianID = (int)(nameComboBox?.SelectedValue ?? 0);
      try
      {
        _technician = _incidentController.GetTechnicianEmailAndPhone(technicianID);
        technicianBindingSource.Clear();
        technicianBindingSource.Add(_technician);

        _incidentList = _incidentController.GetOpenTechnicianIncidents(technicianID);
        incidentDataGridView.DataSource = _incidentList;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }
    }

    private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.getTechnicianData();
    }
  }
}
