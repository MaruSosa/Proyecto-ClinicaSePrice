namespace ClinicaSePrice
{
    partial class UcNuevaDerivacion
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
            this.lbDatosPaciente = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.txtDniBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelPaciente = new System.Windows.Forms.Panel();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHistoriaClinica = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMedicoDerivante = new System.Windows.Forms.Label();
            this.txtMedicoDerivante = new System.Windows.Forms.TextBox();
            this.panelBuscarDisponibilidad = new System.Windows.Forms.Panel();
            this.panelCargaArchivos = new System.Windows.Forms.Panel();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlVisor = new System.Windows.Forms.Panel();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.pdfVisor = new System.Windows.Forms.WebBrowser();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtHistoriaClinica = new System.Windows.Forms.TextBox();
            this.panelContenedor.SuspendLayout();
            this.panelPaciente.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelBuscarDisponibilidad.SuspendLayout();
            this.panelCargaArchivos.SuspendLayout();
            this.pnlVisor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(891, 44);
            this.panelSuperior.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelBotones);
            this.panelContenedor.Controls.Add(this.panelPaciente);
            this.panelContenedor.Controls.Add(this.panelBuscarDisponibilidad);
            this.panelContenedor.Location = new System.Drawing.Point(35, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(801, 607);
            this.panelContenedor.TabIndex = 2;
            // 
            // lbDatosPaciente
            // 
            this.lbDatosPaciente.AutoSize = true;
            this.lbDatosPaciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbDatosPaciente.Location = new System.Drawing.Point(88, 59);
            this.lbDatosPaciente.Name = "lbDatosPaciente";
            this.lbDatosPaciente.Size = new System.Drawing.Size(173, 21);
            this.lbDatosPaciente.TabIndex = 0;
            this.lbDatosPaciente.Text = "DATOS DEL PACIENTE";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbDni.Location = new System.Drawing.Point(245, 22);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(111, 21);
            this.lbDni.TabIndex = 1;
            this.lbDni.Text = "Ingrese el DNI:";
            // 
            // txtDniBusqueda
            // 
            this.txtDniBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniBusqueda.Location = new System.Drawing.Point(374, 18);
            this.txtDniBusqueda.Name = "txtDniBusqueda";
            this.txtDniBusqueda.Size = new System.Drawing.Size(100, 25);
            this.txtDniBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(490, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 35);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(215, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 21);
            this.lblNombre.TabIndex = 12;
            // 
            // panelPaciente
            // 
            this.panelPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPaciente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelPaciente.Controls.Add(this.lblApellido);
            this.panelPaciente.Controls.Add(this.lblTelefono);
            this.panelPaciente.Controls.Add(this.lblDni);
            this.panelPaciente.Controls.Add(this.lblNombre);
            this.panelPaciente.Controls.Add(this.btnBuscar);
            this.panelPaciente.Controls.Add(this.txtDniBusqueda);
            this.panelPaciente.Controls.Add(this.lbDni);
            this.panelPaciente.Controls.Add(this.lbDatosPaciente);
            this.panelPaciente.Location = new System.Drawing.Point(0, 46);
            this.panelPaciente.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.panelPaciente.Name = "panelPaciente";
            this.panelPaciente.Size = new System.Drawing.Size(800, 135);
            this.panelPaciente.TabIndex = 23;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(358, 92);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(0, 21);
            this.lblDni.TabIndex = 13;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(497, 92);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(0, 21);
            this.lblTelefono.TabIndex = 14;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(88, 92);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(0, 21);
            this.lblApellido.TabIndex = 15;
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBotones.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnVolver);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Location = new System.Drawing.Point(0, 533);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(801, 71);
            this.panelBotones.TabIndex = 24;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(349, 16);
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
            this.btnVolver.Location = new System.Drawing.Point(146, 16);
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
            this.btnGuardar.Location = new System.Drawing.Point(540, 16);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lblObservaciones.Location = new System.Drawing.Point(31, 157);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(115, 21);
            this.lblObservaciones.TabIndex = 1;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lblFecha.Location = new System.Drawing.Point(29, 106);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(152, 21);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de Derivación:";
            // 
            // lblHistoriaClinica
            // 
            this.lblHistoriaClinica.AutoSize = true;
            this.lblHistoriaClinica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoriaClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lblHistoriaClinica.Location = new System.Drawing.Point(29, 238);
            this.lblHistoriaClinica.Name = "lblHistoriaClinica";
            this.lblHistoriaClinica.Size = new System.Drawing.Size(117, 21);
            this.lblHistoriaClinica.TabIndex = 9;
            this.lblHistoriaClinica.Text = "Historia Clinica:";
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(328, 45);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(83, 35);
            this.btnExaminar.TabIndex = 11;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nueva Derivación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(187, 102);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(132, 25);
            this.dtpFecha.TabIndex = 16;
            // 
            // lblMedicoDerivante
            // 
            this.lblMedicoDerivante.AutoSize = true;
            this.lblMedicoDerivante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicoDerivante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lblMedicoDerivante.Location = new System.Drawing.Point(29, 61);
            this.lblMedicoDerivante.Name = "lblMedicoDerivante";
            this.lblMedicoDerivante.Size = new System.Drawing.Size(135, 21);
            this.lblMedicoDerivante.TabIndex = 23;
            this.lblMedicoDerivante.Text = "Médico Derivante:";
            // 
            // txtMedicoDerivante
            // 
            this.txtMedicoDerivante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicoDerivante.Location = new System.Drawing.Point(170, 57);
            this.txtMedicoDerivante.Name = "txtMedicoDerivante";
            this.txtMedicoDerivante.Size = new System.Drawing.Size(149, 25);
            this.txtMedicoDerivante.TabIndex = 24;
            // 
            // panelBuscarDisponibilidad
            // 
            this.panelBuscarDisponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarDisponibilidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelBuscarDisponibilidad.Controls.Add(this.txtHistoriaClinica);
            this.panelBuscarDisponibilidad.Controls.Add(this.txtObservaciones);
            this.panelBuscarDisponibilidad.Controls.Add(this.panelCargaArchivos);
            this.panelBuscarDisponibilidad.Controls.Add(this.txtMedicoDerivante);
            this.panelBuscarDisponibilidad.Controls.Add(this.lblMedicoDerivante);
            this.panelBuscarDisponibilidad.Controls.Add(this.dtpFecha);
            this.panelBuscarDisponibilidad.Controls.Add(this.label1);
            this.panelBuscarDisponibilidad.Controls.Add(this.lblHistoriaClinica);
            this.panelBuscarDisponibilidad.Controls.Add(this.lblFecha);
            this.panelBuscarDisponibilidad.Controls.Add(this.lblObservaciones);
            this.panelBuscarDisponibilidad.Location = new System.Drawing.Point(0, 189);
            this.panelBuscarDisponibilidad.Margin = new System.Windows.Forms.Padding(80, 40, 3, 3);
            this.panelBuscarDisponibilidad.Name = "panelBuscarDisponibilidad";
            this.panelBuscarDisponibilidad.Size = new System.Drawing.Size(800, 338);
            this.panelBuscarDisponibilidad.TabIndex = 20;
            // 
            // panelCargaArchivos
            // 
            this.panelCargaArchivos.Controls.Add(this.lblVistaPrevia);
            this.panelCargaArchivos.Controls.Add(this.pnlVisor);
            this.panelCargaArchivos.Controls.Add(this.lblEstado);
            this.panelCargaArchivos.Controls.Add(this.txtRuta);
            this.panelCargaArchivos.Controls.Add(this.lblArchivos);
            this.panelCargaArchivos.Controls.Add(this.btnExaminar);
            this.panelCargaArchivos.Location = new System.Drawing.Point(342, 19);
            this.panelCargaArchivos.Name = "panelCargaArchivos";
            this.panelCargaArchivos.Size = new System.Drawing.Size(446, 294);
            this.panelCargaArchivos.TabIndex = 27;
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lblArchivos.Location = new System.Drawing.Point(16, 17);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(190, 21);
            this.lblArchivos.TabIndex = 28;
            this.lblArchivos.Text = "Archivo / Estudio Adjunto:";
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(20, 55);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(278, 25);
            this.txtRuta.TabIndex = 28;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lblEstado.Location = new System.Drawing.Point(188, 83);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(110, 21);
            this.lblEstado.TabIndex = 29;
            this.lblEstado.Text = "correctamente";
            // 
            // pnlVisor
            // 
            this.pnlVisor.Controls.Add(this.pdfVisor);
            this.pnlVisor.Location = new System.Drawing.Point(17, 138);
            this.pnlVisor.Name = "pnlVisor";
            this.pnlVisor.Size = new System.Drawing.Size(428, 155);
            this.pnlVisor.TabIndex = 30;
            // 
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.AutoSize = true;
            this.lblVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrevia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lblVistaPrevia.Location = new System.Drawing.Point(16, 114);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(91, 21);
            this.lblVistaPrevia.TabIndex = 31;
            this.lblVistaPrevia.Text = "Vista Previa";
            // 
            // pdfVisor
            // 
            this.pdfVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfVisor.Location = new System.Drawing.Point(0, 0);
            this.pdfVisor.MinimumSize = new System.Drawing.Size(20, 20);
            this.pdfVisor.Name = "pdfVisor";
            this.pdfVisor.Size = new System.Drawing.Size(428, 155);
            this.pdfVisor.TabIndex = 0;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(161, 157);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(158, 29);
            this.txtObservaciones.TabIndex = 28;
            // 
            // txtHistoriaClinica
            // 
            this.txtHistoriaClinica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoriaClinica.Location = new System.Drawing.Point(161, 230);
            this.txtHistoriaClinica.Name = "txtHistoriaClinica";
            this.txtHistoriaClinica.Size = new System.Drawing.Size(158, 29);
            this.txtHistoriaClinica.TabIndex = 29;
            // 
            // UcNuevaDerivacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcNuevaDerivacion";
            this.Size = new System.Drawing.Size(891, 673);
            this.panelContenedor.ResumeLayout(false);
            this.panelPaciente.ResumeLayout(false);
            this.panelPaciente.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelBuscarDisponibilidad.ResumeLayout(false);
            this.panelBuscarDisponibilidad.PerformLayout();
            this.panelCargaArchivos.ResumeLayout(false);
            this.panelCargaArchivos.PerformLayout();
            this.pnlVisor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelPaciente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDniBusqueda;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbDatosPaciente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelBuscarDisponibilidad;
        private System.Windows.Forms.TextBox txtMedicoDerivante;
        private System.Windows.Forms.Label lblMedicoDerivante;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lblHistoriaClinica;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Panel panelCargaArchivos;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.Panel pnlVisor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.WebBrowser pdfVisor;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtHistoriaClinica;
    }
}
