namespace Sistema_de_Nomina.Presentacion
{
    partial class BusquedaNomina
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.B_Volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrupoMostrarNomina = new System.Windows.Forms.GroupBox();
            this.Seguro = new System.Windows.Forms.Label();
            this.AFP = new System.Windows.Forms.Label();
            this.SRL = new System.Windows.Forms.Label();
            this.Infotep = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.B_Volver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 147);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ver nomina";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(922, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reporte a la TSS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // B_Volver
            // 
            this.B_Volver.Location = new System.Drawing.Point(273, 102);
            this.B_Volver.Name = "B_Volver";
            this.B_Volver.Size = new System.Drawing.Size(143, 23);
            this.B_Volver.TabIndex = 9;
            this.B_Volver.Text = "Volver";
            this.B_Volver.UseVisualStyleBackColor = true;
            this.B_Volver.Click += new System.EventHandler(this.B_Volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1078, 273);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // GrupoMostrarNomina
            // 
            this.GrupoMostrarNomina.Location = new System.Drawing.Point(12, 12);
            this.GrupoMostrarNomina.Name = "GrupoMostrarNomina";
            this.GrupoMostrarNomina.Size = new System.Drawing.Size(1035, 426);
            this.GrupoMostrarNomina.TabIndex = 5;
            this.GrupoMostrarNomina.TabStop = false;
            this.GrupoMostrarNomina.Text = "groupBox1";
            // 
            // Seguro
            // 
            this.Seguro.AutoSize = true;
            this.Seguro.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Seguro.ForeColor = System.Drawing.Color.White;
            this.Seguro.Location = new System.Drawing.Point(211, 451);
            this.Seguro.Name = "Seguro";
            this.Seguro.Size = new System.Drawing.Size(0, 20);
            this.Seguro.TabIndex = 6;
            // 
            // AFP
            // 
            this.AFP.AutoSize = true;
            this.AFP.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.AFP.ForeColor = System.Drawing.Color.White;
            this.AFP.Location = new System.Drawing.Point(459, 451);
            this.AFP.Name = "AFP";
            this.AFP.Size = new System.Drawing.Size(0, 20);
            this.AFP.TabIndex = 7;
            // 
            // SRL
            // 
            this.SRL.AutoSize = true;
            this.SRL.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.SRL.ForeColor = System.Drawing.Color.White;
            this.SRL.Location = new System.Drawing.Point(661, 451);
            this.SRL.Name = "SRL";
            this.SRL.Size = new System.Drawing.Size(0, 20);
            this.SRL.TabIndex = 8;
            // 
            // Infotep
            // 
            this.Infotep.AutoSize = true;
            this.Infotep.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Infotep.ForeColor = System.Drawing.Color.White;
            this.Infotep.Location = new System.Drawing.Point(890, 451);
            this.Infotep.Name = "Infotep";
            this.Infotep.Size = new System.Drawing.Size(0, 20);
            this.Infotep.TabIndex = 9;
            // 
            // BusquedaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1100, 473);
            this.Controls.Add(this.Infotep);
            this.Controls.Add(this.SRL);
            this.Controls.Add(this.AFP);
            this.Controls.Add(this.Seguro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrupoMostrarNomina);
            this.Name = "BusquedaNomina";
            this.Text = "BusquedaNomina";
            this.Load += new System.EventHandler(this.BusquedaNomina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GrupoMostrarNomina;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button B_Volver;
        private System.Windows.Forms.Label Seguro;
        private System.Windows.Forms.Label AFP;
        private System.Windows.Forms.Label SRL;
        private System.Windows.Forms.Label Infotep;
    }
}