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
            this.dgvVerProfesionales = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProfesionales)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Controls.Add(this.dgvVerProfesionales);
            this.panelContenido.Location = new System.Drawing.Point(3, 117);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(800, 193);
            this.panelContenido.TabIndex = 7;
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
            this.dgvVerProfesionales.Size = new System.Drawing.Size(800, 193);
            this.dgvVerProfesionales.TabIndex = 4;
            this.dgvVerProfesionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerProfesionales_CellContentClick);
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
            // UcVerProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelContenido);
            this.Name = "UcVerProfesionales";
            this.Size = new System.Drawing.Size(795, 467);
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProfesionales)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.DataGridView dgvVerProfesionales;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lbPacientes;
    }
}
