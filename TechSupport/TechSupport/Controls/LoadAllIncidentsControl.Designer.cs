namespace TechSupport.Controls
{
  partial class LoadAllIncidentsControl
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
      this.IncidentsDataGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.IncidentsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // IncidentsDataGridView
      // 
      this.IncidentsDataGridView.AllowUserToAddRows = false;
      this.IncidentsDataGridView.AllowUserToDeleteRows = false;
      this.IncidentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.IncidentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.IncidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.IncidentsDataGridView.Location = new System.Drawing.Point(3, 3);
      this.IncidentsDataGridView.Name = "IncidentsDataGridView";
      this.IncidentsDataGridView.ReadOnly = true;
      this.IncidentsDataGridView.Size = new System.Drawing.Size(631, 380);
      this.IncidentsDataGridView.TabIndex = 5;
      // 
      // LoadAllIncidentsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.IncidentsDataGridView);
      this.Name = "LoadAllIncidentsControl";
      this.Size = new System.Drawing.Size(637, 386);
      this.VisibleChanged += new System.EventHandler(this.LoadAllIncidentsControlVisibleChanged);
      ((System.ComponentModel.ISupportInitialize)(this.IncidentsDataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView IncidentsDataGridView;
  }
}
