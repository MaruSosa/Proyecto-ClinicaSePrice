using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            RegistroUsuario frm = new RegistroUsuario();
            frm.ShowDialog();
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UcVerUsuarios uc = new UcVerUsuarios();

            uc.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(uc);

            uc.BringToFront();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbFechaHora_Click(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy    HH:mm");
        }
    }
}
