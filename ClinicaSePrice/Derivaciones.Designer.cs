namespace ClinicaSePrice
{
    partial class Derivaciones
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
            this.components = new System.ComponentModel.Container();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lbFechaHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnBuscarTurnoPaciente = new System.Windows.Forms.Button();
            this.btnVerTurnos = new System.Windows.Forms.Button();
            this.btnNuevaDerivacion = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSuperior.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnMaximizar);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.pictureLogo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 50);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(663, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 40);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "—";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(701, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(45, 40);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.Text = "□";
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(752, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 40);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitulo.Controls.Add(this.lbFechaHora);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 50);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 36);
            this.panelTitulo.TabIndex = 2;
            // 
            // lbFechaHora
            // 
            this.lbFechaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFechaHora.AutoSize = true;
            this.lbFechaHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaHora.Location = new System.Drawing.Point(587, 11);
            this.lbFechaHora.Name = "lbFechaHora";
            this.lbFechaHora.Size = new System.Drawing.Size(97, 21);
            this.lbFechaHora.TabIndex = 1;
            this.lbFechaHora.Text = "lbFechaHora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Derivaciones";
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnBuscarTurnoPaciente);
            this.panelBotones.Controls.Add(this.btnVerTurnos);
            this.panelBotones.Controls.Add(this.btnNuevaDerivacion);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(0, 86);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(800, 56);
            this.panelBotones.TabIndex = 5;
            // 
            // btnBuscarTurnoPaciente
            // 
            this.btnBuscarTurnoPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscarTurnoPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarTurnoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTurnoPaciente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTurnoPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarTurnoPaciente.Location = new System.Drawing.Point(343, 7);
            this.btnBuscarTurnoPaciente.Name = "btnBuscarTurnoPaciente";
            this.btnBuscarTurnoPaciente.Size = new System.Drawing.Size(119, 40);
            this.btnBuscarTurnoPaciente.TabIndex = 4;
            this.btnBuscarTurnoPaciente.Text = "Buscar Deriv.";
            this.btnBuscarTurnoPaciente.UseVisualStyleBackColor = false;
            // 
            // btnVerTurnos
            // 
            this.btnVerTurnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnVerTurnos.FlatAppearance.BorderSize = 0;
            this.btnVerTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTurnos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTurnos.ForeColor = System.Drawing.Color.White;
            this.btnVerTurnos.Location = new System.Drawing.Point(180, 7);
            this.btnVerTurnos.Name = "btnVerTurnos";
            this.btnVerTurnos.Size = new System.Drawing.Size(119, 40);
            this.btnVerTurnos.TabIndex = 3;
            this.btnVerTurnos.Text = "Ver Deriv.";
            this.btnVerTurnos.UseVisualStyleBackColor = false;
            // 
            // btnNuevaDerivacion
            // 
            this.btnNuevaDerivacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnNuevaDerivacion.FlatAppearance.BorderSize = 0;
            this.btnNuevaDerivacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaDerivacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaDerivacion.ForeColor = System.Drawing.Color.White;
            this.btnNuevaDerivacion.Location = new System.Drawing.Point(12, 7);
            this.btnNuevaDerivacion.Name = "btnNuevaDerivacion";
            this.btnNuevaDerivacion.Size = new System.Drawing.Size(119, 40);
            this.btnNuevaDerivacion.TabIndex = 2;
            this.btnNuevaDerivacion.Text = "Nueva Deriv.";
            this.btnNuevaDerivacion.UseVisualStyleBackColor = false;
            this.btnNuevaDerivacion.Click += new System.EventHandler(this.btnNuevaDerivacion_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 142);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(800, 308);
            this.panelCentral.TabIndex = 6;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::ClinicaSePrice.Properties.Resources.sepriceLogo;
            this.pictureLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(94, 42);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Derivaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Derivaciones";
            this.Text = "Derivaciones";
            this.panelSuperior.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lbFechaHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnBuscarTurnoPaciente;
        private System.Windows.Forms.Button btnVerTurnos;
        private System.Windows.Forms.Button btnNuevaDerivacion;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Timer timer1;
    }
}