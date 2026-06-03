namespace ClinicaSePrice
{
    partial class UcVerInsumos
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
            this.lbPacientes = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelDataGriew = new System.Windows.Forms.Panel();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.txtBuscarInsumo = new System.Windows.Forms.TextBox();
            this.lbBuscarInsumo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelDataGriew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelSuperior.Controls.Add(this.lbPacientes);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(857, 74);
            this.panelSuperior.TabIndex = 10;
            // 
            // lbPacientes
            // 
            this.lbPacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPacientes.AutoSize = true;
            this.lbPacientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbPacientes.Location = new System.Drawing.Point(365, 27);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(87, 25);
            this.lbPacientes.TabIndex = 1;
            this.lbPacientes.Text = "Insumos";
            this.lbPacientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Controls.Add(this.panelDataGriew);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 74);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(857, 497);
            this.panelContenedor.TabIndex = 11;
            // 
            // panelDataGriew
            // 
            this.panelDataGriew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelDataGriew.Controls.Add(this.panel1);
            this.panelDataGriew.Controls.Add(this.dgvInsumos);
            this.panelDataGriew.Location = new System.Drawing.Point(61, 26);
            this.panelDataGriew.Name = "panelDataGriew";
            this.panelDataGriew.Size = new System.Drawing.Size(737, 468);
            this.panelDataGriew.TabIndex = 0;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.BackgroundColor = System.Drawing.Color.White;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Location = new System.Drawing.Point(30, 167);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.Size = new System.Drawing.Size(683, 283);
            this.dgvInsumos.TabIndex = 1;
            this.dgvInsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumos_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBuscarInsumo);
            this.panel1.Controls.Add(this.txtBuscarInsumo);
            this.panel1.Controls.Add(this.lbBuscarInsumo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 132);
            this.panel1.TabIndex = 7;
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscarInsumo.FlatAppearance.BorderSize = 0;
            this.btnBuscarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarInsumo.Location = new System.Drawing.Point(574, 69);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(93, 30);
            this.btnBuscarInsumo.TabIndex = 3;
            this.btnBuscarInsumo.Text = "Buscar";
            this.btnBuscarInsumo.UseVisualStyleBackColor = false;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscarInsumo_Click);
            // 
            // txtBuscarInsumo
            // 
            this.txtBuscarInsumo.Location = new System.Drawing.Point(360, 70);
            this.txtBuscarInsumo.Name = "txtBuscarInsumo";
            this.txtBuscarInsumo.Size = new System.Drawing.Size(176, 29);
            this.txtBuscarInsumo.TabIndex = 2;
            // 
            // lbBuscarInsumo
            // 
            this.lbBuscarInsumo.AutoSize = true;
            this.lbBuscarInsumo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lbBuscarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbBuscarInsumo.Location = new System.Drawing.Point(57, 69);
            this.lbBuscarInsumo.Name = "lbBuscarInsumo";
            this.lbBuscarInsumo.Size = new System.Drawing.Size(286, 30);
            this.lbBuscarInsumo.TabIndex = 1;
            this.lbBuscarInsumo.Text = "Ingrese nombre del Insumo:";
            this.lbBuscarInsumo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lblTitulo.Location = new System.Drawing.Point(271, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(164, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Buscar Insumo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UcVerInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcVerInsumos";
            this.Size = new System.Drawing.Size(857, 571);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelDataGriew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lbPacientes;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelDataGriew;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.TextBox txtBuscarInsumo;
        private System.Windows.Forms.Label lbBuscarInsumo;
        private System.Windows.Forms.Label lblTitulo;
    }
}
