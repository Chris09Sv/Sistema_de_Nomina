namespace Sistema_de_Nomina.Presentacion.Reportes
{
    partial class InformeDePago
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
            this.pagoDeNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportes = new Sistema_de_Nomina.DataSets.Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pagoDeNominaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pagoDeNominaTableAdapter = new Sistema_de_Nomina.DataSets.ReportesTableAdapters.PagoDeNominaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pagoDeNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoDeNominaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pagoDeNominaBindingSource
            // 
            this.pagoDeNominaBindingSource.DataMember = "PagoDeNomina";
            this.pagoDeNominaBindingSource.DataSource = this.reportes;
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
            reportDataSource1.Value = this.pagoDeNominaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_Nomina.Presentacion.Reportes.ReporteAPagar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // pagoDeNominaBindingSource1
            // 
            this.pagoDeNominaBindingSource1.DataMember = "PagoDeNomina";
            this.pagoDeNominaBindingSource1.DataSource = this.reportes;
            // 
            // pagoDeNominaTableAdapter
            // 
            this.pagoDeNominaTableAdapter.ClearBeforeFill = true;
            // 
            // InformeDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeDePago";
            this.Text = "InformeDePago";
            this.Load += new System.EventHandler(this.InformeDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagoDeNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoDeNominaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pagoDeNominaBindingSource;
        private DataSets.Reportes reportes;
        private System.Windows.Forms.BindingSource pagoDeNominaBindingSource1;
        private DataSets.ReportesTableAdapters.PagoDeNominaTableAdapter pagoDeNominaTableAdapter;
    }
}