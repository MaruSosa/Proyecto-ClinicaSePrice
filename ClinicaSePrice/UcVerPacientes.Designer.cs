namespace ClinicaSePrice
{
    partial class UcVerPacientes
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
            this.dgvVerPacientes = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.lbBuscarPaciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPacientes)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Controls.Add(this.dgvVerPacientes);
            this.panelContenido.Location = new System.Drawing.Point(3, 81);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(805, 300);
            this.panelContenido.TabIndex = 5;
            // 
            // dgvVerPacientes
            // 
            this.dgvVerPacientes.AllowUserToAddRows = false;
            this.dgvVerPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerPacientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVerPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVerPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerPacientes.EnableHeadersVisualStyles = false;
            this.dgvVerPacientes.Location = new System.Drawing.Point(3, 3);
            this.dgvVerPacientes.MultiSelect = false;
            this.dgvVerPacientes.Name = "dgvVerPacientes";
            this.dgvVerPacientes.ReadOnly = true;
            this.dgvVerPacientes.RowHeadersVisible = false;
            this.dgvVerPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerPacientes.Size = new System.Drawing.Size(804, 300);
            this.dgvVerPacientes.TabIndex = 4;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelSuperior.Controls.Add(this.lbPacientes);
            this.panelSuperior.Location = new System.Drawing.Point(6, 3);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(804, 78);
            this.panelSuperior.TabIndex = 4;
            // 
            // lbPacientes
            // 
            this.lbPacientes.AutoSize = true;
            this.lbPacientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbPacientes.Location = new System.Drawing.Point(360, 31);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(95, 25);
            this.lbPacientes.TabIndex = 1;
            this.lbPacientes.Text = "Pacientes";
            this.lbPacientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBuscarPaciente);
            this.panel1.Controls.Add(this.txtBuscarDni);
            this.panel1.Controls.Add(this.lbBuscarPaciente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 141);
            this.panel1.TabIndex = 6;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(574, 69);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(93, 30);
            this.btnBuscarPaciente.TabIndex = 3;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Location = new System.Drawing.Point(360, 70);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(176, 29);
            this.txtBuscarDni.TabIndex = 2;
            // 
            // lbBuscarPaciente
            // 
            this.lbBuscarPaciente.AutoSize = true;
            this.lbBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lbBuscarPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbBuscarPaciente.Location = new System.Drawing.Point(93, 69);
            this.lbBuscarPaciente.Name = "lbBuscarPaciente";
            this.lbBuscarPaciente.Size = new System.Drawing.Size(261, 30);
            this.lbBuscarPaciente.TabIndex = 1;
            this.lbBuscarPaciente.Text = "Ingrese DNI del Paciente: ";
            this.lbBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(340, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Paciente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UcVerPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcVerPacientes";
            this.Size = new System.Drawing.Size(821, 657);
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPacientes)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lbPacientes;
        private System.Windows.Forms.DataGridView dgvVerPacientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Label lbBuscarPaciente;
        private System.Windows.Forms.Label label1;
    }
}
