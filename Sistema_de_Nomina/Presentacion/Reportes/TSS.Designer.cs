namespace Sistema_de_Nomina.Presentacion.Reportes
{
    partial class TSS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteTssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportes = new Sistema_de_Nomina.DataSets.Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._Reporte_TssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteTssBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._Reporte_TssTableAdapter = new Sistema_de_Nomina.DataSets.ReportesTableAdapters._Reporte_TssTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Reporte_TssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTssBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteTssBindingSource
            // 
            this.reporteTssBindingSource.DataMember = "_Reporte_Tss";
            this.reporteTssBindingSource.DataSource = this.reportes;
            // 
            // reportes
            // 
            this.reportes.DataSetName = "Reportes";
            this.reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this._Reporte_TssBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_Nomina.Presentacion.Reportes.RTSS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // _Reporte_TssBindingSource
            // 
            this._Reporte_TssBindingSource.DataMember = "_Reporte_Tss";
            this._Reporte_TssBindingSource.DataSource = this.reportes;
            // 
            // reporteTssBindingSource1
            // 
            this.reporteTssBindingSource1.DataMember = "_Reporte_Tss";
            this.reporteTssBindingSource1.DataSource = this.reportes;
            // 
            // _Reporte_TssTableAdapter
            // 
            this._Reporte_TssTableAdapter.ClearBeforeFill = true;
            // 
            // TSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TSS";
            this.Text = "TSS";
            this.Load += new System.EventHandler(this.TSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteTssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Reporte_TssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTssBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.Reportes reportes;
        private System.Windows.Forms.BindingSource reporteTssBindingSource;
        private System.Windows.Forms.BindingSource _Reporte_TssBindingSource;
        private System.Windows.Forms.BindingSource reporteTssBindingSource1;
        private DataSets.ReportesTableAdapters._Reporte_TssTableAdapter _Reporte_TssTableAdapter;
    }
}