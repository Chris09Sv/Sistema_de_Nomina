namespace Sistema_de_Nomina.Presentacion
{
    partial class CalculoPrestaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPFinal = new System.Windows.Forms.DateTimePicker();
            this.CBPreaviso = new System.Windows.Forms.CheckBox();
            this.CBCesantia = new System.Windows.Forms.CheckBox();
            this.CBSalarioNavidad = new System.Windows.Forms.CheckBox();
            this.CBVacaciones = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CBVacaciones);
            this.panel1.Controls.Add(this.CBSalarioNavidad);
            this.panel1.Controls.Add(this.CBCesantia);
            this.panel1.Controls.Add(this.CBPreaviso);
            this.panel1.Controls.Add(this.DTPFinal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DTPInicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Inicio";
            // 
            // DTPInicio
            // 
            this.DTPInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPInicio.Location = new System.Drawing.Point(134, 52);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(103, 20);
            this.DTPInicio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Salida";
            // 
            // DTPFinal
            // 
            this.DTPFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFinal.Location = new System.Drawing.Point(134, 103);
            this.DTPFinal.Name = "DTPFinal";
            this.DTPFinal.Size = new System.Drawing.Size(103, 20);
            this.DTPFinal.TabIndex = 3;
            // 
            // CBPreaviso
            // 
            this.CBPreaviso.AutoSize = true;
            this.CBPreaviso.Location = new System.Drawing.Point(30, 174);
            this.CBPreaviso.Name = "CBPreaviso";
            this.CBPreaviso.Size = new System.Drawing.Size(95, 17);
            this.CBPreaviso.TabIndex = 4;
            this.CBPreaviso.Text = "Tuvo Preaviso";
            this.CBPreaviso.UseVisualStyleBackColor = true;
            // 
            // CBCesantia
            // 
            this.CBCesantia.AutoSize = true;
            this.CBCesantia.Location = new System.Drawing.Point(30, 220);
            this.CBCesantia.Name = "CBCesantia";
            this.CBCesantia.Size = new System.Drawing.Size(157, 17);
            this.CBCesantia.TabIndex = 5;
            this.CBCesantia.Text = "Incluir el Auxilio de Cesantia";
            this.CBCesantia.UseVisualStyleBackColor = true;
            // 
            // CBSalarioNavidad
            // 
            this.CBSalarioNavidad.AutoSize = true;
            this.CBSalarioNavidad.Location = new System.Drawing.Point(30, 310);
            this.CBSalarioNavidad.Name = "CBSalarioNavidad";
            this.CBSalarioNavidad.Size = new System.Drawing.Size(189, 17);
            this.CBSalarioNavidad.TabIndex = 6;
            this.CBSalarioNavidad.Text = "Desea incluír el salario de navidad";
            this.CBSalarioNavidad.UseVisualStyleBackColor = true;
            // 
            // CBVacaciones
            // 
            this.CBVacaciones.AutoSize = true;
            this.CBVacaciones.Location = new System.Drawing.Point(30, 265);
            this.CBVacaciones.Name = "CBVacaciones";
            this.CBVacaciones.Size = new System.Drawing.Size(182, 17);
            this.CBVacaciones.TabIndex = 7;
            this.CBVacaciones.Text = "Recibió vacaciones el último año";
            this.CBVacaciones.UseVisualStyleBackColor = true;
            // 
            // CalculoPrestaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CalculoPrestaciones";
            this.Text = "CalculoPrestaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CBVacaciones;
        private System.Windows.Forms.CheckBox CBSalarioNavidad;
        private System.Windows.Forms.CheckBox CBCesantia;
        private System.Windows.Forms.CheckBox CBPreaviso;
        private System.Windows.Forms.DateTimePicker DTPFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.Label label1;
    }
}