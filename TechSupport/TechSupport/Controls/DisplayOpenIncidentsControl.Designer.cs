namespace TechSupport.Controls
{
  partial class DisplayOpenIncidentsControl
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
      this.OpenIncidentsListView = new System.Windows.Forms.ListView();
      this.ProductCodeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.DateOpenedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CustomerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.TechnicianColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.TitleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ErrorLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // OpenIncidentsListView
      // 
      this.OpenIncidentsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.OpenIncidentsListView.BackColor = System.Drawing.SystemColors.Control;
      this.OpenIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductCodeColumnHeader,
            this.DateOpenedColumnHeader,
            this.CustomerColumnHeader,
            this.TechnicianColumnHeader,
            this.TitleColumnHeader});
      this.OpenIncidentsListView.HideSelection = false;
      this.OpenIncidentsListView.Location = new System.Drawing.Point(3, 3);
      this.OpenIncidentsListView.Name = "OpenIncidentsListView";
      this.OpenIncidentsListView.Size = new System.Drawing.Size(631, 380);
      this.OpenIncidentsListView.TabIndex = 0;
      this.OpenIncidentsListView.UseCompatibleStateImageBehavior = false;
      this.OpenIncidentsListView.View = System.Windows.Forms.View.Details;
      // 
      // ProductCodeColumnHeader
      // 
      this.ProductCodeColumnHeader.Text = "Product Code";
      this.ProductCodeColumnHeader.Width = 100;
      // 
      // DateOpenedColumnHeader
      // 
      this.DateOpenedColumnHeader.Text = "Date Opened";
      this.DateOpenedColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.DateOpenedColumnHeader.Width = 100;
      // 
      // CustomerColumnHeader
      // 
      this.CustomerColumnHeader.Text = "Customer";
      this.CustomerColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.CustomerColumnHeader.Width = 100;
      // 
      // TechnicianColumnHeader
      // 
      this.TechnicianColumnHeader.Text = "Technician";
      this.TechnicianColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.TechnicianColumnHeader.Width = 100;
      // 
      // TitleColumnHeader
      // 
      this.TitleColumnHeader.Text = "Title";
      this.TitleColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.TitleColumnHeader.Width = 200;
      // 
      // ErrorLabel
      // 
      this.ErrorLabel.AutoSize = true;
      this.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ErrorLabel.Location = new System.Drawing.Point(0, 0);
      this.ErrorLabel.Name = "ErrorLabel";
      this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
      this.ErrorLabel.TabIndex = 1;
      this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.ErrorLabel.Visible = false;
      // 
      // DisplayOpenIncidentsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ErrorLabel);
      this.Controls.Add(this.OpenIncidentsListView);
      this.Name = "DisplayOpenIncidentsControl";
      this.Size = new System.Drawing.Size(637, 386);
      this.VisibleChanged += new System.EventHandler(this.DisplayOpenIncidentsControlVisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView OpenIncidentsListView;
    private System.Windows.Forms.ColumnHeader ProductCodeColumnHeader;
    private System.Windows.Forms.ColumnHeader DateOpenedColumnHeader;
    private System.Windows.Forms.ColumnHeader CustomerColumnHeader;
    private System.Windows.Forms.ColumnHeader TechnicianColumnHeader;
    private System.Windows.Forms.ColumnHeader TitleColumnHeader;
    private System.Windows.Forms.Label ErrorLabel;
  }
}
