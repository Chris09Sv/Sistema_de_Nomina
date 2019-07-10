namespace Sistema_de_Nomina.Presentacion
{
    partial class Mantenimiento_de__nomina
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBX_Estatus = new System.Windows.Forms.ComboBox();
            this.DTP_FechaNomina = new System.Windows.Forms.DateTimePicker();
            this.T_Dollar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Estatus = new System.Windows.Forms.CheckBox();
            this.CB_Usuario = new System.Windows.Forms.CheckBox();
            this.CB_FechaNomina = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_GenerarNomina = new System.Windows.Forms.Button();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CBX_Estatus);
            this.panel1.Controls.Add(this.DTP_FechaNomina);
            this.panel1.Controls.Add(this.T_Dollar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CB_Estatus);
            this.panel1.Controls.Add(this.CB_Usuario);
            this.panel1.Controls.Add(this.CB_FechaNomina);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 146);
            this.panel1.TabIndex = 1;
            // 
            // CBX_Estatus
            // 
            this.CBX_Estatus.FormattingEnabled = true;
            this.CBX_Estatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBX_Estatus.Location = new System.Drawing.Point(581, 82);
            this.CBX_Estatus.Name = "CBX_Estatus";
            this.CBX_Estatus.Size = new System.Drawing.Size(121, 21);
            this.CBX_Estatus.TabIndex = 10;
            // 
            // DTP_FechaNomina
            // 
            this.DTP_FechaNomina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FechaNomina.Location = new System.Drawing.Point(135, 83);
            this.DTP_FechaNomina.Name = "DTP_FechaNomina";
            this.DTP_FechaNomina.Size = new System.Drawing.Size(89, 20);
            this.DTP_FechaNomina.TabIndex = 9;
            // 
            // T_Dollar
            // 
            this.T_Dollar.Location = new System.Drawing.Point(227, 13);
            this.T_Dollar.Name = "T_Dollar";
            this.T_Dollar.Size = new System.Drawing.Size(136, 20);
            this.T_Dollar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tasa de cambio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Nomina";
            // 
            // CB_Estatus
            // 
            this.CB_Estatus.AutoSize = true;
            this.CB_Estatus.Location = new System.Drawing.Point(512, 85);
            this.CB_Estatus.Name = "CB_Estatus";
            this.CB_Estatus.Size = new System.Drawing.Size(15, 14);
            this.CB_Estatus.TabIndex = 4;
            this.CB_Estatus.UseVisualStyleBackColor = true;
            // 
            // CB_Usuario
            // 
            this.CB_Usuario.AutoSize = true;
            this.CB_Usuario.Location = new System.Drawing.Point(262, 85);
            this.CB_Usuario.Name = "CB_Usuario";
            this.CB_Usuario.Size = new System.Drawing.Size(15, 14);
            this.CB_Usuario.TabIndex = 3;
            this.CB_Usuario.UseVisualStyleBackColor = true;
            // 
            // CB_FechaNomina
            // 
            this.CB_FechaNomina.AutoSize = true;
            this.CB_FechaNomina.Location = new System.Drawing.Point(17, 85);
            this.CB_FechaNomina.Name = "CB_FechaNomina";
            this.CB_FechaNomina.Size = new System.Drawing.Size(15, 14);
            this.CB_FechaNomina.TabIndex = 2;
            this.CB_FechaNomina.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominas";
            // 
            // B_GenerarNomina
            // 
            this.B_GenerarNomina.Location = new System.Drawing.Point(3, 226);
            this.B_GenerarNomina.Name = "B_GenerarNomina";
            this.B_GenerarNomina.Size = new System.Drawing.Size(96, 23);
            this.B_GenerarNomina.TabIndex = 1;
            this.B_GenerarNomina.Text = "Generar Nomina";
            this.B_GenerarNomina.UseVisualStyleBackColor = true;
            this.B_GenerarNomina.Click += new System.EventHandler(this.B_GenerarNomina_Click);
            // 
            // B_Guardar
            // 
            this.B_Guardar.Location = new System.Drawing.Point(288, 226);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(96, 23);
            this.B_Guardar.TabIndex = 2;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = true;
            this.B_Guardar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.B_Guardar);
            this.panel2.Controls.Add(this.B_GenerarNomina);
            this.panel2.Location = new System.Drawing.Point(9, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 258);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 175);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mantenimiento_de__nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mantenimiento_de__nomina";
            this.Text = "Mantenimiento_de__nomina";
            this.Load += new System.EventHandler(this.Mantenimiento_de__nomina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBX_Estatus;
        private System.Windows.Forms.DateTimePicker DTP_FechaNomina;
        private System.Windows.Forms.TextBox T_Dollar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_Estatus;
        private System.Windows.Forms.CheckBox CB_Usuario;
        private System.Windows.Forms.CheckBox CB_FechaNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_GenerarNomina;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}