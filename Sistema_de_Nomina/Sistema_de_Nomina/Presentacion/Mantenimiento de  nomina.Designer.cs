﻿namespace Sistema_de_Nomina.Presentacion
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
            this.B_Guardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Nomina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.T_Dollar = new System.Windows.Forms.TextBox();
            this.DTP_FechaNomina = new System.Windows.Forms.DateTimePicker();
            this.B_GenerarNomina = new System.Windows.Forms.Button();
            this.CBX_Estatus = new System.Windows.Forms.ComboBox();
            this.T_Usuario = new System.Windows.Forms.TextBox();
            this.t_IdNomina = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Guardar
            // 
            this.B_Guardar.Location = new System.Drawing.Point(17, 346);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(96, 23);
            this.B_Guardar.TabIndex = 2;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = true;
            this.B_Guardar.Click += new System.EventHandler(this.B_Guardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.B_Guardar);
            this.panel2.Location = new System.Drawing.Point(9, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 381);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(858, 271);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Impuesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Impuesto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            // Id_Nomina
            // 
            this.Id_Nomina.AutoSize = true;
            this.Id_Nomina.Location = new System.Drawing.Point(14, 41);
            this.Id_Nomina.Name = "Id_Nomina";
            this.Id_Nomina.Size = new System.Drawing.Size(0, 13);
            this.Id_Nomina.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Nomina";
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
            // T_Dollar
            // 
            this.T_Dollar.Location = new System.Drawing.Point(227, 13);
            this.T_Dollar.Name = "T_Dollar";
            this.T_Dollar.Size = new System.Drawing.Size(136, 20);
            this.T_Dollar.TabIndex = 8;
            // 
            // DTP_FechaNomina
            // 
            this.DTP_FechaNomina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FechaNomina.Location = new System.Drawing.Point(598, 13);
            this.DTP_FechaNomina.Name = "DTP_FechaNomina";
            this.DTP_FechaNomina.Size = new System.Drawing.Size(89, 20);
            this.DTP_FechaNomina.TabIndex = 9;
            // 
            // B_GenerarNomina
            // 
            this.B_GenerarNomina.Location = new System.Drawing.Point(13, 63);
            this.B_GenerarNomina.Name = "B_GenerarNomina";
            this.B_GenerarNomina.Size = new System.Drawing.Size(96, 23);
            this.B_GenerarNomina.TabIndex = 1;
            this.B_GenerarNomina.Text = "Generar Nomina";
            this.B_GenerarNomina.UseVisualStyleBackColor = true;
            this.B_GenerarNomina.Click += new System.EventHandler(this.B_GenerarNomina_Click);
            // 
            // CBX_Estatus
            // 
            this.CBX_Estatus.FormattingEnabled = true;
            this.CBX_Estatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBX_Estatus.Location = new System.Drawing.Point(581, 63);
            this.CBX_Estatus.Name = "CBX_Estatus";
            this.CBX_Estatus.Size = new System.Drawing.Size(121, 21);
            this.CBX_Estatus.TabIndex = 10;
            this.CBX_Estatus.Text = "Pendiente";
            // 
            // T_Usuario
            // 
            this.T_Usuario.Location = new System.Drawing.Point(227, 64);
            this.T_Usuario.Name = "T_Usuario";
            this.T_Usuario.Size = new System.Drawing.Size(136, 20);
            this.T_Usuario.TabIndex = 11;
            this.T_Usuario.Text = "1";
            // 
            // t_IdNomina
            // 
            this.t_IdNomina.Enabled = false;
            this.t_IdNomina.Location = new System.Drawing.Point(68, 9);
            this.t_IdNomina.Name = "t_IdNomina";
            this.t_IdNomina.Size = new System.Drawing.Size(41, 20);
            this.t_IdNomina.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.t_IdNomina);
            this.panel1.Controls.Add(this.T_Usuario);
            this.panel1.Controls.Add(this.CBX_Estatus);
            this.panel1.Controls.Add(this.B_GenerarNomina);
            this.panel1.Controls.Add(this.DTP_FechaNomina);
            this.panel1.Controls.Add(this.T_Dollar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Id_Nomina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 95);
            this.panel1.TabIndex = 1;
            // 
            // Mantenimiento_de__nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(879, 539);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mantenimiento_de__nomina";
            this.Text = "Mantenimiento_de__nomina";
            this.Load += new System.EventHandler(this.Mantenimiento_de__nomina_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Id_Nomina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox T_Dollar;
        private System.Windows.Forms.DateTimePicker DTP_FechaNomina;
        private System.Windows.Forms.Button B_GenerarNomina;
        private System.Windows.Forms.ComboBox CBX_Estatus;
        private System.Windows.Forms.TextBox T_Usuario;
        private System.Windows.Forms.TextBox t_IdNomina;
        private System.Windows.Forms.Panel panel1;
    }
}