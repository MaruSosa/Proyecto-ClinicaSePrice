using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice
{
    public partial class Insumos : Form
    {
        // DLLs para poder arrastrar la ventana personalizada sin bordes nativos
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public Insumos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy    HH:mm");
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

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnNuevoInsumo_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UcNuevoInsumo uc = new UcNuevoInsumo();
            uc.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnVerInsumos_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UcVerInsumos uc = new UcVerInsumos();
            uc.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(uc);
            uc.BringToFront();
        }
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

    }
}
