namespace ClinicaSePrice
{
    partial class Estudios
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
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lbFechaHora = new System.Windows.Forms.Label();
            this.lbEstudios = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnVerEstudios = new System.Windows.Forms.Button();
            this.btnNuevoEstudio = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panelBotones.SuspendLayout();
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
            this.panelSuperior.TabIndex = 2;
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
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitulo.Controls.Add(this.lbFechaHora);
            this.panelTitulo.Controls.Add(this.lbEstudios);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 50);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 60);
            this.panelTitulo.TabIndex = 3;
            // 
            // lbFechaHora
            // 
            this.lbFechaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFechaHora.AutoSize = true;
            this.lbFechaHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaHora.Location = new System.Drawing.Point(611, 22);
            this.lbFechaHora.Name = "lbFechaHora";
            this.lbFechaHora.Size = new System.Drawing.Size(97, 21);
            this.lbFechaHora.TabIndex = 1;
            this.lbFechaHora.Text = "lbFechaHora";
            // 
            // lbEstudios
            // 
            this.lbEstudios.AutoSize = true;
            this.lbEstudios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstudios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEstudios.Location = new System.Drawing.Point(90, 18);
            this.lbEstudios.Name = "lbEstudios";
            this.lbEstudios.Size = new System.Drawing.Size(86, 25);
            this.lbEstudios.TabIndex = 0;
            this.lbEstudios.Text = "Estudios";
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnVerEstudios);
            this.panelBotones.Controls.Add(this.btnNuevoEstudio);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(0, 110);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(800, 56);
            this.panelBotones.TabIndex = 6;
            // 
            // btnVerEstudios
            // 
            this.btnVerEstudios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnVerEstudios.FlatAppearance.BorderSize = 0;
            this.btnVerEstudios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEstudios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEstudios.ForeColor = System.Drawing.Color.White;
            this.btnVerEstudios.Location = new System.Drawing.Point(180, 7);
            this.btnVerEstudios.Name = "btnVerEstudios";
            this.btnVerEstudios.Size = new System.Drawing.Size(119, 40);
            this.btnVerEstudios.TabIndex = 3;
            this.btnVerEstudios.Text = "Ver Estudios";
            this.btnVerEstudios.UseVisualStyleBackColor = false;
            this.btnVerEstudios.Click += new System.EventHandler(this.btnVerEstudios_Click);
            // 
            // btnNuevoEstudio
            // 
            this.btnNuevoEstudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnNuevoEstudio.FlatAppearance.BorderSize = 0;
            this.btnNuevoEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEstudio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEstudio.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEstudio.Location = new System.Drawing.Point(12, 7);
            this.btnNuevoEstudio.Name = "btnNuevoEstudio";
            this.btnNuevoEstudio.Size = new System.Drawing.Size(119, 40);
            this.btnNuevoEstudio.TabIndex = 2;
            this.btnNuevoEstudio.Text = "Nuevo Estudio";
            this.btnNuevoEstudio.UseVisualStyleBackColor = false;
            this.btnNuevoEstudio.Click += new System.EventHandler(this.btnNuevoEstudio_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 166);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(800, 284);
            this.panelContenido.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Estudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estudios";
            this.Text = "Estudios";
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelBotones.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbEstudios;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnVerEstudios;
        private System.Windows.Forms.Button btnNuevoEstudio;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Timer timer1;
    }
}