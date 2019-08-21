namespace Sistema_de_Nomina.Presentacion.Reportes
{
    partial class ReporteIndividual
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
            this._Ver_Nomina_individualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportes = new Sistema_de_Nomina.DataSets.Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.verNominaindividualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Ver_Nomina_individualTableAdapter = new Sistema_de_Nomina.DataSets.ReportesTableAdapters._Ver_Nomina_individualTableAdapter();
            this.T_IdNomina = new System.Windows.Forms.TextBox();
            this.T_IdEmpleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._Ver_Nomina_individualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verNominaindividualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _Ver_Nomina_individualBindingSource
            // 
            this._Ver_Nomina_individualBindingSource.DataMember = "_Ver_Nomina_individual";
            this._Ver_Nomina_individualBindingSource.DataSource = this.reportes;
            // 
            // reportes
            // 
            this.reportes.DataSetName = "Reportes";
            this.reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteIndividual";
            reportDataSource1.Value = this._Ver_Nomina_individualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_Nomina.Presentacion.Reportes.ReporteP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1044, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // verNominaindividualBindingSource
            // 
            this.verNominaindividualBindingSource.DataMember = "_Ver_Nomina_individual";
            this.verNominaindividualBindingSource.DataSource = this.reportes;
            // 
            // _Ver_Nomina_individualTableAdapter
            // 
            this._Ver_Nomina_individualTableAdapter.ClearBeforeFill = true;
            // 
            // T_IdNomina
            // 
            this.T_IdNomina.Location = new System.Drawing.Point(359, 128);
            this.T_IdNomina.Name = "T_IdNomina";
            this.T_IdNomina.Size = new System.Drawing.Size(100, 20);
            this.T_IdNomina.TabIndex = 1;
            this.T_IdNomina.Visible = false;
            // 
            // T_IdEmpleado
            // 
            this.T_IdEmpleado.Location = new System.Drawing.Point(577, 215);
            this.T_IdEmpleado.Name = "T_IdEmpleado";
            this.T_IdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.T_IdEmpleado.TabIndex = 2;
            this.T_IdEmpleado.Visible = false;
            // 
            // ReporteIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 571);
            this.Controls.Add(this.T_IdEmpleado);
            this.Controls.Add(this.T_IdNomina);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteIndividual";
            this.Text = "ReporteIndividual";
            this.Load += new System.EventHandler(this.ReporteIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Ver_Nomina_individualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verNominaindividualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource verNominaindividualBindingSource;
        private DataSets.Reportes reportes;
        private DataSets.ReportesTableAdapters._Ver_Nomina_individualTableAdapter _Ver_Nomina_individualTableAdapter;
        private System.Windows.Forms.BindingSource _Ver_Nomina_individualBindingSource;
        private System.Windows.Forms.TextBox T_IdNomina;
        private System.Windows.Forms.TextBox T_IdEmpleado;
    }
}