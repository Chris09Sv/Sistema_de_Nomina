namespace Sistema_de_Nomina
{
    partial class Form1
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
            this.T_Nombre = new System.Windows.Forms.TextBox();
            this.T_Apellido = new System.Windows.Forms.TextBox();
            this.T_Direccion = new System.Windows.Forms.TextBox();
            this.T_Telefono = new System.Windows.Forms.TextBox();
            this.T_Cedula = new System.Windows.Forms.TextBox();
            this.T_Email = new System.Windows.Forms.TextBox();
            this.T_Puesto = new System.Windows.Forms.TextBox();
            this.T_Sueldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.T_Departamento = new System.Windows.Forms.TextBox();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.T_FechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.T_FechaDeContratacion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // T_Nombre
            // 
            this.T_Nombre.Location = new System.Drawing.Point(93, 58);
            this.T_Nombre.Name = "T_Nombre";
            this.T_Nombre.Size = new System.Drawing.Size(100, 20);
            this.T_Nombre.TabIndex = 0;
            // 
            // T_Apellido
            // 
            this.T_Apellido.Location = new System.Drawing.Point(93, 98);
            this.T_Apellido.Name = "T_Apellido";
            this.T_Apellido.Size = new System.Drawing.Size(100, 20);
            this.T_Apellido.TabIndex = 1;
            // 
            // T_Direccion
            // 
            this.T_Direccion.Location = new System.Drawing.Point(93, 137);
            this.T_Direccion.Name = "T_Direccion";
            this.T_Direccion.Size = new System.Drawing.Size(100, 20);
            this.T_Direccion.TabIndex = 2;
            // 
            // T_Telefono
            // 
            this.T_Telefono.Location = new System.Drawing.Point(93, 250);
            this.T_Telefono.Name = "T_Telefono";
            this.T_Telefono.Size = new System.Drawing.Size(100, 20);
            this.T_Telefono.TabIndex = 3;
            // 
            // T_Cedula
            // 
            this.T_Cedula.Location = new System.Drawing.Point(93, 179);
            this.T_Cedula.Name = "T_Cedula";
            this.T_Cedula.Size = new System.Drawing.Size(100, 20);
            this.T_Cedula.TabIndex = 4;
            // 
            // T_Email
            // 
            this.T_Email.Location = new System.Drawing.Point(545, 128);
            this.T_Email.Name = "T_Email";
            this.T_Email.Size = new System.Drawing.Size(100, 20);
            this.T_Email.TabIndex = 5;
            this.T_Email.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // T_Puesto
            // 
            this.T_Puesto.Location = new System.Drawing.Point(545, 229);
            this.T_Puesto.Name = "T_Puesto";
            this.T_Puesto.Size = new System.Drawing.Size(100, 20);
            this.T_Puesto.TabIndex = 6;
            // 
            // T_Sueldo
            // 
            this.T_Sueldo.Location = new System.Drawing.Point(545, 97);
            this.T_Sueldo.Multiline = true;
            this.T_Sueldo.Name = "T_Sueldo";
            this.T_Sueldo.Size = new System.Drawing.Size(100, 20);
            this.T_Sueldo.TabIndex = 8;
            this.T_Sueldo.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Puesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha de  nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de contratacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sueldo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(465, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Departamento";
            // 
            // T_Departamento
            // 
            this.T_Departamento.Location = new System.Drawing.Point(545, 185);
            this.T_Departamento.Name = "T_Departamento";
            this.T_Departamento.Size = new System.Drawing.Size(100, 20);
            this.T_Departamento.TabIndex = 21;
            // 
            // B_Guardar
            // 
            this.B_Guardar.Location = new System.Drawing.Point(196, 394);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(75, 23);
            this.B_Guardar.TabIndex = 22;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = true;
            this.B_Guardar.Click += new System.EventHandler(this.B_Guardar_Click);
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(378, 394);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_Cancelar.TabIndex = 23;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            // 
            // T_FechaDeNacimiento
            // 
            this.T_FechaDeNacimiento.Location = new System.Drawing.Point(128, 226);
            this.T_FechaDeNacimiento.Name = "T_FechaDeNacimiento";
            this.T_FechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.T_FechaDeNacimiento.TabIndex = 24;
            // 
            // T_FechaDeContratacion
            // 
            this.T_FechaDeContratacion.Location = new System.Drawing.Point(545, 54);
            this.T_FechaDeContratacion.Name = "T_FechaDeContratacion";
            this.T_FechaDeContratacion.Size = new System.Drawing.Size(200, 20);
            this.T_FechaDeContratacion.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.T_FechaDeContratacion);
            this.Controls.Add(this.T_FechaDeNacimiento);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Guardar);
            this.Controls.Add(this.T_Departamento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_Sueldo);
            this.Controls.Add(this.T_Puesto);
            this.Controls.Add(this.T_Email);
            this.Controls.Add(this.T_Cedula);
            this.Controls.Add(this.T_Telefono);
            this.Controls.Add(this.T_Direccion);
            this.Controls.Add(this.T_Apellido);
            this.Controls.Add(this.T_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_Nombre;
        private System.Windows.Forms.TextBox T_Apellido;
        private System.Windows.Forms.TextBox T_Direccion;
        private System.Windows.Forms.TextBox T_Telefono;
        private System.Windows.Forms.TextBox T_Cedula;
        private System.Windows.Forms.TextBox T_Email;
        private System.Windows.Forms.TextBox T_Puesto;
        private System.Windows.Forms.TextBox T_Sueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox T_Departamento;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.DateTimePicker T_FechaDeNacimiento;
        private System.Windows.Forms.DateTimePicker T_FechaDeContratacion;
    }
}

