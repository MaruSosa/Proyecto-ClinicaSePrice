namespace ClinicaSePrice
{
    partial class UcVerTurnos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbSeleccionFecha = new System.Windows.Forms.Label();
            this.lbTurnos = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.dgvVerTurnos = new System.Windows.Forms.DataGridView();
            this.panelSuperior.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelSuperior.Controls.Add(this.btnBuscar);
            this.panelSuperior.Controls.Add(this.dtpFecha);
            this.panelSuperior.Controls.Add(this.lbSeleccionFecha);
            this.panelSuperior.Controls.Add(this.lbTurnos);
            this.panelSuperior.Location = new System.Drawing.Point(58, 12);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(745, 150);
            this.panelSuperior.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(561, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 33);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(325, 80);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lbSeleccionFecha
            // 
            this.lbSeleccionFecha.AutoSize = true;
            this.lbSeleccionFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccionFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbSeleccionFecha.Location = new System.Drawing.Point(139, 75);
            this.lbSeleccionFecha.Name = "lbSeleccionFecha";
            this.lbSeleccionFecha.Size = new System.Drawing.Size(185, 25);
            this.lbSeleccionFecha.TabIndex = 2;
            this.lbSeleccionFecha.Text = "Seleccione la Fecha:";
            this.lbSeleccionFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTurnos
            // 
            this.lbTurnos.AutoSize = true;
            this.lbTurnos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbTurnos.Location = new System.Drawing.Point(320, 20);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.Size = new System.Drawing.Size(74, 25);
            this.lbTurnos.TabIndex = 1;
            this.lbTurnos.Text = "Turnos";
            this.lbTurnos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Controls.Add(this.dgvVerTurnos);
            this.panelContenido.Location = new System.Drawing.Point(58, 168);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(745, 300);
            this.panelContenido.TabIndex = 3;
            // 
            // dgvVerTurnos
            // 
            this.dgvVerTurnos.AllowUserToAddRows = false;
            this.dgvVerTurnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVerTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerTurnos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVerTurnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVerTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerTurnos.EnableHeadersVisualStyles = false;
            this.dgvVerTurnos.Location = new System.Drawing.Point(3, 48);
            this.dgvVerTurnos.MultiSelect = false;
            this.dgvVerTurnos.Name = "dgvVerTurnos";
            this.dgvVerTurnos.ReadOnly = true;
            this.dgvVerTurnos.RowHeadersVisible = false;
            this.dgvVerTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerTurnos.Size = new System.Drawing.Size(739, 300);
            this.dgvVerTurnos.TabIndex = 2;
            this.dgvVerTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerTurnos_CellContentClick);
            // 
            // UcVerTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcVerTurnos";
            this.Size = new System.Drawing.Size(872, 684);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbSeleccionFecha;
        private System.Windows.Forms.Label lbTurnos;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.DataGridView dgvVerTurnos;
    }
}
