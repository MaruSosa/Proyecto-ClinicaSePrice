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
    public partial class Profesionales : Form
    {
        public Profesionales()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy    HH:mm");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNuevoProfesional_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UcNuevoProfesional uc = new UcNuevoProfesional();

            uc.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(uc);

            uc.BringToFront();
        }

        private void btnVerProfesionales_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UcVerProfesionales uc = new UcVerProfesionales();
            uc.Dock = DockStyle.Fill;

            // OCULTAMOS la sección de búsqueda para este botón
            uc.MostrarSeccionBusqueda(false);

            panelContenido.Controls.Add(uc);
            uc.BringToFront();

        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UcVerProfesionales uc = new UcVerProfesionales();
            uc.Dock = DockStyle.Fill;

            // MOSTRAMOS la sección de búsqueda para este botón
            uc.MostrarSeccionBusqueda(true);

            panelContenido.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
