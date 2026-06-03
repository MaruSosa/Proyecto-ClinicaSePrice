using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice
{
    public partial class Pacientes : Form
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

        public Pacientes()
        {
            InitializeComponent();
        }

       

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void btnMaximizar_Click_1(object sender, EventArgs e)
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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy    HH:mm");
        }

        private void panelSuperior_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(
                this.Handle,
                0x112,
                0xf012,
                0);
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UcNuevoPaciente uc = new UcNuevoPaciente();

            uc.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(uc);

            uc.BringToFront();
        }
        private void CargarUC(UserControl uc)
        {
            panelContenido.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(uc);
        }
        private void btnVerPacientes_Click(object sender, EventArgs e)
        {

            panelContenido.Controls.Clear();

            UcVerPacientes uc = new UcVerPacientes();

            uc.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(uc);

            uc.BringToFront();
        }

    }
}
