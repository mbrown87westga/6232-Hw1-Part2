namespace TechSupport.Controls
{
  partial class ViewIncidentsByTechnicianControl
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
      System.Windows.Forms.Label emailLabel;
      System.Windows.Forms.Label phoneLabel;
      System.Windows.Forms.Label nameLabel;
      this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.emailTextBox = new System.Windows.Forms.TextBox();
      this.phoneTextBox = new System.Windows.Forms.TextBox();
      this.nameComboBox = new System.Windows.Forms.ComboBox();
      this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.incidentDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      emailLabel = new System.Windows.Forms.Label();
      phoneLabel = new System.Windows.Forms.Label();
      nameLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // emailLabel
      // 
      emailLabel.AutoSize = true;
      emailLabel.Location = new System.Drawing.Point(19, 33);
      emailLabel.Name = "emailLabel";
      emailLabel.Size = new System.Drawing.Size(35, 13);
      emailLabel.TabIndex = 1;
      emailLabel.Text = "Email:";
      // 
      // phoneLabel
      // 
      phoneLabel.AutoSize = true;
      phoneLabel.Location = new System.Drawing.Point(13, 59);
      phoneLabel.Name = "phoneLabel";
      phoneLabel.Size = new System.Drawing.Size(41, 13);
      phoneLabel.TabIndex = 3;
      phoneLabel.Text = "Phone:";
      // 
      // nameLabel
      // 
      nameLabel.AutoSize = true;
      nameLabel.Location = new System.Drawing.Point(16, 6);
      nameLabel.Name = "nameLabel";
      nameLabel.Size = new System.Drawing.Size(38, 13);
      nameLabel.TabIndex = 5;
      nameLabel.Text = "Name:";
      // 
      // technicianBindingSource
      // 
      this.technicianBindingSource.DataSource = typeof(TechSupportData.Models.Technician);
      // 
      // emailTextBox
      // 
      this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Email", true));
      this.emailTextBox.Enabled = false;
      this.emailTextBox.Location = new System.Drawing.Point(60, 30);
      this.emailTextBox.Name = "emailTextBox";
      this.emailTextBox.Size = new System.Drawing.Size(340, 20);
      this.emailTextBox.TabIndex = 2;
      // 
      // phoneTextBox
      // 
      this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Phone", true));
      this.phoneTextBox.Enabled = false;
      this.phoneTextBox.Location = new System.Drawing.Point(60, 56);
      this.phoneTextBox.Name = "phoneTextBox";
      this.phoneTextBox.Size = new System.Drawing.Size(156, 20);
      this.phoneTextBox.TabIndex = 4;
      // 
      // nameComboBox
      // 
      this.nameComboBox.DataSource = this.technicianBindingSource;
      this.nameComboBox.DisplayMember = "Name";
      this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.nameComboBox.FormattingEnabled = true;
      this.nameComboBox.Location = new System.Drawing.Point(60, 3);
      this.nameComboBox.Name = "nameComboBox";
      this.nameComboBox.Size = new System.Drawing.Size(340, 21);
      this.nameComboBox.TabIndex = 6;
      this.nameComboBox.ValueMember = "TechId";
      this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
      // 
      // incidentBindingSource
      // 
      this.incidentBindingSource.DataSource = typeof(TechSupportData.Models.Incident);
      // 
      // incidentDataGridView
      // 
      this.incidentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.incidentDataGridView.AutoGenerateColumns = false;
      this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.incidentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9});
      this.incidentDataGridView.DataSource = this.incidentBindingSource;
      this.incidentDataGridView.Location = new System.Drawing.Point(3, 82);
      this.incidentDataGridView.Name = "incidentDataGridView";
      this.incidentDataGridView.Size = new System.Drawing.Size(548, 248);
      this.incidentDataGridView.TabIndex = 7;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
      this.dataGridViewTextBoxColumn2.HeaderText = "Product";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "DateOpened";
      this.dataGridViewTextBoxColumn3.HeaderText = "Date Opened";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "CustomerName";
      this.dataGridViewTextBoxColumn6.HeaderText = "Customer";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "Title";
      this.dataGridViewTextBoxColumn9.HeaderText = "Title";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      // 
      // ViewIncidentsByTechnicianControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.incidentDataGridView);
      this.Controls.Add(nameLabel);
      this.Controls.Add(this.nameComboBox);
      this.Controls.Add(phoneLabel);
      this.Controls.Add(this.phoneTextBox);
      this.Controls.Add(emailLabel);
      this.Controls.Add(this.emailTextBox);
      this.Name = "ViewIncidentsByTechnicianControl";
      this.Size = new System.Drawing.Size(554, 333);
      this.Load += new System.EventHandler(this.ViewIncidentsByTechnicianControl_Load);
      ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource technicianBindingSource;
    private System.Windows.Forms.TextBox emailTextBox;
    private System.Windows.Forms.TextBox phoneTextBox;
    private System.Windows.Forms.ComboBox nameComboBox;
    private System.Windows.Forms.BindingSource incidentBindingSource;
    private System.Windows.Forms.DataGridView incidentDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
  }
}
