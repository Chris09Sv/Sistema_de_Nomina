namespace Sistema_de_Nomina.Presentacion
{
    partial class Vista
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
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.T_Id = new System.Windows.Forms.TextBox();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.T_Nombre = new System.Windows.Forms.TextBox();
            this.T_Apellido = new System.Windows.Forms.TextBox();
            this.T_Direccion = new System.Windows.Forms.TextBox();
            this.T_Telefono = new System.Windows.Forms.TextBox();
            this.T_Cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.T_FechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.T_Email = new System.Windows.Forms.TextBox();
            this.T_Puesto = new System.Windows.Forms.TextBox();
            this.T_Sueldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.T_Departamento = new System.Windows.Forms.TextBox();
            this.T_FechaDeContratacion = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Location = new System.Drawing.Point(316, 29);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.Size = new System.Drawing.Size(472, 398);
            this.DgvEmpleados.TabIndex = 0;
            this.DgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleados_CellClick);
            this.DgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleados_CellContentClick);
            // 
            // T_Id
            // 
            this.T_Id.Location = new System.Drawing.Point(87, 3);
            this.T_Id.Name = "T_Id";
            this.T_Id.Size = new System.Drawing.Size(100, 20);
            this.T_Id.TabIndex = 47;
            this.T_Id.Visible = false;
            // 
            // B_Guardar
            // 
            this.B_Guardar.Location = new System.Drawing.Point(5, 434);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(75, 23);
            this.B_Guardar.TabIndex = 48;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = true;
            this.B_Guardar.Click += new System.EventHandler(this.B_Guardar_Click);
            // 
            // T_Nombre
            // 
            this.T_Nombre.Location = new System.Drawing.Point(74, 12);
            this.T_Nombre.Name = "T_Nombre";
            this.T_Nombre.Size = new System.Drawing.Size(100, 20);
            this.T_Nombre.TabIndex = 25;
            // 
            // T_Apellido
            // 
            this.T_Apellido.Location = new System.Drawing.Point(74, 52);
            this.T_Apellido.Name = "T_Apellido";
            this.T_Apellido.Size = new System.Drawing.Size(100, 20);
            this.T_Apellido.TabIndex = 26;
            // 
            // T_Direccion
            // 
            this.T_Direccion.Location = new System.Drawing.Point(74, 91);
            this.T_Direccion.Name = "T_Direccion";
            this.T_Direccion.Size = new System.Drawing.Size(100, 20);
            this.T_Direccion.TabIndex = 27;
            // 
            // T_Telefono
            // 
            this.T_Telefono.Location = new System.Drawing.Point(74, 204);
            this.T_Telefono.Name = "T_Telefono";
            this.T_Telefono.Size = new System.Drawing.Size(100, 20);
            this.T_Telefono.TabIndex = 28;
            // 
            // T_Cedula
            // 
            this.T_Cedula.Location = new System.Drawing.Point(74, 117);
            this.T_Cedula.Name = "T_Cedula";
            this.T_Cedula.Size = new System.Drawing.Size(100, 20);
            this.T_Cedula.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Fecha de  nacimiento";
            // 
            // T_FechaDeNacimiento
            // 
            this.T_FechaDeNacimiento.Location = new System.Drawing.Point(108, 143);
            this.T_FechaDeNacimiento.Name = "T_FechaDeNacimiento";
            this.T_FechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.T_FechaDeNacimiento.TabIndex = 36;
            // 
            // T_Email
            // 
            this.T_Email.Location = new System.Drawing.Point(108, 318);
            this.T_Email.Name = "T_Email";
            this.T_Email.Size = new System.Drawing.Size(100, 20);
            this.T_Email.TabIndex = 37;
            // 
            // T_Puesto
            // 
            this.T_Puesto.Location = new System.Drawing.Point(74, 168);
            this.T_Puesto.Name = "T_Puesto";
            this.T_Puesto.Size = new System.Drawing.Size(100, 20);
            this.T_Puesto.TabIndex = 38;
            // 
            // T_Sueldo
            // 
            this.T_Sueldo.Location = new System.Drawing.Point(108, 287);
            this.T_Sueldo.Name = "T_Sueldo";
            this.T_Sueldo.Size = new System.Drawing.Size(100, 20);
            this.T_Sueldo.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Puesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Fecha de contratacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Sueldo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Departamento";
            // 
            // T_Departamento
            // 
            this.T_Departamento.Location = new System.Drawing.Point(108, 375);
            this.T_Departamento.Name = "T_Departamento";
            this.T_Departamento.Size = new System.Drawing.Size(100, 20);
            this.T_Departamento.TabIndex = 45;
            // 
            // T_FechaDeContratacion
            // 
            this.T_FechaDeContratacion.Location = new System.Drawing.Point(108, 244);
            this.T_FechaDeContratacion.Name = "T_FechaDeContratacion";
            this.T_FechaDeContratacion.Size = new System.Drawing.Size(200, 20);
            this.T_FechaDeContratacion.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.T_FechaDeContratacion);
            this.panel1.Controls.Add(this.T_Departamento);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.T_Sueldo);
            this.panel1.Controls.Add(this.T_Puesto);
            this.panel1.Controls.Add(this.T_Email);
            this.panel1.Controls.Add(this.T_FechaDeNacimiento);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.T_Cedula);
            this.panel1.Controls.Add(this.T_Telefono);
            this.panel1.Controls.Add(this.T_Direccion);
            this.panel1.Controls.Add(this.T_Apellido);
            this.panel1.Controls.Add(this.T_Nombre);
            this.panel1.Location = new System.Drawing.Point(13, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 398);
            this.panel1.TabIndex = 1;
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.B_Guardar);
            this.Controls.Add(this.T_Id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvEmpleados);
            this.Name = "Vista";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.TextBox T_Id;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.TextBox T_Nombre;
        private System.Windows.Forms.TextBox T_Apellido;
        private System.Windows.Forms.TextBox T_Direccion;
        private System.Windows.Forms.TextBox T_Telefono;
        private System.Windows.Forms.TextBox T_Cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker T_FechaDeNacimiento;
        private System.Windows.Forms.TextBox T_Email;
        private System.Windows.Forms.TextBox T_Puesto;
        private System.Windows.Forms.TextBox T_Sueldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox T_Departamento;
        private System.Windows.Forms.DateTimePicker T_FechaDeContratacion;
        private System.Windows.Forms.Panel panel1;
    }
}