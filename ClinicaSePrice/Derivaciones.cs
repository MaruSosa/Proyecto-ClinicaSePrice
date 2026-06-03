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

    public partial class Derivaciones : Form
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

        public Derivaciones()
        {
            InitializeComponent();
        }

        private void btnNuevaDerivacion_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();

            UcNuevaDerivacion uc = new UcNuevaDerivacion();

            uc.Dock = DockStyle.Fill;

            panelCentral.Controls.Add(uc);

            uc.BringToFront();
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

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy    HH:mm");
        }
    }
}
