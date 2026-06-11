namespace ClinicaSePrice
{
    partial class UcVerProfesionales
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
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.panelBuscarProfesional = new System.Windows.Forms.Panel();
            this.btnBuscarProfesional = new System.Windows.Forms.Button();
            this.txtBuscarProfesional = new System.Windows.Forms.TextBox();
            this.lbBuscarPaciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGrilla = new System.Windows.Forms.Panel();
            this.dgvVerProfesionales = new System.Windows.Forms.DataGridView();
            this.panelSuperior.SuspendLayout();
            this.panelBuscarProfesional.SuspendLayout();
            this.panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 74);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(795, 393);
            this.panelContenido.TabIndex = 7;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelSuperior.Controls.Add(this.lbPacientes);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(795, 74);
            this.panelSuperior.TabIndex = 9;
            // 
            // lbPacientes
            // 
            this.lbPacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPacientes.AutoSize = true;
            this.lbPacientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbPacientes.Location = new System.Drawing.Point(334, 27);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(131, 25);
            this.lbPacientes.TabIndex = 1;
            this.lbPacientes.Text = "Profesionales";
            this.lbPacientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelBuscarProfesional
            // 
            this.panelBuscarProfesional.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarProfesional.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBuscarProfesional.Controls.Add(this.btnBuscarProfesional);
            this.panelBuscarProfesional.Controls.Add(this.txtBuscarProfesional);
            this.panelBuscarProfesional.Controls.Add(this.lbBuscarPaciente);
            this.panelBuscarProfesional.Controls.Add(this.label1);
            this.panelBuscarProfesional.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBuscarProfesional.Location = new System.Drawing.Point(3, 304);
            this.panelBuscarProfesional.Name = "panelBuscarProfesional";
            this.panelBuscarProfesional.Size = new System.Drawing.Size(789, 141);
            this.panelBuscarProfesional.TabIndex = 10;
            // 
            // btnBuscarProfesional
            // 
            this.btnBuscarProfesional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscarProfesional.FlatAppearance.BorderSize = 0;
            this.btnBuscarProfesional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProfesional.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProfesional.Location = new System.Drawing.Point(574, 69);
            this.btnBuscarProfesional.Name = "btnBuscarProfesional";
            this.btnBuscarProfesional.Size = new System.Drawing.Size(93, 30);
            this.btnBuscarProfesional.TabIndex = 3;
            this.btnBuscarProfesional.Text = "Buscar";
            this.btnBuscarProfesional.UseVisualStyleBackColor = false;
            this.btnBuscarProfesional.Click += new System.EventHandler(this.btnBuscarProfesional_Click);
            // 
            // txtBuscarProfesional
            // 
            this.txtBuscarProfesional.Location = new System.Drawing.Point(360, 70);
            this.txtBuscarProfesional.Name = "txtBuscarProfesional";
            this.txtBuscarProfesional.Size = new System.Drawing.Size(176, 29);
            this.txtBuscarProfesional.TabIndex = 2;
            // 
            // lbBuscarPaciente
            // 
            this.lbBuscarPaciente.AutoSize = true;
            this.lbBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lbBuscarPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbBuscarPaciente.Location = new System.Drawing.Point(93, 69);
            this.lbBuscarPaciente.Name = "lbBuscarPaciente";
            this.lbBuscarPaciente.Size = new System.Drawing.Size(254, 30);
            this.lbBuscarPaciente.TabIndex = 1;
            this.lbBuscarPaciente.Text = " Nombre del Profesional:";
            this.lbBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(340, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Profesional";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelGrilla
            // 
            this.panelGrilla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelGrilla.Controls.Add(this.dgvVerProfesionales);
            this.panelGrilla.Location = new System.Drawing.Point(31, 106);
            this.panelGrilla.Name = "panelGrilla";
            this.panelGrilla.Size = new System.Drawing.Size(743, 158);
            this.panelGrilla.TabIndex = 11;
            // 
            // dgvVerProfesionales
            // 
            this.dgvVerProfesionales.AllowUserToAddRows = false;
            this.dgvVerProfesionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerProfesionales.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVerProfesionales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVerProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerProfesionales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerProfesionales.EnableHeadersVisualStyles = false;
            this.dgvVerProfesionales.Location = new System.Drawing.Point(0, 0);
            this.dgvVerProfesionales.Margin = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.dgvVerProfesionales.MultiSelect = false;
            this.dgvVerProfesionales.Name = "dgvVerProfesionales";
            this.dgvVerProfesionales.ReadOnly = true;
            this.dgvVerProfesionales.RowHeadersVisible = false;
            this.dgvVerProfesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerProfesionales.Size = new System.Drawing.Size(743, 158);
            this.dgvVerProfesionales.TabIndex = 8;
            // 
            // UcVerProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGrilla);
            this.Controls.Add(this.panelBuscarProfesional);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcVerProfesionales";
            this.Size = new System.Drawing.Size(795, 467);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelBuscarProfesional.ResumeLayout(false);
            this.panelBuscarProfesional.PerformLayout();
            this.panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProfesionales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lbPacientes;
        private System.Windows.Forms.Panel panelBuscarProfesional;
        private System.Windows.Forms.Button btnBuscarProfesional;
        private System.Windows.Forms.TextBox txtBuscarProfesional;
        private System.Windows.Forms.Label lbBuscarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGrilla;
        private System.Windows.Forms.DataGridView dgvVerProfesionales;
    }
}
