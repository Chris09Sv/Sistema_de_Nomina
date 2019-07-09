namespace Sistema_de_Nomina.Presentacion
{
    partial class MantenimientoDepartamento
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
            this.P_Adm_Departamento = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.T_Id = new System.Windows.Forms.Label();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.T_Departamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.P_Posicion = new System.Windows.Forms.Panel();
            this.T_Posicion = new System.Windows.Forms.TextBox();
            this.T_IDPuesto = new System.Windows.Forms.Label();
            this.C_Departamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.B_Guardar_Puesto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_EditarPosicion = new System.Windows.Forms.Button();
            this.DgvDept = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.G_Dept = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.G_Posiciones = new System.Windows.Forms.GroupBox();
            this.C_FiltroP = new System.Windows.Forms.ComboBox();
            this.T_Buscar_Posicion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DvgPosiciones = new System.Windows.Forms.DataGridView();
            this.Eliminar1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.P_Adm_Departamento.SuspendLayout();
            this.P_Posicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDept)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.G_Dept.SuspendLayout();
            this.G_Posiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgPosiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Adm_Departamento
            // 
            this.P_Adm_Departamento.BackColor = System.Drawing.Color.White;
            this.P_Adm_Departamento.Controls.Add(this.button3);
            this.P_Adm_Departamento.Controls.Add(this.button2);
            this.P_Adm_Departamento.Controls.Add(this.T_Id);
            this.P_Adm_Departamento.Controls.Add(this.B_Cancelar);
            this.P_Adm_Departamento.Controls.Add(this.B_Guardar);
            this.P_Adm_Departamento.Controls.Add(this.T_Departamento);
            this.P_Adm_Departamento.Controls.Add(this.label2);
            this.P_Adm_Departamento.Location = new System.Drawing.Point(0, 27);
            this.P_Adm_Departamento.Name = "P_Adm_Departamento";
            this.P_Adm_Departamento.Size = new System.Drawing.Size(300, 492);
            this.P_Adm_Departamento.TabIndex = 8;
            this.P_Adm_Departamento.Paint += new System.Windows.Forms.PaintEventHandler(this.P_Adm_Departamento_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // T_Id
            // 
            this.T_Id.AutoSize = true;
            this.T_Id.Font = new System.Drawing.Font("Calibri", 16F);
            this.T_Id.Location = new System.Drawing.Point(170, 21);
            this.T_Id.Name = "T_Id";
            this.T_Id.Size = new System.Drawing.Size(0, 27);
            this.T_Id.TabIndex = 14;
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(175, 419);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(104, 23);
            this.B_Cancelar.TabIndex = 13;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            // 
            // B_Guardar
            // 
            this.B_Guardar.Location = new System.Drawing.Point(17, 419);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(104, 23);
            this.B_Guardar.TabIndex = 12;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = true;
            this.B_Guardar.Click += new System.EventHandler(this.B_Guardar_Click);
            // 
            // T_Departamento
            // 
            this.T_Departamento.Font = new System.Drawing.Font("Calibri", 12F);
            this.T_Departamento.Location = new System.Drawing.Point(133, 71);
            this.T_Departamento.Name = "T_Departamento";
            this.T_Departamento.Size = new System.Drawing.Size(147, 27);
            this.T_Departamento.TabIndex = 7;
            this.T_Departamento.TextChanged += new System.EventHandler(this.T_Departamento_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento";
            // 
            // P_Posicion
            // 
            this.P_Posicion.BackColor = System.Drawing.Color.White;
            this.P_Posicion.Controls.Add(this.T_Posicion);
            this.P_Posicion.Controls.Add(this.T_IDPuesto);
            this.P_Posicion.Controls.Add(this.C_Departamento);
            this.P_Posicion.Controls.Add(this.label3);
            this.P_Posicion.Controls.Add(this.button5);
            this.P_Posicion.Controls.Add(this.B_Guardar_Puesto);
            this.P_Posicion.Controls.Add(this.label1);
            this.P_Posicion.Location = new System.Drawing.Point(0, 27);
            this.P_Posicion.Name = "P_Posicion";
            this.P_Posicion.Size = new System.Drawing.Size(300, 492);
            this.P_Posicion.TabIndex = 15;
            // 
            // T_Posicion
            // 
            this.T_Posicion.Font = new System.Drawing.Font("Calibri", 12F);
            this.T_Posicion.Location = new System.Drawing.Point(136, 80);
            this.T_Posicion.Name = "T_Posicion";
            this.T_Posicion.Size = new System.Drawing.Size(147, 27);
            this.T_Posicion.TabIndex = 23;
            // 
            // T_IDPuesto
            // 
            this.T_IDPuesto.AutoSize = true;
            this.T_IDPuesto.Font = new System.Drawing.Font("Calibri", 16F);
            this.T_IDPuesto.Location = new System.Drawing.Point(153, 21);
            this.T_IDPuesto.Name = "T_IDPuesto";
            this.T_IDPuesto.Size = new System.Drawing.Size(0, 27);
            this.T_IDPuesto.TabIndex = 22;
            // 
            // C_Departamento
            // 
            this.C_Departamento.Font = new System.Drawing.Font("Calibri", 12F);
            this.C_Departamento.FormattingEnabled = true;
            this.C_Departamento.Location = new System.Drawing.Point(136, 201);
            this.C_Departamento.Name = "C_Departamento";
            this.C_Departamento.Size = new System.Drawing.Size(147, 27);
            this.C_Departamento.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(4, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Departamento";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(168, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // B_Guardar_Puesto
            // 
            this.B_Guardar_Puesto.Location = new System.Drawing.Point(-1, 427);
            this.B_Guardar_Puesto.Name = "B_Guardar_Puesto";
            this.B_Guardar_Puesto.Size = new System.Drawing.Size(124, 23);
            this.B_Guardar_Puesto.TabIndex = 16;
            this.B_Guardar_Puesto.Text = "Guardar";
            this.B_Guardar_Puesto.UseVisualStyleBackColor = true;
            this.B_Guardar_Puesto.Click += new System.EventHandler(this.B_Guardar_Puesto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(4, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Posicion";
            // 
            // B_EditarPosicion
            // 
            this.B_EditarPosicion.Location = new System.Drawing.Point(206, 424);
            this.B_EditarPosicion.Name = "B_EditarPosicion";
            this.B_EditarPosicion.Size = new System.Drawing.Size(124, 23);
            this.B_EditarPosicion.TabIndex = 24;
            this.B_EditarPosicion.Text = "Editar";
            this.B_EditarPosicion.UseVisualStyleBackColor = true;
            this.B_EditarPosicion.Click += new System.EventHandler(this.B_EditarPosicion_Click);
            // 
            // DgvDept
            // 
            this.DgvDept.AllowUserToAddRows = false;
            this.DgvDept.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DgvDept.Location = new System.Drawing.Point(6, 43);
            this.DgvDept.Name = "DgvDept";
            this.DgvDept.ReadOnly = true;
            this.DgvDept.Size = new System.Drawing.Size(355, 375);
            this.DgvDept.TabIndex = 15;
            this.DgvDept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDept_CellClick);
            this.DgvDept.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDept_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Location = new System.Drawing.Point(83, 424);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(58, 23);
            this.B_Eliminar.TabIndex = 15;
            this.B_Eliminar.Text = "Eliminar";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentosToolStripMenuItem,
            this.puestosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.DepartamentosToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.puestosToolStripMenuItem.Text = "Puestos";
            this.puestosToolStripMenuItem.Click += new System.EventHandler(this.PuestosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // G_Dept
            // 
            this.G_Dept.BackColor = System.Drawing.Color.Purple;
            this.G_Dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.G_Dept.Controls.Add(this.textBox1);
            this.G_Dept.Controls.Add(this.B_EditarPosicion);
            this.G_Dept.Controls.Add(this.B_Eliminar);
            this.G_Dept.Controls.Add(this.DgvDept);
            this.G_Dept.Location = new System.Drawing.Point(320, 27);
            this.G_Dept.Name = "G_Dept";
            this.G_Dept.Size = new System.Drawing.Size(404, 492);
            this.G_Dept.TabIndex = 25;
            this.G_Dept.TabStop = false;
            this.G_Dept.Text = "Departamentos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // G_Posiciones
            // 
            this.G_Posiciones.Controls.Add(this.C_FiltroP);
            this.G_Posiciones.Controls.Add(this.T_Buscar_Posicion);
            this.G_Posiciones.Controls.Add(this.button1);
            this.G_Posiciones.Controls.Add(this.DvgPosiciones);
            this.G_Posiciones.Location = new System.Drawing.Point(320, 27);
            this.G_Posiciones.Name = "G_Posiciones";
            this.G_Posiciones.Size = new System.Drawing.Size(404, 492);
            this.G_Posiciones.TabIndex = 16;
            this.G_Posiciones.TabStop = false;
            this.G_Posiciones.Text = "Posiciones";
            // 
            // C_FiltroP
            // 
            this.C_FiltroP.FormattingEnabled = true;
            this.C_FiltroP.Items.AddRange(new object[] {
            "Puestos",
            "Departamento"});
            this.C_FiltroP.Location = new System.Drawing.Point(6, 12);
            this.C_FiltroP.Name = "C_FiltroP";
            this.C_FiltroP.Size = new System.Drawing.Size(121, 21);
            this.C_FiltroP.TabIndex = 21;
            this.C_FiltroP.Text = "Departamentos";
            // 
            // T_Buscar_Posicion
            // 
            this.T_Buscar_Posicion.Location = new System.Drawing.Point(206, 12);
            this.T_Buscar_Posicion.Name = "T_Buscar_Posicion";
            this.T_Buscar_Posicion.Size = new System.Drawing.Size(100, 20);
            this.T_Buscar_Posicion.TabIndex = 20;
            this.T_Buscar_Posicion.TextChanged += new System.EventHandler(this.T_Buscar_Posicion_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DvgPosiciones
            // 
            this.DvgPosiciones.AllowUserToAddRows = false;
            this.DvgPosiciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DvgPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar1});
            this.DvgPosiciones.Location = new System.Drawing.Point(2, 38);
            this.DvgPosiciones.Name = "DvgPosiciones";
            this.DvgPosiciones.ReadOnly = true;
            this.DvgPosiciones.Size = new System.Drawing.Size(396, 375);
            this.DvgPosiciones.TabIndex = 18;
            this.DvgPosiciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgPosiciones_CellClick_1);
            this.DvgPosiciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgPosiciones_CellContentClick);
            // 
            // Eliminar1
            // 
            this.Eliminar1.HeaderText = "Elliminar";
            this.Eliminar1.Name = "Eliminar1";
            this.Eliminar1.ReadOnly = true;
            this.Eliminar1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MantenimientoDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(724, 549);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.P_Posicion);
            this.Controls.Add(this.P_Adm_Departamento);
            this.Controls.Add(this.G_Posiciones);
            this.Controls.Add(this.G_Dept);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MantenimientoDepartamento";
            this.Text = "MantenimientoDepartamento";
            this.Load += new System.EventHandler(this.MantenimientoDepartamento_Load);
            this.P_Adm_Departamento.ResumeLayout(false);
            this.P_Adm_Departamento.PerformLayout();
            this.P_Posicion.ResumeLayout(false);
            this.P_Posicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDept)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.G_Dept.ResumeLayout(false);
            this.G_Dept.PerformLayout();
            this.G_Posiciones.ResumeLayout(false);
            this.G_Posiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgPosiciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel P_Adm_Departamento;
        private System.Windows.Forms.Label T_Id;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.TextBox T_Departamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel P_Posicion;
        private System.Windows.Forms.Label T_IDPuesto;
        private System.Windows.Forms.ComboBox C_Departamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button B_Guardar_Puesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvDept;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.TextBox T_Posicion;
        private System.Windows.Forms.GroupBox G_Dept;
        private System.Windows.Forms.GroupBox G_Posiciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DvgPosiciones;
        private System.Windows.Forms.Button B_EditarPosicion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox T_Buscar_Posicion;
        private System.Windows.Forms.ComboBox C_FiltroP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar1;
    }
}