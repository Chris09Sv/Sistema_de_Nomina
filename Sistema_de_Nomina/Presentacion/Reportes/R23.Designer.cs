namespace Sistema_de_Nomina.Presentacion.Reportes
{
    partial class R23
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
            this._ver_nominaDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportes = new Sistema_de_Nomina.DataSets.Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vernominaDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ver_nominaDTableAdapter = new Sistema_de_Nomina.DataSets.ReportesTableAdapters._ver_nominaDTableAdapter();
            this.vernominaDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.T_IDNomina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._ver_nominaDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vernominaDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vernominaDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _ver_nominaDBindingSource
            // 
            this._ver_nominaDBindingSource.DataMember = "_ver_nominaD";
            this._ver_nominaDBindingSource.DataSource = this.reportes;
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
            reportDataSource1.Value = this.vernominaDBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_Nomina.Presentacion.Reportes.DetalleDeNomina.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(737, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // vernominaDBindingSource
            // 
            this.vernominaDBindingSource.DataMember = "_ver_nominaD";
            this.vernominaDBindingSource.DataSource = this.reportes;
            // 
            // _ver_nominaDTableAdapter
            // 
            this._ver_nominaDTableAdapter.ClearBeforeFill = true;
            // 
            // vernominaDBindingSource1
            // 
            this.vernominaDBindingSource1.DataMember = "_ver_nominaD";
            this.vernominaDBindingSource1.DataSource = this.reportes;
            // 
            // T_IDNomina
            // 
            this.T_IDNomina.Location = new System.Drawing.Point(320, 59);
            this.T_IDNomina.Name = "T_IDNomina";
            this.T_IDNomina.Size = new System.Drawing.Size(100, 20);
            this.T_IDNomina.TabIndex = 1;
            this.T_IDNomina.Visible = false;
            // 
            // R23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.T_IDNomina);
            this.Controls.Add(this.reportViewer1);
            this.Name = "R23";
            this.Text = "R23";
            this.Load += new System.EventHandler(this.R23_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ver_nominaDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vernominaDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vernominaDBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource _ver_nominaDBindingSource;
        private DataSets.Reportes reportes;
        private System.Windows.Forms.BindingSource vernominaDBindingSource;
        private DataSets.ReportesTableAdapters._ver_nominaDTableAdapter _ver_nominaDTableAdapter;
        private System.Windows.Forms.BindingSource vernominaDBindingSource1;
        private System.Windows.Forms.TextBox T_IDNomina;
    }
}