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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewIncidentsByTechnicianControl));
      System.Windows.Forms.Label emailLabel;
      System.Windows.Forms.Label phoneLabel;
      System.Windows.Forms.Label nameLabel;
      this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.technicianBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.technicianBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.emailTextBox = new System.Windows.Forms.TextBox();
      this.phoneTextBox = new System.Windows.Forms.TextBox();
      this.nameComboBox = new System.Windows.Forms.ComboBox();
      this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.incidentDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      emailLabel = new System.Windows.Forms.Label();
      phoneLabel = new System.Windows.Forms.Label();
      nameLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianBindingNavigator)).BeginInit();
      this.technicianBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // technicianBindingSource
      // 
      this.technicianBindingSource.DataSource = typeof(TechSupportData.Models.Technician);
      // 
      // technicianBindingNavigator
      // 
      this.technicianBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.technicianBindingNavigator.BindingSource = this.technicianBindingSource;
      this.technicianBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.technicianBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.technicianBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.technicianBindingNavigatorSaveItem});
      this.technicianBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.technicianBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.technicianBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.technicianBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.technicianBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.technicianBindingNavigator.Name = "technicianBindingNavigator";
      this.technicianBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.technicianBindingNavigator.Size = new System.Drawing.Size(554, 25);
      this.technicianBindingNavigator.TabIndex = 0;
      this.technicianBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // technicianBindingNavigatorSaveItem
      // 
      this.technicianBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.technicianBindingNavigatorSaveItem.Enabled = false;
      this.technicianBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("technicianBindingNavigatorSaveItem.Image")));
      this.technicianBindingNavigatorSaveItem.Name = "technicianBindingNavigatorSaveItem";
      this.technicianBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.technicianBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // emailLabel
      // 
      emailLabel.AutoSize = true;
      emailLabel.Location = new System.Drawing.Point(25, 58);
      emailLabel.Name = "emailLabel";
      emailLabel.Size = new System.Drawing.Size(35, 13);
      emailLabel.TabIndex = 1;
      emailLabel.Text = "Email:";
      // 
      // emailTextBox
      // 
      this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Email", true));
      this.emailTextBox.Location = new System.Drawing.Point(66, 55);
      this.emailTextBox.Name = "emailTextBox";
      this.emailTextBox.Size = new System.Drawing.Size(340, 20);
      this.emailTextBox.TabIndex = 2;
      // 
      // phoneLabel
      // 
      phoneLabel.AutoSize = true;
      phoneLabel.Location = new System.Drawing.Point(19, 84);
      phoneLabel.Name = "phoneLabel";
      phoneLabel.Size = new System.Drawing.Size(41, 13);
      phoneLabel.TabIndex = 3;
      phoneLabel.Text = "Phone:";
      // 
      // phoneTextBox
      // 
      this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Phone", true));
      this.phoneTextBox.Location = new System.Drawing.Point(66, 81);
      this.phoneTextBox.Name = "phoneTextBox";
      this.phoneTextBox.Size = new System.Drawing.Size(156, 20);
      this.phoneTextBox.TabIndex = 4;
      // 
      // nameLabel
      // 
      nameLabel.AutoSize = true;
      nameLabel.Location = new System.Drawing.Point(22, 31);
      nameLabel.Name = "nameLabel";
      nameLabel.Size = new System.Drawing.Size(38, 13);
      nameLabel.TabIndex = 5;
      nameLabel.Text = "Name:";
      // 
      // nameComboBox
      // 
      this.nameComboBox.DataSource = this.technicianBindingSource;
      this.nameComboBox.DisplayMember = "Name";
      this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.nameComboBox.FormattingEnabled = true;
      this.nameComboBox.Location = new System.Drawing.Point(66, 28);
      this.nameComboBox.Name = "nameComboBox";
      this.nameComboBox.Size = new System.Drawing.Size(340, 21);
      this.nameComboBox.TabIndex = 6;
      this.nameComboBox.ValueMember = "TechId";
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
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
      this.incidentDataGridView.DataSource = this.incidentBindingSource;
      this.incidentDataGridView.Location = new System.Drawing.Point(3, 107);
      this.incidentDataGridView.Name = "incidentDataGridView";
      this.incidentDataGridView.Size = new System.Drawing.Size(548, 223);
      this.incidentDataGridView.TabIndex = 7;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductCode";
      this.dataGridViewTextBoxColumn2.HeaderText = "ProductCode";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "DateOpened";
      this.dataGridViewTextBoxColumn3.HeaderText = "DateOpened";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "CustomerName";
      this.dataGridViewTextBoxColumn6.HeaderText = "CustomerName";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "Title";
      this.dataGridViewTextBoxColumn9.HeaderText = "Title";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "Description";
      this.dataGridViewTextBoxColumn10.HeaderText = "Description";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
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
      this.Controls.Add(this.technicianBindingNavigator);
      this.Name = "ViewIncidentsByTechnicianControl";
      this.Size = new System.Drawing.Size(554, 333);
      this.Load += new System.EventHandler(this.ViewIncidentsByTechnicianControl_Load);
      ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianBindingNavigator)).EndInit();
      this.technicianBindingNavigator.ResumeLayout(false);
      this.technicianBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource technicianBindingSource;
    private System.Windows.Forms.BindingNavigator technicianBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton technicianBindingNavigatorSaveItem;
    private System.Windows.Forms.TextBox emailTextBox;
    private System.Windows.Forms.TextBox phoneTextBox;
    private System.Windows.Forms.ComboBox nameComboBox;
    private System.Windows.Forms.BindingSource incidentBindingSource;
    private System.Windows.Forms.DataGridView incidentDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
  }
}
