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
            this.T_Usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Estatus = new System.Windows.Forms.CheckBox();
            this.CB_Usuario = new System.Windows.Forms.CheckBox();
            this.CB_FechaNomina = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_GenerarNomina = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.panel1.Controls.Add(this.T_Usuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CB_Estatus);
            this.panel1.Controls.Add(this.CB_Usuario);
            this.panel1.Controls.Add(this.CB_FechaNomina);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 162);
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
            // T_Usuario
            // 
            this.T_Usuario.Location = new System.Drawing.Point(332, 83);
            this.T_Usuario.Name = "T_Usuario";
            this.T_Usuario.Size = new System.Drawing.Size(136, 20);
            this.T_Usuario.TabIndex = 8;
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
            this.label4.Location = new System.Drawing.Point(283, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario";
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
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(115, 226);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(96, 23);
            this.B_Cancelar.TabIndex = 2;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.B_Cancelar);
            this.panel2.Controls.Add(this.B_GenerarNomina);
            this.panel2.Location = new System.Drawing.Point(9, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 258);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 175);
            this.dataGridView1.TabIndex = 3;
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
        private System.Windows.Forms.TextBox T_Usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_Estatus;
        private System.Windows.Forms.CheckBox CB_Usuario;
        private System.Windows.Forms.CheckBox CB_FechaNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_GenerarNomina;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}