namespace ClinicaSePrice
{
    partial class UcNuevoEstudio
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarEstudio = new System.Windows.Forms.Button();
            this.panelPaciente = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDatosPaciente = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelContenedor.Controls.Add(this.lbTitulo);
            this.panelContenedor.Controls.Add(this.panelBotones);
            this.panelContenedor.Controls.Add(this.panelPaciente);
            this.panelContenedor.Location = new System.Drawing.Point(51, 60);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(818, 383);
            this.panelContenedor.TabIndex = 5;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbTitulo.Location = new System.Drawing.Point(17, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(163, 30);
            this.lbTitulo.TabIndex = 22;
            this.lbTitulo.Text = "Nuevo Estudio ";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnVolver);
            this.panelBotones.Controls.Add(this.btnGuardarEstudio);
            this.panelBotones.Location = new System.Drawing.Point(8, 272);
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            // btnGuardarEstudio
            // 
            this.btnGuardarEstudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnGuardarEstudio.FlatAppearance.BorderSize = 0;
            this.btnGuardarEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEstudio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEstudio.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEstudio.Location = new System.Drawing.Point(540, 29);
            this.btnGuardarEstudio.Name = "btnGuardarEstudio";
            this.btnGuardarEstudio.Size = new System.Drawing.Size(100, 35);
            this.btnGuardarEstudio.TabIndex = 12;
            this.btnGuardarEstudio.Text = "Guardar";
            this.btnGuardarEstudio.UseVisualStyleBackColor = false;
            this.btnGuardarEstudio.Click += new System.EventHandler(this.btnGuardarEstudio_Click);
            // 
            // panelPaciente
            // 
            this.panelPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPaciente.Controls.Add(this.txtPrecio);
            this.panelPaciente.Controls.Add(this.txtNombre);
            this.panelPaciente.Controls.Add(this.lbPrecio);
            this.panelPaciente.Controls.Add(this.lbNombre);
            this.panelPaciente.Controls.Add(this.lbDatosPaciente);
            this.panelPaciente.Location = new System.Drawing.Point(9, 43);
            this.panelPaciente.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.panelPaciente.Name = "panelPaciente";
            this.panelPaciente.Size = new System.Drawing.Size(800, 223);
            this.panelPaciente.TabIndex = 19;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrecio.Location = new System.Drawing.Point(148, 92);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 29);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombre.Location = new System.Drawing.Point(148, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 29);
            this.txtNombre.TabIndex = 12;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbPrecio.Location = new System.Drawing.Point(82, 98);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(47, 17);
            this.lbPrecio.TabIndex = 9;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbNombre.Location = new System.Drawing.Point(69, 41);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(60, 17);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDatosPaciente
            // 
            this.lbDatosPaciente.AutoSize = true;
            this.lbDatosPaciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbDatosPaciente.Location = new System.Drawing.Point(68, 19);
            this.lbDatosPaciente.Name = "lbDatosPaciente";
            this.lbDatosPaciente.Size = new System.Drawing.Size(0, 21);
            this.lbDatosPaciente.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(923, 44);
            this.panelSuperior.TabIndex = 4;
            // 
            // UcNuevoEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcNuevoEstudio";
            this.Size = new System.Drawing.Size(923, 547);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelPaciente.ResumeLayout(false);
            this.panelPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarEstudio;
        private System.Windows.Forms.Panel panelPaciente;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDatosPaciente;
        private System.Windows.Forms.Panel panelSuperior;
    }
}
