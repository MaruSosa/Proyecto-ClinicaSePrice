namespace ClinicaSePrice
{
    partial class UcVerEstudios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarEstudio = new System.Windows.Forms.Button();
            this.txtBuscarEstudio = new System.Windows.Forms.TextBox();
            this.lbBuscarPaciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.dgvVerEstudios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBuscarEstudio);
            this.panel1.Controls.Add(this.txtBuscarEstudio);
            this.panel1.Controls.Add(this.lbBuscarPaciente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-12, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 141);
            this.panel1.TabIndex = 9;
            // 
            // btnBuscarEstudio
            // 
            this.btnBuscarEstudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscarEstudio.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEstudio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEstudio.Location = new System.Drawing.Point(574, 69);
            this.btnBuscarEstudio.Name = "btnBuscarEstudio";
            this.btnBuscarEstudio.Size = new System.Drawing.Size(93, 30);
            this.btnBuscarEstudio.TabIndex = 3;
            this.btnBuscarEstudio.Text = "Buscar";
            this.btnBuscarEstudio.UseVisualStyleBackColor = false;
            this.btnBuscarEstudio.Click += new System.EventHandler(this.btnBuscarEstudio_Click);
            // 
            // txtBuscarEstudio
            // 
            this.txtBuscarEstudio.Location = new System.Drawing.Point(360, 70);
            this.txtBuscarEstudio.Name = "txtBuscarEstudio";
            this.txtBuscarEstudio.Size = new System.Drawing.Size(176, 29);
            this.txtBuscarEstudio.TabIndex = 2;
            // 
            // lbBuscarPaciente
            // 
            this.lbBuscarPaciente.AutoSize = true;
            this.lbBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lbBuscarPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbBuscarPaciente.Location = new System.Drawing.Point(58, 70);
            this.lbBuscarPaciente.Name = "lbBuscarPaciente";
            this.lbBuscarPaciente.Size = new System.Drawing.Size(292, 30);
            this.lbBuscarPaciente.TabIndex = 1;
            this.lbBuscarPaciente.Text = "Ingrese nombre del estudio: ";
            this.lbBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(319, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Estudio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Controls.Add(this.dgvVerEstudios);
            this.panelContenido.Location = new System.Drawing.Point(27, 64);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(739, 300);
            this.panelContenido.TabIndex = 8;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSuperior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelSuperior.Controls.Add(this.lbPacientes);
            this.panelSuperior.Location = new System.Drawing.Point(-9, -14);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(804, 78);
            this.panelSuperior.TabIndex = 7;
            // 
            // lbPacientes
            // 
            this.lbPacientes.AutoSize = true;
            this.lbPacientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbPacientes.Location = new System.Drawing.Point(360, 31);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(86, 25);
            this.lbPacientes.TabIndex = 1;
            this.lbPacientes.Text = "Estudios";
            this.lbPacientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvVerEstudios
            // 
            this.dgvVerEstudios.AllowUserToAddRows = false;
            this.dgvVerEstudios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerEstudios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVerEstudios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVerEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerEstudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerEstudios.EnableHeadersVisualStyles = false;
            this.dgvVerEstudios.Location = new System.Drawing.Point(0, 0);
            this.dgvVerEstudios.MultiSelect = false;
            this.dgvVerEstudios.Name = "dgvVerEstudios";
            this.dgvVerEstudios.ReadOnly = true;
            this.dgvVerEstudios.RowHeadersVisible = false;
            this.dgvVerEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerEstudios.Size = new System.Drawing.Size(739, 300);
            this.dgvVerEstudios.TabIndex = 5;
            // 
            // UcVerEstudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcVerEstudios";
            this.Size = new System.Drawing.Size(793, 579);
            this.Load += new System.EventHandler(this.UcVerEstudios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEstudios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarEstudio;
        private System.Windows.Forms.TextBox txtBuscarEstudio;
        private System.Windows.Forms.Label lbBuscarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lbPacientes;
        private System.Windows.Forms.DataGridView dgvVerEstudios;
    }
}
