namespace ClinicaSePrice
{
    partial class UcNuevoProfesional
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarTurno = new System.Windows.Forms.Button();
            this.panelPaciente = new System.Windows.Forms.Panel();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbObraSocial = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbDatosPaciente = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(849, 44);
            this.panelSuperior.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.panelBotones);
            this.panelContenedor.Controls.Add(this.panelPaciente);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 44);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(849, 528);
            this.panelContenedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(332, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nuevo profesional";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnGuardarTurno);
            this.panelBotones.Location = new System.Drawing.Point(24, 354);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(801, 76);
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(149, 29);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnGuardarTurno.FlatAppearance.BorderSize = 0;
            this.btnGuardarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTurno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTurno.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTurno.Location = new System.Drawing.Point(540, 29);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(100, 35);
            this.btnGuardarTurno.TabIndex = 12;
            this.btnGuardarTurno.Text = "Guardar";
            this.btnGuardarTurno.UseVisualStyleBackColor = false;
            this.btnGuardarTurno.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // panelPaciente
            // 
            this.panelPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPaciente.Controls.Add(this.cmbEspecialidad);
            this.panelPaciente.Controls.Add(this.txtEmail);
            this.panelPaciente.Controls.Add(this.lbEmail);
            this.panelPaciente.Controls.Add(this.label2);
            this.panelPaciente.Controls.Add(this.txtTelefono);
            this.panelPaciente.Controls.Add(this.txtMatricula);
            this.panelPaciente.Controls.Add(this.txtNombre);
            this.panelPaciente.Controls.Add(this.txtApellido);
            this.panelPaciente.Controls.Add(this.lbTelefono);
            this.panelPaciente.Controls.Add(this.lbObraSocial);
            this.panelPaciente.Controls.Add(this.lbNombre);
            this.panelPaciente.Controls.Add(this.lbApellido);
            this.panelPaciente.Controls.Add(this.txtDni);
            this.panelPaciente.Controls.Add(this.lbDni);
            this.panelPaciente.Controls.Add(this.lbDatosPaciente);
            this.panelPaciente.Location = new System.Drawing.Point(24, 65);
            this.panelPaciente.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.panelPaciente.Name = "panelPaciente";
            this.panelPaciente.Size = new System.Drawing.Size(800, 283);
            this.panelPaciente.TabIndex = 19;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(284, 179);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(101, 29);
            this.cmbEspecialidad.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(285, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 29);
            this.txtEmail.TabIndex = 17;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbEmail.Location = new System.Drawing.Point(236, 237);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(195, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Especialidad:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(509, 179);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 29);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(509, 65);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 29);
            this.txtMatricula.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(285, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 29);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(284, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 29);
            this.txtApellido.TabIndex = 10;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbTelefono.Location = new System.Drawing.Point(442, 185);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(61, 17);
            this.lbTelefono.TabIndex = 9;
            this.lbTelefono.Text = "Teléfono:";
            // 
            // lbObraSocial
            // 
            this.lbObraSocial.AutoSize = true;
            this.lbObraSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObraSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbObraSocial.Location = new System.Drawing.Point(438, 71);
            this.lbObraSocial.Name = "lbObraSocial";
            this.lbObraSocial.Size = new System.Drawing.Size(65, 17);
            this.lbObraSocial.TabIndex = 7;
            this.lbObraSocial.Text = "Matricula:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbNombre.Location = new System.Drawing.Point(219, 128);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(60, 17);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbApellido.Location = new System.Drawing.Point(219, 71);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(59, 17);
            this.lbApellido.TabIndex = 3;
            this.lbApellido.Text = "Apellido:";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(509, 122);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 29);
            this.txtDni.TabIndex = 2;
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbDni.Location = new System.Drawing.Point(460, 128);
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
            this.lbDatosPaciente.Size = new System.Drawing.Size(205, 21);
            this.lbDatosPaciente.TabIndex = 0;
            this.lbDatosPaciente.Text = "DATOS DEL PROFESIONAL";
            // 
            // UcNuevoProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcNuevoProfesional";
            this.Size = new System.Drawing.Size(849, 572);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelPaciente.ResumeLayout(false);
            this.panelPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarTurno;
        private System.Windows.Forms.Panel panelPaciente;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbObraSocial;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbDatosPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
    }
}
