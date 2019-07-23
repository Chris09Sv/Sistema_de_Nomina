namespace Sistema_de_Nomina.Presentacion
{
    partial class MantenimientoEmpleado
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
            this.G_Empleado = new System.Windows.Forms.GroupBox();
            this.T_EstadoCivil = new System.Windows.Forms.ComboBox();
            this.T_Status = new System.Windows.Forms.ComboBox();
            this.T_NoCuenta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.C_Puesto = new System.Windows.Forms.ComboBox();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.DTP_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.DTP_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.T_Direccion = new System.Windows.Forms.TextBox();
            this.T_Correo = new System.Windows.Forms.TextBox();
            this.T_Apellido = new System.Windows.Forms.TextBox();
            this.T_Salario = new System.Windows.Forms.TextBox();
            this.T_Telefono = new System.Windows.Forms.TextBox();
            this.T_Cedula = new System.Windows.Forms.TextBox();
            this.T_Nombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.BusquedaEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.G_Busqueda = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Editar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.T_Buscar = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.G_Empleado.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.G_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // G_Empleado
            // 
            this.G_Empleado.BackColor = System.Drawing.Color.White;
            this.G_Empleado.Controls.Add(this.T_EstadoCivil);
            this.G_Empleado.Controls.Add(this.T_Status);
            this.G_Empleado.Controls.Add(this.T_NoCuenta);
            this.G_Empleado.Controls.Add(this.label14);
            this.G_Empleado.Controls.Add(this.lbl_id);
            this.G_Empleado.Controls.Add(this.C_Puesto);
            this.G_Empleado.Controls.Add(this.B_Cancelar);
            this.G_Empleado.Controls.Add(this.B_Guardar);
            this.G_Empleado.Controls.Add(this.DTP_FechaNacimiento);
            this.G_Empleado.Controls.Add(this.DTP_FechaIngreso);
            this.G_Empleado.Controls.Add(this.T_Direccion);
            this.G_Empleado.Controls.Add(this.T_Correo);
            this.G_Empleado.Controls.Add(this.T_Apellido);
            this.G_Empleado.Controls.Add(this.T_Salario);
            this.G_Empleado.Controls.Add(this.T_Telefono);
            this.G_Empleado.Controls.Add(this.T_Cedula);
            this.G_Empleado.Controls.Add(this.T_Nombre);
            this.G_Empleado.Controls.Add(this.label12);
            this.G_Empleado.Controls.Add(this.label13);
            this.G_Empleado.Controls.Add(this.label10);
            this.G_Empleado.Controls.Add(this.label11);
            this.G_Empleado.Controls.Add(this.label8);
            this.G_Empleado.Controls.Add(this.label9);
            this.G_Empleado.Controls.Add(this.label6);
            this.G_Empleado.Controls.Add(this.label7);
            this.G_Empleado.Controls.Add(this.label4);
            this.G_Empleado.Controls.Add(this.label5);
            this.G_Empleado.Controls.Add(this.label3);
            this.G_Empleado.Controls.Add(this.label2);
            this.G_Empleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_Empleado.Location = new System.Drawing.Point(0, 31);
            this.G_Empleado.Name = "G_Empleado";
            this.G_Empleado.Size = new System.Drawing.Size(815, 501);
            this.G_Empleado.TabIndex = 0;
            this.G_Empleado.TabStop = false;
            this.G_Empleado.Visible = false;
            this.G_Empleado.Enter += new System.EventHandler(this.G_Empleado_Enter);
            // 
            // T_EstadoCivil
            // 
            this.T_EstadoCivil.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.T_EstadoCivil.FormattingEnabled = true;
            this.T_EstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Otro",
            "Union libre"});
            this.T_EstadoCivil.Location = new System.Drawing.Point(168, 226);
            this.T_EstadoCivil.Name = "T_EstadoCivil";
            this.T_EstadoCivil.Size = new System.Drawing.Size(201, 28);
            this.T_EstadoCivil.TabIndex = 65;
            this.T_EstadoCivil.Text = "Soltero/a";
            // 
            // T_Status
            // 
            this.T_Status.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.T_Status.FormattingEnabled = true;
            this.T_Status.Location = new System.Drawing.Point(633, 421);
            this.T_Status.Name = "T_Status";
            this.T_Status.Size = new System.Drawing.Size(105, 28);
            this.T_Status.TabIndex = 64;
            this.T_Status.Text = "Activo";
            this.T_Status.Visible = false;
            // 
            // T_NoCuenta
            // 
            this.T_NoCuenta.Location = new System.Drawing.Point(559, 359);
            this.T_NoCuenta.Name = "T_NoCuenta";
            this.T_NoCuenta.Size = new System.Drawing.Size(201, 26);
            this.T_NoCuenta.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(433, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 16);
            this.label14.TabIndex = 61;
            this.label14.Text = "Numero de cuenta";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(107, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 20);
            this.lbl_id.TabIndex = 60;
            // 
            // C_Puesto
            // 
            this.C_Puesto.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.C_Puesto.FormattingEnabled = true;
            this.C_Puesto.Location = new System.Drawing.Point(559, 101);
            this.C_Puesto.Name = "C_Puesto";
            this.C_Puesto.Size = new System.Drawing.Size(201, 28);
            this.C_Puesto.TabIndex = 58;
            this.C_Puesto.Text = "Indique la posicion";
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.BackColor = System.Drawing.Color.Purple;
            this.B_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Cancelar.ForeColor = System.Drawing.Color.White;
            this.B_Cancelar.Location = new System.Drawing.Point(433, 419);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(90, 30);
            this.B_Cancelar.TabIndex = 56;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = false;
            // 
            // B_Guardar
            // 
            this.B_Guardar.BackColor = System.Drawing.Color.Purple;
            this.B_Guardar.ForeColor = System.Drawing.Color.White;
            this.B_Guardar.Location = new System.Drawing.Point(202, 419);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(90, 30);
            this.B_Guardar.TabIndex = 54;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = false;
            this.B_Guardar.Click += new System.EventHandler(this.B_Guardar_Click);
            // 
            // DTP_FechaNacimiento
            // 
            this.DTP_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FechaNacimiento.Location = new System.Drawing.Point(168, 291);
            this.DTP_FechaNacimiento.Name = "DTP_FechaNacimiento";
            this.DTP_FechaNacimiento.Size = new System.Drawing.Size(201, 26);
            this.DTP_FechaNacimiento.TabIndex = 52;
            // 
            // DTP_FechaIngreso
            // 
            this.DTP_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FechaIngreso.Location = new System.Drawing.Point(559, 295);
            this.DTP_FechaIngreso.Name = "DTP_FechaIngreso";
            this.DTP_FechaIngreso.Size = new System.Drawing.Size(201, 26);
            this.DTP_FechaIngreso.TabIndex = 50;
            // 
            // T_Direccion
            // 
            this.T_Direccion.Location = new System.Drawing.Point(559, 231);
            this.T_Direccion.Name = "T_Direccion";
            this.T_Direccion.Size = new System.Drawing.Size(201, 26);
            this.T_Direccion.TabIndex = 49;
            // 
            // T_Correo
            // 
            this.T_Correo.Location = new System.Drawing.Point(559, 167);
            this.T_Correo.Name = "T_Correo";
            this.T_Correo.Size = new System.Drawing.Size(201, 26);
            this.T_Correo.TabIndex = 48;
            this.T_Correo.TextChanged += new System.EventHandler(this.T_Correo_TextChanged);
            // 
            // T_Apellido
            // 
            this.T_Apellido.Location = new System.Drawing.Point(559, 35);
            this.T_Apellido.Name = "T_Apellido";
            this.T_Apellido.Size = new System.Drawing.Size(201, 26);
            this.T_Apellido.TabIndex = 46;
            this.T_Apellido.TextChanged += new System.EventHandler(this.T_Apellido_TextChanged);
            // 
            // T_Salario
            // 
            this.T_Salario.Location = new System.Drawing.Point(168, 355);
            this.T_Salario.Name = "T_Salario";
            this.T_Salario.Size = new System.Drawing.Size(201, 26);
            this.T_Salario.TabIndex = 45;
            // 
            // T_Telefono
            // 
            this.T_Telefono.Location = new System.Drawing.Point(168, 162);
            this.T_Telefono.Name = "T_Telefono";
            this.T_Telefono.Size = new System.Drawing.Size(201, 26);
            this.T_Telefono.TabIndex = 43;
            // 
            // T_Cedula
            // 
            this.T_Cedula.Location = new System.Drawing.Point(168, 97);
            this.T_Cedula.Name = "T_Cedula";
            this.T_Cedula.Size = new System.Drawing.Size(201, 26);
            this.T_Cedula.TabIndex = 42;
            // 
            // T_Nombre
            // 
            this.T_Nombre.Location = new System.Drawing.Point(168, 34);
            this.T_Nombre.Name = "T_Nombre";
            this.T_Nombre.Size = new System.Drawing.Size(201, 26);
            this.T_Nombre.TabIndex = 41;
            this.T_Nombre.TextChanged += new System.EventHandler(this.T_Nombre_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(430, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Fecha de Ingreso";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(556, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Estado";
            this.label13.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(430, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Correo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(430, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(430, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Posicion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Estado Civil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Empleados,
            this.BusquedaEmpleado,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Empleados
            // 
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(120, 24);
            this.Empleados.Text = "Nuevo Empleado";
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // BusquedaEmpleado
            // 
            this.BusquedaEmpleado.Name = "BusquedaEmpleado";
            this.BusquedaEmpleado.Size = new System.Drawing.Size(131, 24);
            this.BusquedaEmpleado.Text = "Buscar Empleados";
            this.BusquedaEmpleado.Click += new System.EventHandler(this.BusquedaEmpleado_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // G_Busqueda
            // 
            this.G_Busqueda.Controls.Add(this.button1);
            this.G_Busqueda.Controls.Add(this.comboBox1);
            this.G_Busqueda.Controls.Add(this.B_Eliminar);
            this.G_Busqueda.Controls.Add(this.B_Editar);
            this.G_Busqueda.Controls.Add(this.dataGridView1);
            this.G_Busqueda.Controls.Add(this.T_Buscar);
            this.G_Busqueda.Controls.Add(this.label25);
            this.G_Busqueda.Controls.Add(this.label27);
            this.G_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_Busqueda.Location = new System.Drawing.Point(6, 31);
            this.G_Busqueda.Name = "G_Busqueda";
            this.G_Busqueda.Size = new System.Drawing.Size(792, 489);
            this.G_Busqueda.TabIndex = 59;
            this.G_Busqueda.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Puesto",
            "Departamento",
            "Cedula",
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
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // B_Editar
            // 
            this.B_Editar.Location = new System.Drawing.Point(351, 459);
            this.B_Editar.Name = "B_Editar";
            this.B_Editar.Size = new System.Drawing.Size(75, 23);
            this.B_Editar.TabIndex = 130;
            this.B_Editar.Text = "Editar";
            this.B_Editar.UseVisualStyleBackColor = true;
            this.B_Editar.Click += new System.EventHandler(this.B_Editar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(16, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(770, 319);
            this.dataGridView1.TabIndex = 129;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(16, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(151, 18);
            this.label25.TabIndex = 90;
            this.label25.Text = "Busqueda Avanzada";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 133;
            this.button1.Text = "Ver en Nomina";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MantenimientoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(815, 519);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.G_Busqueda);
            this.Controls.Add(this.G_Empleado);
            this.Name = "MantenimientoEmpleado";
            this.Text = "MantenimientoEmpleado";
            this.Load += new System.EventHandler(this.MantenimientoEmpleado_Load);
            this.G_Empleado.ResumeLayout(false);
            this.G_Empleado.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.G_Busqueda.ResumeLayout(false);
            this.G_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox G_Empleado;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.DateTimePicker DTP_FechaNacimiento;
        private System.Windows.Forms.DateTimePicker DTP_FechaIngreso;
        private System.Windows.Forms.TextBox T_Direccion;
        private System.Windows.Forms.TextBox T_Correo;
        private System.Windows.Forms.TextBox T_Apellido;
        private System.Windows.Forms.TextBox T_Salario;
        private System.Windows.Forms.TextBox T_Telefono;
        private System.Windows.Forms.TextBox T_Cedula;
        private System.Windows.Forms.TextBox T_Nombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox C_Puesto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Empleados;
        private System.Windows.Forms.ToolStripMenuItem BusquedaEmpleado;
        private System.Windows.Forms.GroupBox G_Busqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox T_Buscar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox T_NoCuenta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button B_Editar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox T_Status;
        private System.Windows.Forms.ComboBox T_EstadoCivil;
        private System.Windows.Forms.Button button1;
    }
}