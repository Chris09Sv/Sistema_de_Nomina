namespace Sistema_de_Nomina.Presentacion
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGISTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLEADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEPARTAMENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOMINAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOMINADEPAGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hISTORIALDENOMINAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonificacionesYPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tASADEDEDUCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistema_de_NominaDataSet = new Sistema_de_Nomina.Sistema_de_NominaDataSet();
            this.storeVistanominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.store_Vista_nominaTableAdapter = new Sistema_de_Nomina.Sistema_de_NominaDataSetTableAdapters.store_Vista_nominaTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_NominaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeVistanominaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "SISTEMA DE NOMINA DE LA ACADEMIA DE COLORADO ROCKIES RD";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTROToolStripMenuItem,
            this.nOMINAToolStripMenuItem,
            this.bonificacionesYPrestamosToolStripMenuItem,
            this.cuentasPorCobrarToolStripMenuItem1,
            this.tASADEDEDUCIONESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGISTROToolStripMenuItem
            // 
            this.rEGISTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPLEADOToolStripMenuItem,
            this.dEPARTAMENTOToolStripMenuItem,
            this.uSUARIOToolStripMenuItem});
            this.rEGISTROToolStripMenuItem.Name = "rEGISTROToolStripMenuItem";
            this.rEGISTROToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.rEGISTROToolStripMenuItem.Text = "Registro";
            // 
            // eMPLEADOToolStripMenuItem
            // 
            this.eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            this.eMPLEADOToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.eMPLEADOToolStripMenuItem.Text = "Empleado";
            this.eMPLEADOToolStripMenuItem.Click += new System.EventHandler(this.EMPLEADOToolStripMenuItem_Click);
            // 
            // dEPARTAMENTOToolStripMenuItem
            // 
            this.dEPARTAMENTOToolStripMenuItem.Name = "dEPARTAMENTOToolStripMenuItem";
            this.dEPARTAMENTOToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.dEPARTAMENTOToolStripMenuItem.Text = "Departamento";
            this.dEPARTAMENTOToolStripMenuItem.Click += new System.EventHandler(this.DEPARTAMENTOToolStripMenuItem_Click);
            // 
            // uSUARIOToolStripMenuItem
            // 
            this.uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            this.uSUARIOToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.uSUARIOToolStripMenuItem.Text = "Usuario";
            this.uSUARIOToolStripMenuItem.Click += new System.EventHandler(this.USUARIOToolStripMenuItem_Click);
            // 
            // nOMINAToolStripMenuItem
            // 
            this.nOMINAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOMINADEPAGOToolStripMenuItem,
            this.hISTORIALDENOMINAToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.nOMINAToolStripMenuItem.Name = "nOMINAToolStripMenuItem";
            this.nOMINAToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.nOMINAToolStripMenuItem.Text = "Nomina";
            // 
            // nOMINADEPAGOToolStripMenuItem
            // 
            this.nOMINADEPAGOToolStripMenuItem.Name = "nOMINADEPAGOToolStripMenuItem";
            this.nOMINADEPAGOToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.nOMINADEPAGOToolStripMenuItem.Text = "Nomina de pago";
            this.nOMINADEPAGOToolStripMenuItem.Click += new System.EventHandler(this.NOMINADEPAGOToolStripMenuItem_Click);
            // 
            // hISTORIALDENOMINAToolStripMenuItem
            // 
            this.hISTORIALDENOMINAToolStripMenuItem.Name = "hISTORIALDENOMINAToolStripMenuItem";
            this.hISTORIALDENOMINAToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.hISTORIALDENOMINAToolStripMenuItem.Text = "Historial";
            this.hISTORIALDENOMINAToolStripMenuItem.Click += new System.EventHandler(this.hISTORIALDENOMINAToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItem_Click);
            // 
            // bonificacionesYPrestamosToolStripMenuItem
            // 
            this.bonificacionesYPrestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasPorCobrarToolStripMenuItem});
            this.bonificacionesYPrestamosToolStripMenuItem.Name = "bonificacionesYPrestamosToolStripMenuItem";
            this.bonificacionesYPrestamosToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.bonificacionesYPrestamosToolStripMenuItem.Text = "Bonificaciones y Prestamos";
            this.bonificacionesYPrestamosToolStripMenuItem.Click += new System.EventHandler(this.BonificacionesYPrestamosToolStripMenuItem_Click);
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por cobrar";
            this.cuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.CuentasPorCobrarToolStripMenuItem_Click);
            // 
            // cuentasPorCobrarToolStripMenuItem1
            // 
            this.cuentasPorCobrarToolStripMenuItem1.Name = "cuentasPorCobrarToolStripMenuItem1";
            this.cuentasPorCobrarToolStripMenuItem1.Size = new System.Drawing.Size(140, 24);
            this.cuentasPorCobrarToolStripMenuItem1.Text = "Cuentas por cobrar";
            this.cuentasPorCobrarToolStripMenuItem1.Click += new System.EventHandler(this.CuentasPorCobrarToolStripMenuItem1_Click);
            // 
            // tASADEDEDUCIONESToolStripMenuItem
            // 
            this.tASADEDEDUCIONESToolStripMenuItem.Name = "tASADEDEDUCIONESToolStripMenuItem";
            this.tASADEDEDUCIONESToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.tASADEDEDUCIONESToolStripMenuItem.Text = "Tasa de deducciones";
            this.tASADEDEDUCIONESToolStripMenuItem.Click += new System.EventHandler(this.TASADEDEDUCIONESToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.sALIRToolStripMenuItem.Text = "Salir";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.SALIRToolStripMenuItem_Click);
            // 
            // sistema_de_NominaDataSet
            // 
            this.sistema_de_NominaDataSet.DataSetName = "Sistema_de_NominaDataSet";
            this.sistema_de_NominaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeVistanominaBindingSource
            // 
            this.storeVistanominaBindingSource.DataMember = "store_Vista_nomina";
            this.storeVistanominaBindingSource.DataSource = this.sistema_de_NominaDataSet;
            // 
            // store_Vista_nominaTableAdapter
            // 
            this.store_Vista_nominaTableAdapter.ClearBeforeFill = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_NominaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeVistanominaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEPARTAMENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOMINAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOMINADEPAGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hISTORIALDENOMINAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tASADEDEDUCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonificacionesYPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem1;
        private Sistema_de_NominaDataSet sistema_de_NominaDataSet;
        private System.Windows.Forms.BindingSource storeVistanominaBindingSource;
        private Sistema_de_NominaDataSetTableAdapters.store_Vista_nominaTableAdapter store_Vista_nominaTableAdapter;
    }
}