namespace ClinicaSePrice
{
    partial class UcNuevoTurno
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lbDatosPaciente = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbObraSocial = new System.Windows.Forms.Label();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.panelPaciente = new System.Windows.Forms.Panel();
            this.lbBuscarDisponibilidad = new System.Windows.Forms.Label();
            this.lbEstudio = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbProfesionales = new System.Windows.Forms.Label();
            this.btnBuscarDisponibilidad = new System.Windows.Forms.Button();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.cmbEstudio = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.panelBuscarDisponibilidad = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            this.panelPaciente.SuspendLayout();
            this.panelBuscarDisponibilidad.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.panelBotones);
            this.panelContenedor.Controls.Add(this.panelBuscarDisponibilidad);
            this.panelContenedor.Controls.Add(this.panelPaciente);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 44);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(801, 467);
            this.panelContenedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(326, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "NuevoTurno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(801, 44);
            this.panelSuperior.TabIndex = 0;
            // 
            // lbDatosPaciente
            // 
            this.lbDatosPaciente.AutoSize = true;
            this.lbDatosPaciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbDatosPaciente.Location = new System.Drawing.Point(24, 11);
            this.lbDatosPaciente.Name = "lbDatosPaciente";
            this.lbDatosPaciente.Size = new System.Drawing.Size(173, 21);
            this.lbDatosPaciente.TabIndex = 0;
            this.lbDatosPaciente.Text = "DATOS DEL PACIENTE";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbDni.Location = new System.Drawing.Point(25, 53);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(33, 17);
            this.lbDni.TabIndex = 1;
            this.lbDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(64, 53);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 2;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbApellido.Location = new System.Drawing.Point(296, 29);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(59, 17);
            this.lbApellido.TabIndex = 3;
            this.lbApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(361, 26);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbNombre.Location = new System.Drawing.Point(493, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(60, 17);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(558, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lbObraSocial
            // 
            this.lbObraSocial.AutoSize = true;
            this.lbObraSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObraSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbObraSocial.Location = new System.Drawing.Point(296, 65);
            this.lbObraSocial.Name = "lbObraSocial";
            this.lbObraSocial.Size = new System.Drawing.Size(79, 17);
            this.lbObraSocial.TabIndex = 7;
            this.lbObraSocial.Text = "Obra Social:";
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.Enabled = false;
            this.txtObraSocial.Location = new System.Drawing.Point(381, 62);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(100, 20);
            this.txtObraSocial.TabIndex = 8;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbTelefono.Location = new System.Drawing.Point(493, 65);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(61, 17);
            this.lbTelefono.TabIndex = 9;
            this.lbTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(560, 62);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(181, 45);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(83, 35);
            this.btnBuscarPaciente.TabIndex = 11;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click_1);
            // 
            // panelPaciente
            // 
            this.panelPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPaciente.Controls.Add(this.btnBuscarPaciente);
            this.panelPaciente.Controls.Add(this.txtTelefono);
            this.panelPaciente.Controls.Add(this.lbTelefono);
            this.panelPaciente.Controls.Add(this.txtObraSocial);
            this.panelPaciente.Controls.Add(this.lbObraSocial);
            this.panelPaciente.Controls.Add(this.txtNombre);
            this.panelPaciente.Controls.Add(this.lbNombre);
            this.panelPaciente.Controls.Add(this.txtApellido);
            this.panelPaciente.Controls.Add(this.lbApellido);
            this.panelPaciente.Controls.Add(this.txtDni);
            this.panelPaciente.Controls.Add(this.lbDni);
            this.panelPaciente.Controls.Add(this.lbDatosPaciente);
            this.panelPaciente.Location = new System.Drawing.Point(0, 43);
            this.panelPaciente.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.panelPaciente.Name = "panelPaciente";
            this.panelPaciente.Size = new System.Drawing.Size(800, 110);
            this.panelPaciente.TabIndex = 19;
            // 
            // lbBuscarDisponibilidad
            // 
            this.lbBuscarDisponibilidad.AutoSize = true;
            this.lbBuscarDisponibilidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarDisponibilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbBuscarDisponibilidad.Location = new System.Drawing.Point(25, 26);
            this.lbBuscarDisponibilidad.Name = "lbBuscarDisponibilidad";
            this.lbBuscarDisponibilidad.Size = new System.Drawing.Size(224, 21);
            this.lbBuscarDisponibilidad.TabIndex = 0;
            this.lbBuscarDisponibilidad.Text = "DISPONIBILIDAD DE TURNO";
            // 
            // lbEstudio
            // 
            this.lbEstudio.AutoSize = true;
            this.lbEstudio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbEstudio.Location = new System.Drawing.Point(54, 84);
            this.lbEstudio.Name = "lbEstudio";
            this.lbEstudio.Size = new System.Drawing.Size(119, 17);
            this.lbEstudio.TabIndex = 1;
            this.lbEstudio.Text = "Seleccione Estudio:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbFecha.Location = new System.Drawing.Point(159, 137);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(44, 17);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbHorario.Location = new System.Drawing.Point(386, 137);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(56, 17);
            this.lbHorario.TabIndex = 7;
            this.lbHorario.Text = "Horario:";
            // 
            // lbProfesionales
            // 
            this.lbProfesionales.AutoSize = true;
            this.lbProfesionales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfesionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbProfesionales.Location = new System.Drawing.Point(449, 81);
            this.lbProfesionales.Name = "lbProfesionales";
            this.lbProfesionales.Size = new System.Drawing.Size(76, 17);
            this.lbProfesionales.TabIndex = 9;
            this.lbProfesionales.Text = "Profesional:";
            // 
            // btnBuscarDisponibilidad
            // 
            this.btnBuscarDisponibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscarDisponibilidad.FlatAppearance.BorderSize = 0;
            this.btnBuscarDisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDisponibilidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDisponibilidad.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDisponibilidad.Location = new System.Drawing.Point(331, 66);
            this.btnBuscarDisponibilidad.Name = "btnBuscarDisponibilidad";
            this.btnBuscarDisponibilidad.Size = new System.Drawing.Size(83, 35);
            this.btnBuscarDisponibilidad.TabIndex = 11;
            this.btnBuscarDisponibilidad.Text = "Consultar";
            this.btnBuscarDisponibilidad.UseVisualStyleBackColor = false;
            this.btnBuscarDisponibilidad.Click += new System.EventHandler(this.btnBuscarDisponibilidad_Click);
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(537, 76);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(121, 25);
            this.cmbProfesional.TabIndex = 14;
            this.cmbProfesional.SelectedIndexChanged += new System.EventHandler(this.cmbProfesional_SelectedIndexChanged);
            // 
            // cmbEstudio
            // 
            this.cmbEstudio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstudio.FormattingEnabled = true;
            this.cmbEstudio.Location = new System.Drawing.Point(179, 78);
            this.cmbEstudio.Name = "cmbEstudio";
            this.cmbEstudio.Size = new System.Drawing.Size(121, 25);
            this.cmbEstudio.TabIndex = 15;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(219, 131);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(109, 25);
            this.dtpFecha.TabIndex = 16;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cmbHorario
            // 
            this.cmbHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(448, 129);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(121, 25);
            this.cmbHorario.TabIndex = 17;
            // 
            // panelBuscarDisponibilidad
            // 
            this.panelBuscarDisponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarDisponibilidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBuscarDisponibilidad.Controls.Add(this.cmbHorario);
            this.panelBuscarDisponibilidad.Controls.Add(this.dtpFecha);
            this.panelBuscarDisponibilidad.Controls.Add(this.cmbEstudio);
            this.panelBuscarDisponibilidad.Controls.Add(this.cmbProfesional);
            this.panelBuscarDisponibilidad.Controls.Add(this.btnBuscarDisponibilidad);
            this.panelBuscarDisponibilidad.Controls.Add(this.lbProfesionales);
            this.panelBuscarDisponibilidad.Controls.Add(this.lbHorario);
            this.panelBuscarDisponibilidad.Controls.Add(this.lbFecha);
            this.panelBuscarDisponibilidad.Controls.Add(this.lbEstudio);
            this.panelBuscarDisponibilidad.Controls.Add(this.lbBuscarDisponibilidad);
            this.panelBuscarDisponibilidad.Location = new System.Drawing.Point(0, 159);
            this.panelBuscarDisponibilidad.Margin = new System.Windows.Forms.Padding(80, 40, 3, 3);
            this.panelBuscarDisponibilidad.Name = "panelBuscarDisponibilidad";
            this.panelBuscarDisponibilidad.Size = new System.Drawing.Size(800, 204);
            this.panelBuscarDisponibilidad.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(540, 29);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(149, 29);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 35);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(342, 29);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Lmpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnVolver);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Location = new System.Drawing.Point(0, 369);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(801, 85);
            this.panelBotones.TabIndex = 21;
            // 
            // UcNuevoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcNuevoTurno";
            this.Size = new System.Drawing.Size(801, 511);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelPaciente.ResumeLayout(false);
            this.panelPaciente.PerformLayout();
            this.panelBuscarDisponibilidad.ResumeLayout(false);
            this.panelBuscarDisponibilidad.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelBuscarDisponibilidad;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbEstudio;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Button btnBuscarDisponibilidad;
        private System.Windows.Forms.Label lbProfesionales;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbEstudio;
        private System.Windows.Forms.Label lbBuscarDisponibilidad;
        private System.Windows.Forms.Panel panelPaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txtObraSocial;
        private System.Windows.Forms.Label lbObraSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbDatosPaciente;
    }
}
