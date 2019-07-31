namespace Sistema_de_Nomina.Presentacion
{
    partial class Cuentas_por_cobrar
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
            this.G_Busqueda = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Editar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.T_Buscar = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.G_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // G_Busqueda
            // 
            this.G_Busqueda.Controls.Add(this.button4);
            this.G_Busqueda.Controls.Add(this.button3);
            this.G_Busqueda.Controls.Add(this.button2);
            this.G_Busqueda.Controls.Add(this.button1);
            this.G_Busqueda.Controls.Add(this.comboBox1);
            this.G_Busqueda.Controls.Add(this.B_Eliminar);
            this.G_Busqueda.Controls.Add(this.B_Editar);
            this.G_Busqueda.Controls.Add(this.dataGridView1);
            this.G_Busqueda.Controls.Add(this.T_Buscar);
            this.G_Busqueda.Controls.Add(this.label27);
            this.G_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_Busqueda.Location = new System.Drawing.Point(12, 2);
            this.G_Busqueda.Name = "G_Busqueda";
            this.G_Busqueda.Size = new System.Drawing.Size(994, 436);
            this.G_Busqueda.TabIndex = 61;
            this.G_Busqueda.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 32);
            this.button4.TabIndex = 136;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 32);
            this.button3.TabIndex = 135;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 32);
            this.button2.TabIndex = 134;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 133;
            this.button1.Text = "Ver en Nomina";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Puesto",
            "Apellido"});
            this.comboBox1.Location = new System.Drawing.Point(535, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 132;
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Location = new System.Drawing.Point(104, 460);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.B_Eliminar.TabIndex = 131;
            this.B_Eliminar.Text = "Eliminar";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            // 
            // B_Editar
            // 
            this.B_Editar.Location = new System.Drawing.Point(351, 459);
            this.B_Editar.Name = "B_Editar";
            this.B_Editar.Size = new System.Drawing.Size(75, 23);
            this.B_Editar.TabIndex = 130;
            this.B_Editar.Text = "Editar";
            this.B_Editar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(972, 290);
            this.dataGridView1.TabIndex = 129;
            // 
            // T_Buscar
            // 
            this.T_Buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Buscar.Location = new System.Drawing.Point(121, 44);
            this.T_Buscar.Name = "T_Buscar";
            this.T_Buscar.Size = new System.Drawing.Size(345, 26);
            this.T_Buscar.TabIndex = 128;
            this.T_Buscar.TextChanged += new System.EventHandler(this.T_Buscar_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(13, 51);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 18);
            this.label27.TabIndex = 89;
            this.label27.Text = "Buscar";
            // 
            // Cuentas_por_cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.G_Busqueda);
            this.Name = "Cuentas_por_cobrar";
            this.Text = "Cuentas_por_cobrar";
            this.Load += new System.EventHandler(this.Cuentas_por_cobrar_Load);
            this.G_Busqueda.ResumeLayout(false);
            this.G_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox G_Busqueda;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Button B_Editar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox T_Buscar;
        private System.Windows.Forms.Label label27;
    }
}