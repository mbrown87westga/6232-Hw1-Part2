using System;
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
    private List<Technician> _technicianList;
    private Technician _technician;
    private List<Invoice> _invoiceList;

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
        _technicianList = _incidentController.GetTechniciansWithIncidents();
        nameComboBox.DataSource = _technicianList;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }
    }

    private void getTechnicianData()
    {
      int technicianID = (int)nameComboBox.SelectedValue;
      try
      {
        _technician = TechnicianDB.GetTechnicianNameAndAddress(technicianID);
        technicianBindingSource.Clear();
        technicianBindingSource.Add(_technician);

        _invoiceList = InvoiceDB.GetUnpaidTechnicianInvoices(technicianID);
        invoiceDataGridView.DataSource = _invoiceList;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }
    }
  }
}
