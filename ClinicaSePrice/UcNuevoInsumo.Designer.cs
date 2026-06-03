namespace ClinicaSePrice
{
    partial class UcNuevoInsumo
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelBuscarDisponibilidad = new System.Windows.Forms.Panel();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbEstudio = new System.Windows.Forms.ComboBox();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.btnBuscarDisponibilidad = new System.Windows.Forms.Button();
            this.lbProfesionales = new System.Windows.Forms.Label();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbEstudio = new System.Windows.Forms.Label();
            this.lbBuscarDisponibilidad = new System.Windows.Forms.Label();
            this.panelPaciente = new System.Windows.Forms.Panel();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.lbObraSocial = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbDatosPaciente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardarInsumo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCantidades = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbInsumo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelBuscarDisponibilidad.SuspendLayout();
            this.panelPaciente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.panelSuperior.Controls.Add(this.panelContenedor);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(913, 44);
            this.panelSuperior.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.panelBotones);
            this.panelContenedor.Controls.Add(this.panelBuscarDisponibilidad);
            this.panelContenedor.Controls.Add(this.panelPaciente);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(913, 44);
            this.panelContenedor.TabIndex = 2;
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
            // panelBotones
            // 
            this.panelBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnVolver);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Location = new System.Drawing.Point(56, 369);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(801, 85);
            this.panelBotones.TabIndex = 21;
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
            this.panelBuscarDisponibilidad.Location = new System.Drawing.Point(56, 159);
            this.panelBuscarDisponibilidad.Margin = new System.Windows.Forms.Padding(80, 40, 3, 3);
            this.panelBuscarDisponibilidad.Name = "panelBuscarDisponibilidad";
            this.panelBuscarDisponibilidad.Size = new System.Drawing.Size(800, 204);
            this.panelBuscarDisponibilidad.TabIndex = 20;
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
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(219, 131);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(109, 25);
            this.dtpFecha.TabIndex = 16;
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
            // cmbProfesional
            // 
            this.cmbProfesional.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(537, 76);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(121, 25);
            this.cmbProfesional.TabIndex = 14;
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
            this.panelPaciente.Location = new System.Drawing.Point(56, 43);
            this.panelPaciente.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.panelPaciente.Name = "panelPaciente";
            this.panelPaciente.Size = new System.Drawing.Size(800, 110);
            this.panelPaciente.TabIndex = 19;
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
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(560, 62);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 10;
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
            // txtObraSocial
            // 
            this.txtObraSocial.Enabled = false;
            this.txtObraSocial.Location = new System.Drawing.Point(381, 62);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(100, 20);
            this.txtObraSocial.TabIndex = 8;
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
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(558, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
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
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(361, 26);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
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
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(64, 53);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 658);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 658);
            this.panel2.TabIndex = 3;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbTitulo.Location = new System.Drawing.Point(412, 28);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(96, 30);
            this.lbTitulo.TabIndex = 22;
            this.lbTitulo.Text = "Insumos";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btnGuardarInsumo);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.lblCantidades);
            this.panel5.Controls.Add(this.cmbUnidad);
            this.panel5.Controls.Add(this.lbCantidad);
            this.panel5.Controls.Add(this.numCantidad);
            this.panel5.Controls.Add(this.cmbInsumo);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(57, 78);
            this.panel5.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 305);
            this.panel5.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(342, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Lmpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardarInsumo
            // 
            this.btnGuardarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnGuardarInsumo.FlatAppearance.BorderSize = 0;
            this.btnGuardarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarInsumo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarInsumo.Location = new System.Drawing.Point(524, 229);
            this.btnGuardarInsumo.Name = "btnGuardarInsumo";
            this.btnGuardarInsumo.Size = new System.Drawing.Size(100, 35);
            this.btnGuardarInsumo.TabIndex = 15;
            this.btnGuardarInsumo.Text = "Guardar";
            this.btnGuardarInsumo.UseVisualStyleBackColor = false;
            this.btnGuardarInsumo.Click += new System.EventHandler(this.btnGuardarInsumo_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(164, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCantidades
            // 
            this.lblCantidades.AutoSize = true;
            this.lblCantidades.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lblCantidades.Location = new System.Drawing.Point(296, 154);
            this.lblCantidades.Name = "lblCantidades";
            this.lblCantidades.Size = new System.Drawing.Size(66, 17);
            this.lblCantidades.TabIndex = 20;
            this.lblCantidades.Text = "Unidades:";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.AutoCompleteCustomSource.AddRange(new string[] {
            "unidades",
            "ml",
            "rollos",
            "cajas"});
            this.cmbUnidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Items.AddRange(new object[] {
            "unidades",
            "ml",
            "rollos",
            "cajas"});
            this.cmbUnidad.Location = new System.Drawing.Point(372, 142);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(79, 29);
            this.cmbUnidad.TabIndex = 19;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbCantidad.Location = new System.Drawing.Point(299, 106);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(63, 17);
            this.lbCantidad.TabIndex = 18;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(370, 106);
            this.numCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(45, 29);
            this.numCantidad.TabIndex = 17;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbInsumo
            // 
            this.cmbInsumo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbInsumo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInsumo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInsumo.FormattingEnabled = true;
            this.cmbInsumo.Location = new System.Drawing.Point(370, 63);
            this.cmbInsumo.Name = "cmbInsumo";
            this.cmbInsumo.Size = new System.Drawing.Size(155, 29);
            this.cmbInsumo.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label12.Location = new System.Drawing.Point(178, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ingrese el nombre del Insumo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label13.Location = new System.Drawing.Point(122, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "BUSCAR INSUMO";
            // 
            // UcNuevoInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcNuevoInsumo";
            this.Size = new System.Drawing.Size(913, 702);
            this.panelSuperior.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelBuscarDisponibilidad.ResumeLayout(false);
            this.panelBuscarDisponibilidad.PerformLayout();
            this.panelPaciente.ResumeLayout(false);
            this.panelPaciente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGuardarInsumo;
        private System.Windows.Forms.Label lblCantidades;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.ComboBox cmbInsumo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
