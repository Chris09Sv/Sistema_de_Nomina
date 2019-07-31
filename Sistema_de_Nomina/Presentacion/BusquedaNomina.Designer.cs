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
            this.B_Salir = new System.Windows.Forms.Button();
            this.B_verNomina = new System.Windows.Forms.Button();
            this.b_volver = new System.Windows.Forms.Button();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrupoMostrarNomina = new System.Windows.Forms.GroupBox();
            this.Seguro = new System.Windows.Forms.Label();
            this.AFP = new System.Windows.Forms.Label();
            this.SRL = new System.Windows.Forms.Label();
            this.Infotep = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrupoMostrarNomina.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.B_Salir);
            this.panel1.Controls.Add(this.B_verNomina);
            this.panel1.Controls.Add(this.b_volver);
            this.panel1.Controls.Add(this.B_Eliminar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 147);
            this.panel1.TabIndex = 0;
            // 
            // B_Salir
            // 
            this.B_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(60)))), ((int)(((byte)(136)))));
            this.B_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(60)))), ((int)(((byte)(136)))));
            this.B_Salir.FlatAppearance.BorderSize = 0;
            this.B_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.B_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Salir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Salir.ForeColor = System.Drawing.Color.White;
            this.B_Salir.Location = new System.Drawing.Point(882, 102);
            this.B_Salir.Name = "B_Salir";
            this.B_Salir.Size = new System.Drawing.Size(179, 30);
            this.B_Salir.TabIndex = 138;
            this.B_Salir.Text = "Salir";
            this.B_Salir.UseVisualStyleBackColor = false;
            this.B_Salir.Click += new System.EventHandler(this.B_Salir_Click);
            // 
            // B_verNomina
            // 
            this.B_verNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(60)))), ((int)(((byte)(136)))));
            this.B_verNomina.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(60)))), ((int)(((byte)(136)))));
            this.B_verNomina.FlatAppearance.BorderSize = 0;
            this.B_verNomina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.B_verNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_verNomina.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_verNomina.ForeColor = System.Drawing.Color.White;
            this.B_verNomina.Location = new System.Drawing.Point(653, 102);
            this.B_verNomina.Name = "B_verNomina";
            this.B_verNomina.Size = new System.Drawing.Size(179, 30);
            this.B_verNomina.TabIndex = 137;
            this.B_verNomina.Text = "Ver Nomina";
            this.B_verNomina.UseVisualStyleBackColor = false;
            this.B_verNomina.Click += new System.EventHandler(this.Button3_Click);
            // 
            // b_volver
            // 
            this.b_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(60)))), ((int)(((byte)(136)))));
            this.b_volver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(60)))), ((int)(((byte)(136)))));
            this.b_volver.FlatAppearance.BorderSize = 0;
            this.b_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.b_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_volver.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_volver.ForeColor = System.Drawing.Color.White;
            this.b_volver.Location = new System.Drawing.Point(242, 102);
            this.b_volver.Name = "b_volver";
            this.b_volver.Size = new System.Drawing.Size(179, 30);
            this.b_volver.TabIndex = 136;
            this.b_volver.Text = "Volver";
            this.b_volver.UseVisualStyleBackColor = false;
            this.b_volver.Click += new System.EventHandler(this.B_Volver_Click);
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(60)))), ((int)(((byte)(136)))));
            this.B_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(60)))), ((int)(((byte)(136)))));
            this.B_Eliminar.FlatAppearance.BorderSize = 0;
            this.B_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.B_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Eliminar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Eliminar.ForeColor = System.Drawing.Color.White;
            this.B_Eliminar.Location = new System.Drawing.Point(20, 102);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(179, 30);
            this.B_Eliminar.TabIndex = 135;
            this.B_Eliminar.Text = "Reporte a la TSS";
            this.B_Eliminar.UseVisualStyleBackColor = false;
            this.B_Eliminar.Click += new System.EventHandler(this.Button2_Click);
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 434);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // GrupoMostrarNomina
            // 
            this.GrupoMostrarNomina.Controls.Add(this.panel2);
            this.GrupoMostrarNomina.Controls.Add(this.dataGridView1);
            this.GrupoMostrarNomina.Controls.Add(this.panel1);
            this.GrupoMostrarNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrupoMostrarNomina.Location = new System.Drawing.Point(0, 0);
            this.GrupoMostrarNomina.Name = "GrupoMostrarNomina";
            this.GrupoMostrarNomina.Size = new System.Drawing.Size(1200, 600);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.menuStrip1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 549);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 48);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // BusquedaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Infotep);
            this.Controls.Add(this.SRL);
            this.Controls.Add(this.AFP);
            this.Controls.Add(this.Seguro);
            this.Controls.Add(this.GrupoMostrarNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusquedaNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BusquedaNomina";
            this.Load += new System.EventHandler(this.BusquedaNomina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrupoMostrarNomina.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GrupoMostrarNomina;
        private System.Windows.Forms.Label Seguro;
        private System.Windows.Forms.Label AFP;
        private System.Windows.Forms.Label SRL;
        private System.Windows.Forms.Label Infotep;
        private System.Windows.Forms.Button B_Salir;
        private System.Windows.Forms.Button B_verNomina;
        private System.Windows.Forms.Button b_volver;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
    }
}