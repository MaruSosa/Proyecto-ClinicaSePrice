namespace ClinicaSePrice
{
    partial class UcVerUsuarios
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
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.lbBuscarUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.dgvVerUsuarios = new System.Windows.Forms.DataGridView();
            this.panelUsuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(832, 44);
            this.panelSuperior.TabIndex = 2;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelUsuarios.Controls.Add(this.lbUsuarios);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 44);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(832, 78);
            this.panelUsuarios.TabIndex = 5;
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbUsuarios.Location = new System.Drawing.Point(360, 31);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(89, 25);
            this.lbUsuarios.TabIndex = 1;
            this.lbUsuarios.Text = "Usuarios";
            this.lbUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.txtBuscarUsuario);
            this.panel1.Controls.Add(this.lbBuscarUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 141);
            this.panel1.TabIndex = 9;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(574, 69);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(93, 30);
            this.btnBuscarUsuario.TabIndex = 3;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(360, 70);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(176, 29);
            this.txtBuscarUsuario.TabIndex = 2;
            // 
            // lbBuscarUsuario
            // 
            this.lbBuscarUsuario.AutoSize = true;
            this.lbBuscarUsuario.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lbBuscarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.lbBuscarUsuario.Location = new System.Drawing.Point(62, 69);
            this.lbBuscarUsuario.Name = "lbBuscarUsuario";
            this.lbBuscarUsuario.Size = new System.Drawing.Size(292, 30);
            this.lbBuscarUsuario.TabIndex = 1;
            this.lbBuscarUsuario.Text = "Ingrese Nombre del Usuario:";
            this.lbBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(340, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Controls.Add(this.dgvVerUsuarios);
            this.panelContenido.Location = new System.Drawing.Point(12, 128);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(805, 300);
            this.panelContenido.TabIndex = 8;
            // 
            // dgvVerUsuarios
            // 
            this.dgvVerUsuarios.AllowUserToAddRows = false;
            this.dgvVerUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVerUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVerUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerUsuarios.EnableHeadersVisualStyles = false;
            this.dgvVerUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvVerUsuarios.MultiSelect = false;
            this.dgvVerUsuarios.Name = "dgvVerUsuarios";
            this.dgvVerUsuarios.ReadOnly = true;
            this.dgvVerUsuarios.RowHeadersVisible = false;
            this.dgvVerUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerUsuarios.Size = new System.Drawing.Size(804, 293);
            this.dgvVerUsuarios.TabIndex = 4;
            this.dgvVerUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerUsuarios_CellContentClick);
            // 
            // UcVerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.panelSuperior);
            this.Name = "UcVerUsuarios";
            this.Size = new System.Drawing.Size(832, 604);
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Label lbBuscarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.DataGridView dgvVerUsuarios;
    }
}
