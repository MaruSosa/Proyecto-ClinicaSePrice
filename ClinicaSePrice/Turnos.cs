using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ClinicaSePrice
{
    public partial class PanelTurnos : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam
        );

        public PanelTurnos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UcNuevoTurno uc = new UcNuevoTurno();

            uc.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(uc);

            uc.BringToFront();
        
    }

        private void btnVerTurnos_Click(object sender, EventArgs e)
        {
            UcVerTurnos uc = new UcVerTurnos();
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFechaHora.Text =DateTime.Now.ToString("dd/MM/yyyy    HH:mm");
        }

        private void btnBuscarTurnoPaciente_Click(object sender, EventArgs e)
        {
            UcTurnoPacientePago uc = new UcTurnoPacientePago();
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            UcTurnoPacientePago uc = new UcTurnoPacientePago();
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(uc);
            // OCULTAMOS la sección de pago para este botón
            uc.MostrarSeccionBusqueda(false);
            panelContenido.Controls.Add(uc);
            uc.BringToFront();
            uc.Dock = DockStyle.Fill;
        }

    }
}
